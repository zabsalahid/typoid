namespace typoid
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnAttach = new System.Windows.Forms.Button();
            this.lblProcess = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBreakMinutes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtThreshold = new System.Windows.Forms.TextBox();
            this.chkRandomDouble = new System.Windows.Forms.CheckBox();
            this.chkRandomSkip = new System.Windows.Forms.CheckBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCommands = new System.Windows.Forms.DataGridView();
            this.btnStart = new System.Windows.Forms.Button();
            this.rtbMessages = new System.Windows.Forms.RichTextBox();
            this.isEnabled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.threshold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isStarted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randomSkip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randomDouble = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.break_minutes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onBreak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastBreak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommands)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAttach
            // 
            this.btnAttach.Location = new System.Drawing.Point(12, 7);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(75, 23);
            this.btnAttach.TabIndex = 0;
            this.btnAttach.Text = "Attach";
            this.btnAttach.UseVisualStyleBackColor = true;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // lblProcess
            // 
            this.lblProcess.AutoSize = true;
            this.lblProcess.Location = new System.Drawing.Point(93, 12);
            this.lblProcess.Name = "lblProcess";
            this.lblProcess.Size = new System.Drawing.Size(0, 13);
            this.lblProcess.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBreakMinutes);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtThreshold);
            this.groupBox1.Controls.Add(this.chkRandomDouble);
            this.groupBox1.Controls.Add(this.chkRandomSkip);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtInterval);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rtbMessage);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 246);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // txtBreakMinutes
            // 
            this.txtBreakMinutes.Location = new System.Drawing.Point(286, 131);
            this.txtBreakMinutes.Name = "txtBreakMinutes";
            this.txtBreakMinutes.Size = new System.Drawing.Size(79, 20);
            this.txtBreakMinutes.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Break(Minutes)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Threshold";
            // 
            // txtThreshold
            // 
            this.txtThreshold.Location = new System.Drawing.Point(74, 157);
            this.txtThreshold.Name = "txtThreshold";
            this.txtThreshold.Size = new System.Drawing.Size(79, 20);
            this.txtThreshold.TabIndex = 11;
            // 
            // chkRandomDouble
            // 
            this.chkRandomDouble.AutoSize = true;
            this.chkRandomDouble.Location = new System.Drawing.Point(192, 183);
            this.chkRandomDouble.Name = "chkRandomDouble";
            this.chkRandomDouble.Size = new System.Drawing.Size(130, 17);
            this.chkRandomDouble.TabIndex = 10;
            this.chkRandomDouble.Text = "Random Double Entry";
            this.chkRandomDouble.UseVisualStyleBackColor = true;
            // 
            // chkRandomSkip
            // 
            this.chkRandomSkip.AutoSize = true;
            this.chkRandomSkip.Location = new System.Drawing.Point(84, 183);
            this.chkRandomSkip.Name = "chkRandomSkip";
            this.chkRandomSkip.Size = new System.Drawing.Size(90, 17);
            this.chkRandomSkip.TabIndex = 9;
            this.chkRandomSkip.Text = "Random Skip";
            this.chkRandomSkip.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(150, 217);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(230, 217);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(69, 217);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtInterval
            // 
            this.txtInterval.Location = new System.Drawing.Point(74, 131);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(79, 20);
            this.txtInterval.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Interval";
            // 
            // rtbMessage
            // 
            this.rtbMessage.Location = new System.Drawing.Point(74, 39);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.Size = new System.Drawing.Size(291, 86);
            this.rtbMessage.TabIndex = 3;
            this.rtbMessage.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Message";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(74, 13);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(291, 20);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // dgvCommands
            // 
            this.dgvCommands.AllowUserToAddRows = false;
            this.dgvCommands.AllowUserToDeleteRows = false;
            this.dgvCommands.AllowUserToResizeRows = false;
            this.dgvCommands.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCommands.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCommands.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isEnabled,
            this.id,
            this.name,
            this.message,
            this.interval,
            this.threshold,
            this.isStarted,
            this.proc,
            this.randomSkip,
            this.randomDouble,
            this.break_minutes,
            this.onBreak,
            this.lastBreak});
            this.dgvCommands.Location = new System.Drawing.Point(411, 12);
            this.dgvCommands.Name = "dgvCommands";
            this.dgvCommands.ReadOnly = true;
            this.dgvCommands.RowHeadersVisible = false;
            this.dgvCommands.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCommands.Size = new System.Drawing.Size(529, 437);
            this.dgvCommands.TabIndex = 4;
            this.dgvCommands.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCommands_CellContentClick);
            this.dgvCommands.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCommands_CellDoubleClick);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 36);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // rtbMessages
            // 
            this.rtbMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbMessages.Location = new System.Drawing.Point(12, 317);
            this.rtbMessages.Name = "rtbMessages";
            this.rtbMessages.Size = new System.Drawing.Size(383, 132);
            this.rtbMessages.TabIndex = 6;
            this.rtbMessages.Text = "";
            // 
            // isEnabled
            // 
            this.isEnabled.DataPropertyName = "isEnabled";
            this.isEnabled.HeaderText = "Enabled";
            this.isEnabled.Name = "isEnabled";
            this.isEnabled.ReadOnly = true;
            this.isEnabled.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isEnabled.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.isEnabled.Width = 50;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 80;
            // 
            // message
            // 
            this.message.DataPropertyName = "message";
            this.message.HeaderText = "Message";
            this.message.Name = "message";
            this.message.ReadOnly = true;
            this.message.Width = 80;
            // 
            // interval
            // 
            this.interval.DataPropertyName = "interval";
            this.interval.HeaderText = "Interval";
            this.interval.Name = "interval";
            this.interval.ReadOnly = true;
            this.interval.Width = 60;
            // 
            // threshold
            // 
            this.threshold.DataPropertyName = "threshold";
            this.threshold.HeaderText = "Threshold";
            this.threshold.Name = "threshold";
            this.threshold.ReadOnly = true;
            this.threshold.Width = 60;
            // 
            // isStarted
            // 
            this.isStarted.DataPropertyName = "isStarted";
            this.isStarted.HeaderText = "IsStarted";
            this.isStarted.Name = "isStarted";
            this.isStarted.ReadOnly = true;
            this.isStarted.Visible = false;
            // 
            // proc
            // 
            this.proc.DataPropertyName = "process";
            this.proc.HeaderText = "Process";
            this.proc.Name = "proc";
            this.proc.ReadOnly = true;
            this.proc.Visible = false;
            // 
            // randomSkip
            // 
            this.randomSkip.DataPropertyName = "random_skip";
            this.randomSkip.HeaderText = "Random Skip";
            this.randomSkip.Name = "randomSkip";
            this.randomSkip.ReadOnly = true;
            this.randomSkip.Width = 50;
            // 
            // randomDouble
            // 
            this.randomDouble.DataPropertyName = "random_double";
            this.randomDouble.HeaderText = "Random Double Entry";
            this.randomDouble.Name = "randomDouble";
            this.randomDouble.ReadOnly = true;
            this.randomDouble.Width = 60;
            // 
            // break_minutes
            // 
            this.break_minutes.DataPropertyName = "break_minutes";
            this.break_minutes.HeaderText = "Break (Minutes)";
            this.break_minutes.Name = "break_minutes";
            this.break_minutes.ReadOnly = true;
            this.break_minutes.Width = 60;
            // 
            // onBreak
            // 
            this.onBreak.DataPropertyName = "onBreak";
            this.onBreak.HeaderText = "onBreak";
            this.onBreak.Name = "onBreak";
            this.onBreak.ReadOnly = true;
            this.onBreak.Visible = false;
            // 
            // lastBreak
            // 
            this.lastBreak.DataPropertyName = "lastBreak";
            this.lastBreak.HeaderText = "lastBreak";
            this.lastBreak.Name = "lastBreak";
            this.lastBreak.ReadOnly = true;
            this.lastBreak.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 461);
            this.Controls.Add(this.rtbMessages);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.dgvCommands);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblProcess);
            this.Controls.Add(this.btnAttach);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(968, 500);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Typoid";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommands)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.Label lblProcess;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvCommands;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RichTextBox rtbMessages;
        private System.Windows.Forms.CheckBox chkRandomDouble;
        private System.Windows.Forms.CheckBox chkRandomSkip;
        private System.Windows.Forms.TextBox txtBreakMinutes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtThreshold;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isEnabled;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn message;
        private System.Windows.Forms.DataGridViewTextBoxColumn interval;
        private System.Windows.Forms.DataGridViewTextBoxColumn threshold;
        private System.Windows.Forms.DataGridViewTextBoxColumn isStarted;
        private System.Windows.Forms.DataGridViewTextBoxColumn proc;
        private System.Windows.Forms.DataGridViewTextBoxColumn randomSkip;
        private System.Windows.Forms.DataGridViewTextBoxColumn randomDouble;
        private System.Windows.Forms.DataGridViewTextBoxColumn break_minutes;
        private System.Windows.Forms.DataGridViewTextBoxColumn onBreak;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastBreak;
    }
}