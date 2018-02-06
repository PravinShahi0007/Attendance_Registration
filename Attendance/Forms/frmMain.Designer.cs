namespace Attendance
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDBConn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUserManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsUserID = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsUserDesc = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsExtra = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnuChangePass = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1100, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbout,
            this.mnuDBConn,
            this.mnuUserManagement,
            this.mnuChangePass});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(37, 20);
            this.mnuHelp.Text = "File";
            this.mnuHelp.Click += new System.EventHandler(this.mnuHelp_Click);
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(171, 22);
            this.mnuAbout.Text = "About";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // mnuDBConn
            // 
            this.mnuDBConn.Name = "mnuDBConn";
            this.mnuDBConn.Size = new System.Drawing.Size(171, 22);
            this.mnuDBConn.Text = "Set Connection";
            this.mnuDBConn.Click += new System.EventHandler(this.mnuDBConn_Click);
            // 
            // mnuUserManagement
            // 
            this.mnuUserManagement.Name = "mnuUserManagement";
            this.mnuUserManagement.Size = new System.Drawing.Size(171, 22);
            this.mnuUserManagement.Text = "User Management";
            this.mnuUserManagement.Click += new System.EventHandler(this.mnuUserManagement_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.stsUserID,
            this.toolStripStatusLabel3,
            this.stsUserDesc,
            this.stsExtra});
            this.statusStrip1.Location = new System.Drawing.Point(0, 678);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1100, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(53, 17);
            this.toolStripStatusLabel1.Text = "User ID : ";
            // 
            // stsUserID
            // 
            this.stsUserID.Name = "stsUserID";
            this.stsUserID.Size = new System.Drawing.Size(49, 17);
            this.stsUserID.Text = "GUserID";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(74, 17);
            this.toolStripStatusLabel3.Text = "User Name : ";
            // 
            // stsUserDesc
            // 
            this.stsUserDesc.Name = "stsUserDesc";
            this.stsUserDesc.Size = new System.Drawing.Size(70, 17);
            this.stsUserDesc.Text = "GUserName";
            // 
            // stsExtra
            // 
            this.stsExtra.Name = "stsExtra";
            this.stsExtra.Size = new System.Drawing.Size(0, 17);
            // 
            // mnuChangePass
            // 
            this.mnuChangePass.Name = "mnuChangePass";
            this.mnuChangePass.Size = new System.Drawing.Size(171, 22);
            this.mnuChangePass.Text = "Change Password";
            this.mnuChangePass.Click += new System.EventHandler(this.mnuChangePass_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Attendance System Registration";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel stsUserID;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel stsUserDesc;
        private System.Windows.Forms.ToolStripStatusLabel stsExtra;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuDBConn;
        private System.Windows.Forms.ToolStripMenuItem mnuUserManagement;
        private System.Windows.Forms.ToolStripMenuItem mnuChangePass;


    }
}
