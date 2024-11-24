namespace TestProgram
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Login_button = new Button();
            Login_textBox = new TextBox();
            vote_textBox = new TextBox();
            vote_button = new Button();
            dataGridView1 = new DataGridView();
            list_button = new Button();
            username_label = new Label();
            update_textBox = new TextBox();
            update_button = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Login_button
            // 
            Login_button.Location = new Point(143, 169);
            Login_button.Name = "Login_button";
            Login_button.Size = new Size(108, 27);
            Login_button.TabIndex = 0;
            Login_button.Text = "Login";
            Login_button.UseVisualStyleBackColor = true;
            Login_button.Click += button1_Click;
            // 
            // Login_textBox
            // 
            Login_textBox.Location = new Point(101, 140);
            Login_textBox.Name = "Login_textBox";
            Login_textBox.Size = new Size(203, 23);
            Login_textBox.TabIndex = 1;
            // 
            // vote_textBox
            // 
            vote_textBox.Location = new Point(376, 257);
            vote_textBox.Name = "vote_textBox";
            vote_textBox.Size = new Size(40, 23);
            vote_textBox.TabIndex = 2;
            // 
            // vote_button
            // 
            vote_button.Location = new Point(331, 286);
            vote_button.Name = "vote_button";
            vote_button.Size = new Size(131, 152);
            vote_button.TabIndex = 3;
            vote_button.Text = "Vote";
            vote_button.UseVisualStyleBackColor = true;
            vote_button.Click += Vote_button;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(477, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(321, 443);
            dataGridView1.TabIndex = 4;
            // 
            // list_button
            // 
            list_button.Location = new Point(396, 12);
            list_button.Name = "list_button";
            list_button.Size = new Size(75, 23);
            list_button.TabIndex = 5;
            list_button.Text = "List";
            list_button.UseVisualStyleBackColor = true;
            list_button.Click += button3_Click;
            // 
            // username_label
            // 
            username_label.AutoSize = true;
            username_label.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            username_label.Location = new Point(12, 20);
            username_label.Name = "username_label";
            username_label.Size = new Size(0, 32);
            username_label.TabIndex = 6;
            // 
            // update_textBox
            // 
            update_textBox.Location = new Point(34, 334);
            update_textBox.Name = "update_textBox";
            update_textBox.Size = new Size(126, 23);
            update_textBox.TabIndex = 7;
            // 
            // update_button
            // 
            update_button.Location = new Point(60, 363);
            update_button.Name = "update_button";
            update_button.Size = new Size(75, 23);
            update_button.TabIndex = 8;
            update_button.Text = "Update";
            update_button.UseVisualStyleBackColor = true;
            update_button.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(update_button);
            Controls.Add(update_textBox);
            Controls.Add(username_label);
            Controls.Add(list_button);
            Controls.Add(dataGridView1);
            Controls.Add(vote_button);
            Controls.Add(vote_textBox);
            Controls.Add(Login_textBox);
            Controls.Add(Login_button);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Login_button;
        private TextBox Login_textBox;
        private TextBox vote_textBox;
        private Button vote_button;
        private DataGridView dataGridView1;
        private Button list_button;
        private Label username_label;
        private TextBox update_textBox;
        private Button update_button;
    }
}
