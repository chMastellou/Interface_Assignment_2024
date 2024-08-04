namespace Music_Showcase
{
    partial class Book_Tickets
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
            zoneSelection = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            seatNo = new NumericUpDown();
            seatBox = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)seatNo).BeginInit();
            SuspendLayout();
            // 
            // zoneSelection
            // 
            zoneSelection.Font = new Font("Microsoft Sans Serif", 12F);
            zoneSelection.FormattingEnabled = true;
            zoneSelection.Items.AddRange(new object[] { "Α", "Β", "Γ", "Δ", "Ε" });
            zoneSelection.Location = new Point(41, 211);
            zoneSelection.Name = "zoneSelection";
            zoneSelection.Size = new Size(163, 28);
            zoneSelection.TabIndex = 0;
            zoneSelection.Text = "Α";
            zoneSelection.SelectedIndexChanged += zoneSelection_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(38, 33);
            label1.Name = "label1";
            label1.Size = new Size(335, 45);
            label1.TabIndex = 1;
            label1.Text = "ΕΚΔΟΣΗ ΕΙΣΙΤΗΡΙΩΝ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(38, 188);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 2;
            label2.Text = "ΖΩΝΗ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 12F);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(38, 106);
            label3.Name = "label3";
            label3.Size = new Size(119, 20);
            label3.TabIndex = 3;
            label3.Text = "ΗΜΕΡΟΜΗΝΙΑ";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.SlateBlue;
            button1.Location = new Point(128, 501);
            button1.Name = "button1";
            button1.Size = new Size(167, 53);
            button1.TabIndex = 5;
            button1.Text = " ΠΛΗΡΩΜΗ";
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.FvDtL_eXwB8wEMb;
            pictureBox1.Location = new Point(460, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(507, 664);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = Color.White;
            dateTimePicker1.CalendarMonthBackground = Color.Transparent;
            dateTimePicker1.CalendarTitleBackColor = Color.Transparent;
            dateTimePicker1.CalendarTitleForeColor = Color.White;
            dateTimePicker1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(41, 129);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(276, 29);
            dateTimePicker1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 12F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(38, 351);
            label4.Name = "label4";
            label4.Size = new Size(170, 20);
            label4.TabIndex = 8;
            label4.Text = "ΕΠΙΛΕΓΜΕΝΗ ΘΕΣΗ:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 12F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(38, 274);
            label5.Name = "label5";
            label5.Size = new Size(144, 20);
            label5.TabIndex = 10;
            label5.Text = "ΑΡΙΘΜΟΣ ΘΕΣΗΣ";
            // 
            // seatNo
            // 
            seatNo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            seatNo.Location = new Point(41, 297);
            seatNo.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            seatNo.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            seatNo.Name = "seatNo";
            seatNo.Size = new Size(163, 29);
            seatNo.TabIndex = 11;
            seatNo.Value = new decimal(new int[] { 1, 0, 0, 0 });
            seatNo.ValueChanged += seatNo_ValueChanged;
            // 
            // seatBox
            // 
            seatBox.AutoSize = true;
            seatBox.BackColor = Color.Transparent;
            seatBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            seatBox.Location = new Point(205, 347);
            seatBox.Name = "seatBox";
            seatBox.Size = new Size(34, 25);
            seatBox.TabIndex = 12;
            seatBox.Text = "Α1";
            // 
            // Book_Tickets
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Download_free_Dark_Purple_Color_background_images;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(964, 660);
            Controls.Add(seatBox);
            Controls.Add(seatNo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(zoneSelection);
            ForeColor = Color.White;
            Name = "Book_Tickets";
            Text = "Tickets";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)seatNo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox zoneSelection;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private PictureBox pictureBox1;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Label label5;
        private NumericUpDown seatNo;
        private Label seatBox;
    }
}