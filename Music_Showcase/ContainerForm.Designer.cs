namespace Music_Showcase
{
    partial class Container
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
            panel1 = new Panel();
            userTypeLabel = new Label();
            usernameLabel = new Label();
            profilePictureBox = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profilePictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.gradient11;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(userTypeLabel);
            panel1.Controls.Add(usernameLabel);
            panel1.Controls.Add(profilePictureBox);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1065, 49);
            panel1.TabIndex = 0;
            // 
            // userTypeLabel
            // 
            userTypeLabel.AutoSize = true;
            userTypeLabel.BackColor = Color.Transparent;
            userTypeLabel.Font = new Font("Cambria", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userTypeLabel.ForeColor = Color.FromArgb(255, 224, 192);
            userTypeLabel.Location = new Point(888, 9);
            userTypeLabel.Name = "userTypeLabel";
            userTypeLabel.Size = new Size(164, 32);
            userTypeLabel.TabIndex = 4;
            userTypeLabel.Text = "ΥΠΑΛΛΗΛΟΣ";
            userTypeLabel.Click += userTypeLabel_Click;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.BackColor = Color.Transparent;
            usernameLabel.Font = new Font("Cambria", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameLabel.ForeColor = Color.FromArgb(255, 224, 192);
            usernameLabel.Location = new Point(63, 9);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(84, 32);
            usernameLabel.TabIndex = 2;
            usernameLabel.Text = "label1";
            usernameLabel.Click += usernameLabel_Click;
            // 
            // profilePictureBox
            // 
            profilePictureBox.Location = new Point(0, 0);
            profilePictureBox.Name = "profilePictureBox";
            profilePictureBox.Size = new Size(57, 49);
            profilePictureBox.TabIndex = 1;
            profilePictureBox.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(180, 79, 33);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Cambria", 15.75F);
            button1.ForeColor = Color.FromArgb(255, 224, 192);
            button1.Location = new Point(0, 46);
            button1.Name = "button1";
            button1.Size = new Size(171, 130);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(197, 100, 51);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Cambria", 15.75F);
            button2.ForeColor = Color.FromArgb(255, 224, 192);
            button2.Location = new Point(0, 173);
            button2.Name = "button2";
            button2.Size = new Size(171, 130);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(213, 122, 69);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Cambria", 15.75F);
            button3.ForeColor = Color.FromArgb(255, 224, 192);
            button3.Location = new Point(0, 300);
            button3.Name = "button3";
            button3.Size = new Size(171, 130);
            button3.TabIndex = 3;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(230, 143, 86);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Cambria", 15.75F);
            button4.ForeColor = Color.FromArgb(255, 224, 192);
            button4.Location = new Point(0, 425);
            button4.Name = "button4";
            button4.Size = new Size(171, 130);
            button4.TabIndex = 4;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(246, 164, 104);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Cambria", 15.75F);
            button5.ForeColor = Color.Sienna;
            button5.Location = new Point(0, 551);
            button5.Name = "button5";
            button5.Size = new Size(171, 130);
            button5.TabIndex = 5;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = false;
            // 
            // Container
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 681);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Container";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Music Showcase";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)profilePictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox profilePictureBox;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label usernameLabel;
        private Label userTypeLabel;
    }
}
