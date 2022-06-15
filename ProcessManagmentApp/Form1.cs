using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessManagmentApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Process[] processes;
        
        //Gets the currently active processes
        void getProcesses()
        {
            processes = Process.GetProcesses();
            TasksGrid.Rows.Clear();
            foreach (var process in processes)
            {
                TasksGrid.Rows.Add(process.ProcessName, process.Id);
            }
            this.TasksGrid.Sort(this.TasksGrid.Columns["Task"], ListSortDirection.Ascending);
        }

        //Updates the processes in the DataGridView
        private void Form1_Load(object sender, EventArgs e)
        {
            getProcesses();
        }

        //Kills a task by pressing the EndTask button
        private void EndTask_Click(object sender, EventArgs e)
        {
            try
            {
                Process.GetProcessById(Convert.ToInt32(TasksGrid.CurrentRow.Cells["ID"].Value)).Kill();
                TasksGrid.Refresh();
                getProcesses();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //EndTask button mouse functions
        private void EndTask_MouseHover(object sender, EventArgs e)
        {
            EndTask.BackColor = Color.Tomato;
        }
        private void EndTask_MouseLeave(object sender, EventArgs e)
        {
            EndTask.BackColor = Color.Transparent;
        }
        private void EndTask_MouseMove(object sender, MouseEventArgs e)
        {
            EndTask.BackColor = Color.Tomato;
        }

        //Runs a new process asked by the user
        private void runANewTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(RunTask rt = new RunTask())
            {
                if (rt.ShowDialog() == DialogResult.OK)
                    getProcesses();
            }
        }

        //Closes the program
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Search button functions
        private void Search_Click(object sender, EventArgs e)
        {
            Search.SelectionStart = 0;
            Search.SelectionLength = Search.Text.Length;
        }

        //Searches for a requasted process by the user (by pressing [Enter])
        private void Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                processes = Process.GetProcesses();
                TasksGrid.Rows.Clear();
                foreach (var process in processes)
                {
                    if (process.ProcessName == Search.Text)
                        TasksGrid.Rows.Add(process.ProcessName, process.Id);
                }
                if (TasksGrid.RowCount == 0)
                {
                    MessageBox.Show("No task Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Search.Text = "Search";
                Search.SelectionStart = 0;
                Search.SelectionLength = Search.Text.Length;
            }
        }

        //Refreshes the data in the DataGridView
        private void Refresh_Click(object sender, EventArgs e)
        {
            getProcesses();
        }
    }
}
