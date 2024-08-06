namespace Music_Showcase
{
    partial class Device_Management
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            panel6 = new Panel();
            backRightSound = new PictureBox();
            BRstate = new Label();
            backRightSpeaker = new PictureBox();
            label9 = new Label();
            panel5 = new Panel();
            backLeftSound = new PictureBox();
            BLstate = new Label();
            backLeftSpeaker = new PictureBox();
            label7 = new Label();
            panel4 = new Panel();
            frontRightSound = new PictureBox();
            FRstate = new Label();
            frontRightSpeaker = new PictureBox();
            label5 = new Label();
            panel3 = new Panel();
            frontLeftSound = new PictureBox();
            FLstate = new Label();
            frontLeftSpeaker = new PictureBox();
            label3 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)backRightSound).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backRightSpeaker).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)backLeftSound).BeginInit();
            ((System.ComponentModel.ISupportInitialize)backLeftSpeaker).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)frontRightSound).BeginInit();
            ((System.ComponentModel.ISupportInitialize)frontRightSpeaker).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)frontLeftSound).BeginInit();
            ((System.ComponentModel.ISupportInitialize)frontLeftSpeaker).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.51852F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.4814816F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1234, 989);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(4, 5);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(960, 979);
            panel1.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(backRightSound);
            panel6.Controls.Add(BRstate);
            panel6.Controls.Add(backRightSpeaker);
            panel6.Controls.Add(label9);
            panel6.Location = new Point(747, 748);
            panel6.Name = "panel6";
            panel6.Size = new Size(194, 219);
            panel6.TabIndex = 7;
            // 
            // backRightSound
            // 
            backRightSound.Cursor = Cursors.Hand;
            backRightSound.Image = Properties.Resources.sound_off;
            backRightSound.Location = new Point(76, 152);
            backRightSound.Name = "backRightSound";
            backRightSound.Size = new Size(38, 39);
            backRightSound.SizeMode = PictureBoxSizeMode.StretchImage;
            backRightSound.TabIndex = 2;
            backRightSound.TabStop = false;
            backRightSound.Click += backRightSpeaker_Click;
            // 
            // BRstate
            // 
            BRstate.AutoSize = true;
            BRstate.ForeColor = Color.White;
            BRstate.Location = new Point(66, 194);
            BRstate.Name = "BRstate";
            BRstate.Size = new Size(61, 20);
            BRstate.TabIndex = 4;
            BRstate.Text = "Κλειστό";
            // 
            // backRightSpeaker
            // 
            backRightSpeaker.Image = Properties.Resources.speaker_off;
            backRightSpeaker.Location = new Point(34, 23);
            backRightSpeaker.Name = "backRightSpeaker";
            backRightSpeaker.Size = new Size(120, 123);
            backRightSpeaker.SizeMode = PictureBoxSizeMode.StretchImage;
            backRightSpeaker.TabIndex = 1;
            backRightSpeaker.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(37, 0);
            label9.Name = "label9";
            label9.Size = new Size(117, 20);
            label9.TabIndex = 3;
            label9.Text = "Πίσω δεξί ηχείο";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.Controls.Add(backLeftSound);
            panel5.Controls.Add(BLstate);
            panel5.Controls.Add(backLeftSpeaker);
            panel5.Controls.Add(label7);
            panel5.Location = new Point(10, 753);
            panel5.Name = "panel5";
            panel5.Size = new Size(194, 219);
            panel5.TabIndex = 7;
            // 
            // backLeftSound
            // 
            backLeftSound.Cursor = Cursors.Hand;
            backLeftSound.Image = Properties.Resources.sound_off;
            backLeftSound.Location = new Point(76, 152);
            backLeftSound.Name = "backLeftSound";
            backLeftSound.Size = new Size(38, 39);
            backLeftSound.SizeMode = PictureBoxSizeMode.StretchImage;
            backLeftSound.TabIndex = 2;
            backLeftSound.TabStop = false;
            backLeftSound.Click += backLeftSpeaker_Click;
            // 
            // BLstate
            // 
            BLstate.AutoSize = true;
            BLstate.ForeColor = Color.White;
            BLstate.Location = new Point(66, 194);
            BLstate.Name = "BLstate";
            BLstate.Size = new Size(61, 20);
            BLstate.TabIndex = 4;
            BLstate.Text = "Κλειστό";
            // 
            // backLeftSpeaker
            // 
            backLeftSpeaker.Image = Properties.Resources.speaker_off;
            backLeftSpeaker.Location = new Point(34, 23);
            backLeftSpeaker.Name = "backLeftSpeaker";
            backLeftSpeaker.Size = new Size(120, 123);
            backLeftSpeaker.SizeMode = PictureBoxSizeMode.StretchImage;
            backLeftSpeaker.TabIndex = 1;
            backLeftSpeaker.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(21, 0);
            label7.Name = "label7";
            label7.Size = new Size(153, 40);
            label7.TabIndex = 3;
            label7.Text = "Πίσω αριστερό ηχείο\r\n\r\n";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.Controls.Add(frontRightSound);
            panel4.Controls.Add(FRstate);
            panel4.Controls.Add(frontRightSpeaker);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(747, 84);
            panel4.Name = "panel4";
            panel4.Size = new Size(194, 219);
            panel4.TabIndex = 6;
            // 
            // frontRightSound
            // 
            frontRightSound.Cursor = Cursors.Hand;
            frontRightSound.Image = Properties.Resources.sound_off;
            frontRightSound.Location = new Point(76, 152);
            frontRightSound.Name = "frontRightSound";
            frontRightSound.Size = new Size(38, 39);
            frontRightSound.SizeMode = PictureBoxSizeMode.StretchImage;
            frontRightSound.TabIndex = 2;
            frontRightSound.TabStop = false;
            frontRightSound.Click += frontRightSpeaker_Click;
            // 
            // FRstate
            // 
            FRstate.AutoSize = true;
            FRstate.ForeColor = Color.White;
            FRstate.Location = new Point(66, 194);
            FRstate.Name = "FRstate";
            FRstate.Size = new Size(61, 20);
            FRstate.TabIndex = 4;
            FRstate.Text = "Κλειστό";
            // 
            // frontRightSpeaker
            // 
            frontRightSpeaker.Image = Properties.Resources.speaker_off;
            frontRightSpeaker.Location = new Point(34, 23);
            frontRightSpeaker.Name = "frontRightSpeaker";
            frontRightSpeaker.Size = new Size(120, 123);
            frontRightSpeaker.SizeMode = PictureBoxSizeMode.StretchImage;
            frontRightSpeaker.TabIndex = 1;
            frontRightSpeaker.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(17, 0);
            label5.Name = "label5";
            label5.Size = new Size(158, 40);
            label5.TabIndex = 3;
            label5.Text = "Μπροστινό δεξί ηχείο\r\n\r\n";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Controls.Add(frontLeftSound);
            panel3.Controls.Add(FLstate);
            panel3.Controls.Add(frontLeftSpeaker);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(10, 84);
            panel3.Name = "panel3";
            panel3.Size = new Size(194, 219);
            panel3.TabIndex = 5;
            // 
            // frontLeftSound
            // 
            frontLeftSound.Cursor = Cursors.Hand;
            frontLeftSound.Image = Properties.Resources.sound_off;
            frontLeftSound.Location = new Point(76, 152);
            frontLeftSound.Name = "frontLeftSound";
            frontLeftSound.Size = new Size(38, 39);
            frontLeftSound.SizeMode = PictureBoxSizeMode.StretchImage;
            frontLeftSound.TabIndex = 2;
            frontLeftSound.TabStop = false;
            frontLeftSound.Click += frontLeftSpeaker_Click;
            // 
            // FLstate
            // 
            FLstate.AutoSize = true;
            FLstate.ForeColor = Color.White;
            FLstate.Location = new Point(66, 194);
            FLstate.Name = "FLstate";
            FLstate.Size = new Size(61, 20);
            FLstate.TabIndex = 4;
            FLstate.Text = "Κλειστό";
            // 
            // frontLeftSpeaker
            // 
            frontLeftSpeaker.Image = Properties.Resources.speaker_off;
            frontLeftSpeaker.Location = new Point(34, 23);
            frontLeftSpeaker.Name = "frontLeftSpeaker";
            frontLeftSpeaker.Size = new Size(120, 123);
            frontLeftSpeaker.SizeMode = PictureBoxSizeMode.StretchImage;
            frontLeftSpeaker.TabIndex = 1;
            frontLeftSpeaker.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(194, 40);
            label3.TabIndex = 3;
            label3.Text = "Μπροστινό αριστερό ηχείο\r\n\r\n";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(10, 8);
            label1.Name = "label1";
            label1.Size = new Size(590, 52);
            label1.TabIndex = 0;
            label1.Text = "ΣΥΣΚΕΥΕΣ ΙΔΙΩΤΙΚΗΣ ΑΙΘΟΥΣΑΣ";
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(971, 5);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(259, 979);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(22, 8);
            label2.Name = "label2";
            label2.Size = new Size(216, 52);
            label2.TabIndex = 1;
            label2.Text = "ΡΥΘΜΙΣΕΙΣ";
            // 
            // Device_Management
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.half_res_bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1234, 989);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Device_Management";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Device_Management";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)backRightSound).EndInit();
            ((System.ComponentModel.ISupportInitialize)backRightSpeaker).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)backLeftSound).EndInit();
            ((System.ComponentModel.ISupportInitialize)backLeftSpeaker).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)frontRightSound).EndInit();
            ((System.ComponentModel.ISupportInitialize)frontRightSpeaker).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)frontLeftSound).EndInit();
            ((System.ComponentModel.ISupportInitialize)frontLeftSpeaker).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private PictureBox frontLeftSpeaker;
        private Panel panel3;
        private PictureBox frontLeftSound;
        private Label FLstate;
        private Label label3;
        private Panel panel4;
        private PictureBox frontRightSound;
        private Label FRstate;
        private PictureBox frontRightSpeaker;
        private Label label5;
        private Panel panel6;
        private PictureBox backRightSound;
        private Label BRstate;
        private PictureBox backRightSpeaker;
        private Label label9;
        private Panel panel5;
        private PictureBox backLeftSound;
        private Label BLstate;
        private PictureBox backLeftSpeaker;
        private Label label7;
    }
}