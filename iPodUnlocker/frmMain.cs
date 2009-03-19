using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace iPodUnlocker
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            dlgFolder.ShowDialog();
            string tpath = dlgFolder.SelectedPath;
            string[] tt = tpath.Split("\\".ToCharArray());
            txtPath.Text = tt[0] + "\\";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUnlock_Click(object sender, EventArgs e)
        {
            if (txtPath.Text != "")
            {
                if (File.Exists(txtPath.Text + "\\iPod_Control\\Device\\iPodSettings.xml"))
                {
                    if (!File.Exists(txtPath.Text + "\\iPod_Control\\Device\\_locked") || File.Exists(txtPath.Text + "\\iPod_Control\\Device\\_unlocked"))
                    {
                        MessageBox.Show("This device is already unlocked.", "iPod Unlocker", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        try { File.Delete(txtPath.Text + "\\iPod_Control\\Device\\_locked"); }
                        catch { MessageBox.Show("There was an unexpected error unlocking the device.", "iPod Unlocker", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                        MessageBox.Show("The device was successfully unlocked.","iPod Unlocker",MessageBoxButtons.OK,MessageBoxIcon.Information);

                    }
                }
                else
                {
                    MessageBox.Show("This drive is not a recognized iPod Device. Please plug in a valid iPod Nano or iPod Classic to unlock.", "iPod Unlocker", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("No device selected.","iPod Unlocker",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
