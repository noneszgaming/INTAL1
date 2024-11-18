namespace SprintDemo
{
    partial class SprintDemo
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
            this.taskPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // taskPanel
            // 
            this.taskPanel.Location = new System.Drawing.Point(12, 12);
            this.taskPanel.Name = "taskPanel";
            this.taskPanel.Size = new System.Drawing.Size(200, 680);
            this.taskPanel.TabIndex = 0;
            this.taskPanel.Click += new System.EventHandler(this.OnTaskPanelClick);
            // 
            // SprintDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 704);
            this.Controls.Add(this.taskPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SprintDemo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "demo";
            this.Click += new System.EventHandler(this.OnFormClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel taskPanel;
    }
}

