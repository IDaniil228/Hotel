namespace Hotel_5
{
    partial class PersonCardForm
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
            AnimalCheckBox = new CheckBox();
            PaymentLabel = new Label();
            BirthDayLable = new Label();
            FullNameLabel = new Label();
            CardOfPersonLable = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // AnimalCheckBox
            // 
            AnimalCheckBox.AutoSize = true;
            AnimalCheckBox.Location = new Point(95, 340);
            AnimalCheckBox.Name = "AnimalCheckBox";
            AnimalCheckBox.Size = new Size(212, 24);
            AnimalCheckBox.TabIndex = 19;
            AnimalCheckBox.Text = "Путешествую с животным";
            AnimalCheckBox.UseVisualStyleBackColor = true;
            AnimalCheckBox.Click += AnimalCheckBox_Click;
            // 
            // PaymentLabel
            // 
            PaymentLabel.FlatStyle = FlatStyle.Popup;
            PaymentLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PaymentLabel.Location = new Point(95, 285);
            PaymentLabel.Name = "PaymentLabel";
            PaymentLabel.Size = new Size(277, 27);
            PaymentLabel.TabIndex = 18;
            PaymentLabel.Text = "Payment";
            PaymentLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BirthDayLable
            // 
            BirthDayLable.FlatStyle = FlatStyle.Popup;
            BirthDayLable.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BirthDayLable.Location = new Point(95, 198);
            BirthDayLable.Name = "BirthDayLable";
            BirthDayLable.Size = new Size(277, 27);
            BirthDayLable.TabIndex = 17;
            BirthDayLable.Text = "Date";
            BirthDayLable.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FullNameLabel
            // 
            FullNameLabel.FlatStyle = FlatStyle.Popup;
            FullNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FullNameLabel.Location = new Point(95, 86);
            FullNameLabel.Name = "FullNameLabel";
            FullNameLabel.Size = new Size(277, 65);
            FullNameLabel.TabIndex = 16;
            FullNameLabel.Text = "ФИО";
            FullNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CardOfPersonLable
            // 
            CardOfPersonLable.AutoSize = true;
            CardOfPersonLable.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CardOfPersonLable.ForeColor = Color.Red;
            CardOfPersonLable.Location = new Point(126, 9);
            CardOfPersonLable.Name = "CardOfPersonLable";
            CardOfPersonLable.Size = new Size(223, 41);
            CardOfPersonLable.TabIndex = 15;
            CardOfPersonLable.Text = "Карточка гостя";
            CardOfPersonLable.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(303, 341);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 20;
            label1.Text = "(+250руб к цене)";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = SystemColors.ActiveCaption;
            label2.Location = new Point(198, 50);
            label2.Name = "label2";
            label2.Size = new Size(71, 28);
            label2.TabIndex = 21;
            label2.Text = "ФИО";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(198, 257);
            label3.Name = "label3";
            label3.Size = new Size(71, 28);
            label3.TabIndex = 22;
            label3.Text = "Оплата";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.ForeColor = SystemColors.ActiveCaption;
            label4.Location = new Point(153, 170);
            label4.Name = "label4";
            label4.Size = new Size(174, 28);
            label4.TabIndex = 23;
            label4.Text = "День рождения";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PersonCardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AnimalCheckBox);
            Controls.Add(PaymentLabel);
            Controls.Add(BirthDayLable);
            Controls.Add(FullNameLabel);
            Controls.Add(CardOfPersonLable);
            Name = "PersonCardForm";
            Text = "PersonCardForm";
            Load += PersonCardForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox AnimalCheckBox;
        private Label PaymentLabel;
        private Label BirthDayLable;
        private Label FullNameLabel;
        private Label CardOfPersonLable;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}