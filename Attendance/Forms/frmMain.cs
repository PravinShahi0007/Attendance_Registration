using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Helpers;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using Attendance.Classes;
using System.Threading;
using System.IO;
using System.Net;
using ConnectUNCWithCredentials;
using System.Reflection;
using Attendance.Forms;

namespace Attendance
{
    public partial class frmMain : XtraForm
    {
        public static string cnstr = Utils.Helper.constr;
        public static Utils.DbCon tdb = Utils.Helper.ReadConDb("DBCON");
        

        public frmMain()
        {
            InitializeComponent();
            stsUserID.Text = Utils.User.GUserID;
            stsUserDesc.Text = Utils.User.GUserName;

            this.Text = "Employee Registration";
        }

        

       

        private void frmMain_Load(object sender, EventArgs e)
        {
           this.mnuHelp.Enabled = true;
           this.mnuAbout.Enabled = true;
           
        }

       

        private void mnuDBConn_Click(object sender, EventArgs e)
        {
            
            Form t = Application.OpenForms["FrmConnection"];

            if (t == null)
            {
                FrmConnection m = new FrmConnection();
                m.MdiParent = this;
                m.typeofcon = "DBCON";
                m.Show();
            }

        }

       
        private void MnuReaderConfig_Click(object sender, EventArgs e)
        {
            Form t = Application.OpenForms["frmReaderConfig"];

            if (t == null)
            {
                Attendance.Forms.frmReaderConfig m = new Attendance.Forms.frmReaderConfig();
                m.MdiParent = this;
                m.Show();
            }
        }

        
        private void mnuAbout_Click(object sender, EventArgs e)
        {
            string msg = "Attedance System" + Environment.NewLine +
                "Version 2.1 " + Environment.NewLine +
                "Design & Devloped By : Anand Achraya " + Environment.NewLine;

            MessageBox.Show(msg, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnuUserManagement_Click(object sender, EventArgs e)
        {
            Form t = Application.OpenForms["frmMastUserManagement"];

            if (t == null)
            {
                frmMastUserManagement m = new frmMastUserManagement();
                m.MdiParent = this;
                m.Show();
            }
        }

        private void mnuHelp_Click(object sender, EventArgs e)
        {

        }

        private void mnuChangePass_Click(object sender, EventArgs e)
        {
            Form t = Application.OpenForms["frmChangePass"];

            if (t == null)
            {
                Attendance.Forms.frmChangePass m = new Attendance.Forms.frmChangePass();
                m.MdiParent = this;
                m.Show();
            }
        }

    }
}