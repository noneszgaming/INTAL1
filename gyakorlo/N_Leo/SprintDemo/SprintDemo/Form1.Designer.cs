namespace SprintDemo
{
    partial class SprintDemoForm
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
            this.userLabel1 = new System.Windows.Forms.Label();
            this.userLabel2 = new System.Windows.Forms.Label();
            this.userLabel3 = new System.Windows.Forms.Label();
            this.lobbyLabel1 = new System.Windows.Forms.Label();
            this.lobbyLabel2 = new System.Windows.Forms.Label();
            this.lobbyLabel3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userLabel1
            // 
            this.userLabel1.AutoSize = true;
            this.userLabel1.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.userLabel1.Location = new System.Drawing.Point(12, 9);
            this.userLabel1.Name = "userLabel1";
            this.userLabel1.Size = new System.Drawing.Size(99, 34);
            this.userLabel1.TabIndex = 0;
            this.userLabel1.Text = "User1";
            // 
            // userLabel2
            // 
            this.userLabel2.AutoSize = true;
            this.userLabel2.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.userLabel2.Location = new System.Drawing.Point(12, 82);
            this.userLabel2.Name = "userLabel2";
            this.userLabel2.Size = new System.Drawing.Size(99, 34);
            this.userLabel2.TabIndex = 1;
            this.userLabel2.Text = "User2";
            // 
            // userLabel3
            // 
            this.userLabel3.AutoSize = true;
            this.userLabel3.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.userLabel3.Location = new System.Drawing.Point(12, 161);
            this.userLabel3.Name = "userLabel3";
            this.userLabel3.Size = new System.Drawing.Size(99, 34);
            this.userLabel3.TabIndex = 2;
            this.userLabel3.Text = "User3";
            // 
            // lobbyLabel1
            // 
            this.lobbyLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lobbyLabel1.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lobbyLabel1.Location = new System.Drawing.Point(180, 9);
            this.lobbyLabel1.Name = "lobbyLabel1";
            this.lobbyLabel1.Size = new System.Drawing.Size(333, 655);
            this.lobbyLabel1.TabIndex = 3;
            this.lobbyLabel1.Text = "Lobby1";
            this.lobbyLabel1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lobbyLabel2
            // 
            this.lobbyLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lobbyLabel2.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lobbyLabel2.Location = new System.Drawing.Point(519, 9);
            this.lobbyLabel2.Name = "lobbyLabel2";
            this.lobbyLabel2.Size = new System.Drawing.Size(333, 655);
            this.lobbyLabel2.TabIndex = 4;
            this.lobbyLabel2.Text = "Lobby2";
            this.lobbyLabel2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lobbyLabel3
            // 
            this.lobbyLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lobbyLabel3.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lobbyLabel3.Location = new System.Drawing.Point(858, 9);
            this.lobbyLabel3.Name = "lobbyLabel3";
            this.lobbyLabel3.Size = new System.Drawing.Size(333, 655);
            this.lobbyLabel3.TabIndex = 5;
            this.lobbyLabel3.Text = "Lobby3";
            this.lobbyLabel3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // SprintDemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.lobbyLabel3);
            this.Controls.Add(this.lobbyLabel2);
            this.Controls.Add(this.lobbyLabel1);
            this.Controls.Add(this.userLabel3);
            this.Controls.Add(this.userLabel2);
            this.Controls.Add(this.userLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SprintDemoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo";
            this.Click += new System.EventHandler(this.OnClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userLabel1;
        private System.Windows.Forms.Label userLabel2;
        private System.Windows.Forms.Label userLabel3;
        private System.Windows.Forms.Label lobbyLabel1;
        private System.Windows.Forms.Label lobbyLabel2;
        private System.Windows.Forms.Label lobbyLabel3;
    }
}

