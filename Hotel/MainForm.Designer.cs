namespace Hotel
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            textBox1 = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            TimeLabel = new Label();
            panel2 = new Panel();
            FreeRadioButton4 = new RadioButton();
            OccupiedRadioButton = new RadioButton();
            DischargedRadioButton2 = new RadioButton();
            ReservedRadioButton = new RadioButton();
            StatusLabel = new Label();
            panel3 = new Panel();
            ListOfPeopleListView = new ListView();
            ListLabel = new Label();
            panel4 = new Panel();
            button1 = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            FullNameLabel = new Label();
            comboBox1 = new ComboBox();
            StatusLabel2 = new Label();
            PhotoPictureBox = new PictureBox();
            NumberLabel = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PhotoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(TimeLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(846, 62);
            panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(224, 14);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(557, 27);
            textBox1.TabIndex = 9;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Lupa;
            pictureBox2.Location = new Point(787, 14);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Timer;
            pictureBox1.Location = new Point(131, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // TimeLabel
            // 
            TimeLabel.BorderStyle = BorderStyle.FixedSingle;
            TimeLabel.FlatStyle = FlatStyle.Popup;
            TimeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TimeLabel.Location = new Point(28, 14);
            TimeLabel.Name = "TimeLabel";
            TimeLabel.Size = new Size(97, 30);
            TimeLabel.TabIndex = 4;
            TimeLabel.Text = "Time";
            TimeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(FreeRadioButton4);
            panel2.Controls.Add(OccupiedRadioButton);
            panel2.Controls.Add(DischargedRadioButton2);
            panel2.Controls.Add(ReservedRadioButton);
            panel2.Controls.Add(StatusLabel);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 62);
            panel2.Name = "panel2";
            panel2.Size = new Size(215, 494);
            panel2.TabIndex = 1;
            // 
            // FreeRadioButton4
            // 
            FreeRadioButton4.AutoSize = true;
            FreeRadioButton4.Location = new Point(12, 104);
            FreeRadioButton4.Name = "FreeRadioButton4";
            FreeRadioButton4.Size = new Size(102, 24);
            FreeRadioButton4.TabIndex = 5;
            FreeRadioButton4.TabStop = true;
            FreeRadioButton4.Text = "Свободны";
            FreeRadioButton4.UseVisualStyleBackColor = true;
            FreeRadioButton4.CheckedChanged += FreeRadioButton4_CheckedChanged;
            // 
            // OccupiedRadioButton
            // 
            OccupiedRadioButton.AutoSize = true;
            OccupiedRadioButton.Location = new Point(12, 134);
            OccupiedRadioButton.Name = "OccupiedRadioButton";
            OccupiedRadioButton.Size = new Size(80, 24);
            OccupiedRadioButton.TabIndex = 4;
            OccupiedRadioButton.TabStop = true;
            OccupiedRadioButton.Text = "Заняты";
            OccupiedRadioButton.UseVisualStyleBackColor = true;
            // 
            // DischargedRadioButton2
            // 
            DischargedRadioButton2.AutoSize = true;
            DischargedRadioButton2.Location = new Point(12, 164);
            DischargedRadioButton2.Name = "DischargedRadioButton2";
            DischargedRadioButton2.Size = new Size(135, 24);
            DischargedRadioButton2.TabIndex = 3;
            DischargedRadioButton2.TabStop = true;
            DischargedRadioButton2.Text = "Выписываются";
            DischargedRadioButton2.UseVisualStyleBackColor = true;
            // 
            // ReservedRadioButton
            // 
            ReservedRadioButton.AutoSize = true;
            ReservedRadioButton.Location = new Point(12, 74);
            ReservedRadioButton.Name = "ReservedRadioButton";
            ReservedRadioButton.Size = new Size(156, 24);
            ReservedRadioButton.TabIndex = 2;
            ReservedRadioButton.TabStop = true;
            ReservedRadioButton.Text = "Зарезервировано";
            ReservedRadioButton.UseVisualStyleBackColor = true;
            ReservedRadioButton.CheckedChanged += ReservedRadioButton_CheckedChanged;
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            StatusLabel.ForeColor = Color.Red;
            StatusLabel.Location = new Point(3, 3);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(105, 41);
            StatusLabel.TabIndex = 1;
            StatusLabel.Text = "Статус";
            StatusLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(ListOfPeopleListView);
            panel3.Controls.Add(ListLabel);
            panel3.Location = new Point(221, 62);
            panel3.Name = "panel3";
            panel3.Size = new Size(336, 494);
            panel3.TabIndex = 1;
            // 
            // ListOfPeopleListView
            // 
            ListOfPeopleListView.BackColor = Color.White;
            ListOfPeopleListView.BorderStyle = BorderStyle.None;
            ListOfPeopleListView.Location = new Point(3, 49);
            ListOfPeopleListView.Name = "ListOfPeopleListView";
            ListOfPeopleListView.Size = new Size(330, 445);
            ListOfPeopleListView.TabIndex = 3;
            ListOfPeopleListView.UseCompatibleStateImageBehavior = false;
            ListOfPeopleListView.View = View.List;
            // 
            // ListLabel
            // 
            ListLabel.AutoSize = true;
            ListLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ListLabel.ForeColor = Color.Red;
            ListLabel.Location = new Point(3, 3);
            ListLabel.Name = "ListLabel";
            ListLabel.Size = new Size(214, 41);
            ListLabel.TabIndex = 2;
            ListLabel.Text = "Список гостей";
            ListLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(button1);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(FullNameLabel);
            panel4.Controls.Add(comboBox1);
            panel4.Controls.Add(StatusLabel2);
            panel4.Controls.Add(PhotoPictureBox);
            panel4.Controls.Add(NumberLabel);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(563, 62);
            panel4.Name = "panel4";
            panel4.Size = new Size(283, 494);
            panel4.TabIndex = 1;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(98, 453);
            button1.Name = "button1";
            button1.Size = new Size(173, 29);
            button1.TabIndex = 6;
            button1.Text = "Просмотр карточки";
            button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.ForeColor = SystemColors.ActiveCaption;
            label6.Location = new Point(3, 395);
            label6.Name = "label6";
            label6.Size = new Size(136, 28);
            label6.TabIndex = 14;
            label6.Text = "Дата отъезда";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.ForeColor = SystemColors.ActiveCaption;
            label5.Location = new Point(3, 355);
            label5.Name = "label5";
            label5.Size = new Size(136, 28);
            label5.TabIndex = 13;
            label5.Text = "Дата приезда";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(133, 396);
            label4.Name = "label4";
            label4.Size = new Size(138, 27);
            label4.TabIndex = 12;
            label4.Text = "Date";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(133, 356);
            label3.Name = "label3";
            label3.Size = new Size(138, 27);
            label3.TabIndex = 11;
            label3.Text = "Date";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(104, 263);
            label2.Name = "label2";
            label2.Size = new Size(71, 28);
            label2.TabIndex = 10;
            label2.Text = "ФИО";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FullNameLabel
            // 
            FullNameLabel.FlatStyle = FlatStyle.Popup;
            FullNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FullNameLabel.Location = new Point(3, 291);
            FullNameLabel.Name = "FullNameLabel";
            FullNameLabel.Size = new Size(277, 65);
            FullNameLabel.TabIndex = 9;
            FullNameLabel.Text = "Time";
            FullNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.Simple;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(80, 224);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(191, 28);
            comboBox1.TabIndex = 7;
            // 
            // StatusLabel2
            // 
            StatusLabel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            StatusLabel2.ForeColor = SystemColors.ActiveCaption;
            StatusLabel2.Location = new Point(3, 220);
            StatusLabel2.Name = "StatusLabel2";
            StatusLabel2.Size = new Size(71, 28);
            StatusLabel2.TabIndex = 6;
            StatusLabel2.Text = "Статус";
            StatusLabel2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PhotoPictureBox
            // 
            PhotoPictureBox.Location = new Point(68, 49);
            PhotoPictureBox.Name = "PhotoPictureBox";
            PhotoPictureBox.Size = new Size(150, 150);
            PhotoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            PhotoPictureBox.TabIndex = 4;
            PhotoPictureBox.TabStop = false;
            // 
            // NumberLabel
            // 
            NumberLabel.AutoSize = true;
            NumberLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NumberLabel.ForeColor = Color.Red;
            NumberLabel.Location = new Point(3, 3);
            NumberLabel.Name = "NumberLabel";
            NumberLabel.Size = new Size(154, 41);
            NumberLabel.TabIndex = 3;
            NumberLabel.Text = "Номер №";
            NumberLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(846, 556);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            Text = "Отель";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PhotoPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label StatusLabel;
        private Label ListLabel;
        private Label NumberLabel;
        private Label TimeLabel;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox1;
        private PictureBox PhotoPictureBox;
        private RadioButton FreeRadioButton4;
        private RadioButton OccupiedRadioButton;
        private RadioButton DischargedRadioButton2;
        private RadioButton ReservedRadioButton;
        private ComboBox comboBox1;
        private Label StatusLabel2;
        private PictureBox pictureBox2;
        private ListView ListOfPeopleListView;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label FullNameLabel;
        private Label label6;
        private Label label5;
        private Button button1;
        private TextBox textBox1;
    }
}
