using Keyboard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using typoid.Common;
using typoid.Functions;
using typoid.Models;

namespace typoid
{
    public partial class frmMain : Form
    {
        private Process process;
        private bool isProcessing = false;

        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);
        private CommandFunctions commandFunctions = new CommandFunctions();
        private Command currentCommand = null;
        private static List<Command> commands = new List<Command>();
        private static List<Command> commandsToProcess = new List<Command>();
        private Thread commandProcessor = null;
        private Thread commandBuilder = null;
        private Random rnd = new Random();

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            using (var frm = new frmProcessList())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    process = (Process)frm.Tag;
                    lblProcess.Text = process.ProcessName;
                }
            }
        }

        private void StartBot()
        {
            try
            {
                string text = rtbMessage.Text + "\r";
                List<Key> keys = text.Select(c => new Key(c)).ToList();
                Console.WriteLine(string.Format(@"Sending background keypresses to write ({0})", text));
                SetForegroundWindow(process.MainWindowHandle);
                process.WaitForInputIdle();
                foreach (var key in keys)
                {
                    key.PressForeground(process.MainWindowHandle);
                }

            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void QueueProcessor()
        { }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (currentCommand == null)
            {
                currentCommand = new Command();
                currentCommand.id = 0;
                currentCommand.name = txtName.Text;
                currentCommand.message = rtbMessage.Text;
                if (currentCommand.message[currentCommand.message.Length - 1] != '\n')
                    currentCommand.message += '\n';
                long interval = 0;
                long.TryParse(txtInterval.Text, out interval);
                currentCommand.interval = interval;
                currentCommand.random_skip = Convert.ToInt64(chkRandomSkip.Checked);
                currentCommand.random_double = Convert.ToInt64(chkRandomDouble.Checked);
            }
            else
            {
                currentCommand.name = txtName.Text;
                currentCommand.message = rtbMessage.Text;
                if (currentCommand.message[currentCommand.message.Length - 1] != '\n')
                    currentCommand.message += '\n';
                long interval = 0;
                long.TryParse(txtInterval.Text, out interval);
                currentCommand.interval = interval;
                currentCommand.random_skip = Convert.ToInt64(chkRandomSkip.Checked);
                currentCommand.random_double = Convert.ToInt64(chkRandomDouble.Checked);
            }
            SaveCommand(currentCommand);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (currentCommand != null)
            {
                commandFunctions.DeleteCommand(currentCommand);
                currentCommand = null;
                updateCurrentSelection();
                PopulateCommands();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            currentCommand = null;
            updateCurrentSelection();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            BuildConnectionString();
        }

        public void BuildConnectionString()
        {
            if (String.IsNullOrEmpty(Storage.ConnectionString))
            {
                Storage.ConnectionString = string.Format("Data Source={0};Version=3;", AppDomain.CurrentDomain.BaseDirectory + System.Configuration.ConfigurationManager.AppSettings["DatabaseFile"]);
                PopulateCommands();
            }
        }

        public void PopulateCommands()
        {
            
            if (commands != null)
            {
                var get = commandFunctions.GetCommands();
                get.ForEach(a => 
                {
                    var targetCmd = commands.FirstOrDefault(b => b.id == a.id);
                    if (targetCmd != null)
                    {
                        targetCmd.message = a.message;
                        targetCmd.interval = a.interval;
                        targetCmd.name = a.name;
                    }
                    else
                    {
                        commands.Add(a);
                    }
                });
                commands.ToList().ForEach(a =>
                {
                    if (!get.Any(b => b.id == a.id))
                    {
                        commands.Remove(a);
                    }
                });
                commands = commands.ToList();
            }
            else
            {
                commands = commandFunctions.GetCommands();
            }
            dgvCommands.DataSource = commands;
        }

        private void dgvCommands_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                currentCommand = dgvCommands.Rows[e.RowIndex].DataBoundItem as Command;
                updateCurrentSelection();
            }
        }

        private void updateCurrentSelection()
        {
            if (currentCommand != null)
            {
                btnDelete.Enabled = true;
                txtName.Text = currentCommand.name;
                txtInterval.Text = currentCommand.interval.ToString();
                rtbMessage.Text = currentCommand.message;
                chkRandomSkip.Checked = Convert.ToBoolean(currentCommand.random_skip);
                chkRandomDouble.Checked = Convert.ToBoolean(currentCommand.random_double);
            }
            else
            {
                btnDelete.Enabled = false;
                txtName.Text = "";
                txtInterval.Text = "";
                rtbMessage.Text = "";
                chkRandomSkip.Checked = false;
                chkRandomDouble.Checked = false;
            }
        }

        private void SaveCommand(Command command)
        {
            if (command.id > 0)
            {
                commandFunctions.UpdateCommand(command);
            }
            else
            {
                commandFunctions.InsertCommand(command);
            }
            currentCommand = null;
            updateCurrentSelection();
            PopulateCommands();
        }

        private void CommandsProcessor()
        {
            while (isProcessing && !this.IsDisposed && process != null)
            {
                if (commands.Count > 0)
                {
                    try
                    {
                        var toProcess = commandsToProcess.ToList();
                        foreach (var cmd in toProcess)
                        {
                            if (cmd.message.Trim().Length > 0)
                            {
                                SetForegroundWindow(process.MainWindowHandle);
                                process.WaitForInputIdle();
                                List<Key> keys = cmd.message.Select(c => new Key(c)).ToList();
                                foreach (var key in keys)
                                {
                                    key.PressForeground(process.MainWindowHandle);
                                }
                                commandsToProcess.Remove(cmd);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        SetText(string.Format("Error: {0}", ex.Message));
                    }
                }
            }
        }

        private void CommandsBuilder()
        {
            while (isProcessing && !this.IsDisposed && process != null)
            {
                try
                {
                    commands.ForEach(a =>
                    {
                        if (!a.isStarted)
                        {
                            var targetCmd = commandsToProcess.Find(b => b.id == a.id);
                            if (targetCmd != null)
                            {
                                a.isStarted = targetCmd.isStarted;
                                a.message = targetCmd.message;
                                a.interval = targetCmd.interval;
                                a.process = targetCmd.process;
                                a.random_skip = targetCmd.random_skip;
                                a.random_double = targetCmd.random_double;
                            }
                            else
                            {
                                a.isStarted = true;
                                a.process = new Thread(() => CommandSend(a));
                                a.process.Start();
                            }
                        }
                    });
                }
                catch (Exception ex)
                {
                    SetText(string.Format("Error: {0}", ex.Message));
                }
            }
        }

        private void CommandSend(Command cmd)
        {
            if (isProcessing && !this.IsDisposed && process != null)
            {
                var targetCmd = commandsToProcess.Find(b => b.id == cmd.id);
                if (targetCmd != null)
                {
                    cmd.isStarted = targetCmd.isStarted;
                    cmd.message = targetCmd.message;
                    cmd.interval = targetCmd.interval;
                    cmd.random_skip = targetCmd.random_skip;
                    cmd.random_double = targetCmd.random_double;
                }
                long interval = (cmd.interval + rnd.Next(1, 10)) * 1000;
                if (Convert.ToBoolean(cmd.random_skip) && Convert.ToBoolean(rnd.Next(0, 2)))
                {
                    interval = cmd.interval * 1000;
                    SetText(string.Format("Skipped: {0}\nNext interval: {1} seconds", cmd.name, interval / 1000));
                }
                else
                {
                    if (Convert.ToBoolean(cmd.random_skip))
                    {
                        SetText(string.Format("Not skipped"));
                    }
                    SetText(string.Format("Sending: {0}\n{1}\nNext interval: {2} seconds", cmd.name, cmd.message, interval / 1000));
                    commandsToProcess.Add(cmd);
                    if (Convert.ToBoolean(cmd.random_double) && Convert.ToBoolean(rnd.Next(0, 2)))
                    {
                        long doubleEntry = (cmd.interval - (cmd.interval > 5 ? rnd.Next(2, 6) : cmd.interval * 2)) * 1000;
                        SetText(string.Format("Double Entry Interval: {0} seconds", doubleEntry / 1000));
                        Thread.Sleep(Convert.ToInt32(doubleEntry));
                        commandsToProcess.Add(cmd);
                    }
                }
                if (isProcessing && !this.IsDisposed && process != null)
                {
                    Thread.Sleep(Convert.ToInt32(interval));
                    CommandSend(cmd);
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (process != null)
            {
                if (commandProcessor != null)
                {
                    commandBuilder.Abort();
                    commandProcessor.Abort();
                    btnStart.Text = "Start";
                    commandProcessor = null;
                    commandBuilder = null;
                    commandsToProcess = new List<Command>();
                    isProcessing = false;
                    SetText("Stopping");
                    commands.ForEach(a => {
                        try
                        {
                            a.process.Abort();
                        }
                        catch (Exception ex)
                        {
                            SetText(ex.Message);
                        }
                    });
                    SetText("Stopped");
                }
                else
                {
                    SetText("Started");
                    btnStart.Text = "Stop";
                    isProcessing = true;
                    commands.ForEach(a =>
                    {
                        a.isStarted = false;
                    });
                    commandBuilder = new Thread(CommandsBuilder);
                    commandBuilder.Start();
                    commandProcessor = new Thread(CommandsProcessor);
                    commandProcessor.Start();
                }
            }
            else
            {
                MessageBox.Show("Please select a process to attach.");
            }
        }

        public void SetText(string message)
        {
            try
            {
                string messageL = message + "\n-----------------\n";
                if (!this.IsDisposed)
                {
                    if (this.InvokeRequired)
                    {
                        this.Invoke((Delegate)new MethodInvoker(() => this.SetText(message)));
                    }
                    else
                    {
                        if (this.rtbMessages.TextLength >= 100000)
                        {
                            this.rtbMessages.Clear();
                        }
                        this.rtbMessages.Text += messageL;
                        this.rtbMessages.SelectionStart = this.rtbMessages.Text.Length;
                        this.rtbMessages.ScrollToCaret();
                    }
                }
            }
            catch
            {
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            isProcessing = false;
            commands.ForEach(a => {
                try
                {
                    a.process.Abort();
                }
                catch (Exception ex)
                {
                    SetText(ex.Message);
                }
            });
        }
    }
}
