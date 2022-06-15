
namespace ProcessManagmentApp
{
    partial class RunTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RunTask));
            this.label1 = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.TextBox();
            this.Run = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Open:";
            // 
            // Type
            // 
            this.Type.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Type.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Type.Location = new System.Drawing.Point(67, 17);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(324, 23);
            this.Type.TabIndex = 1;
            this.Type.Text = "Type here";
            // 
            // Run
            // 
            this.Run.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Run.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Run.Location = new System.Drawing.Point(318, 58);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(73, 27);
            this.Run.TabIndex = 2;
            this.Run.Text = "&Run";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // RunTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(419, 97);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RunTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Run a new task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Type;
        private System.Windows.Forms.Button Run;
    }
}