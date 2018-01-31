using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace typoid
{
    public partial class frmProcessList : Form
    {
        public frmProcessList()
        {
            InitializeComponent();
        }

        private void frmProcessList_Load(object sender, EventArgs e)
        {
            PopulateList();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Select();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateList(txtSearch.Text);
        }

        private void PopulateList(string search = "")
        {
            var processes = Process.GetProcesses().Where(a => a.MainWindowTitle.Length > 0 && a.ProcessName.ToLower().Contains(search)).ToList();
            lbOptions.DataSource = processes;
            lbOptions.DisplayMember = "MainWindowTitle";
        }

        private void lbOptions_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Select();
        }

        private void Select()
        {
            if (lbOptions.SelectedItem != null)
            {
                this.Tag = lbOptions.SelectedItem;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PopulateList(txtSearch.Text);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PopulateList(txtSearch.Text);
            }
        }
    }
}
