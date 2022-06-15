using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProcessManagmentApp
{
    public partial class RunTask : Form
    {
        public RunTask()
        {
            InitializeComponent();
        }

        private void Run_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Type.Text))
            {
                try
                {
                    Process proc = new Process();
                    proc.StartInfo.FileName = Type.Text;
                    proc.Start();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
