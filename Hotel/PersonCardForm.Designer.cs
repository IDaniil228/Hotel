namespace Hotel
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
            CardOfPersonLable = new Label();
            FullNameLabel = new Label();
            BirthDayLable = new Label();
            PaymentLabel = new Label();
            AnimalCheckBox = new CheckBox();
            SuspendLayout();
            // 
            // CardOfPersonLable
            // 
            CardOfPersonLable.AutoSize = true;
            CardOfPersonLable.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CardOfPersonLable.ForeColor = Color.Red;
            CardOfPersonLable.Location = new Point(120, 9);
            CardOfPersonLable.Name = "CardOfPersonLable";
            CardOfPersonLable.Size = new Size(223, 41);
            CardOfPersonLable.TabIndex = 3;
            CardOfPersonLable.Text = "Карточка гостя";
            CardOfPersonLable.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FullNameLabel
            // 
            FullNameLabel.FlatStyle = FlatStyle.Popup;
            FullNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FullNameLabel.Location = new Point(87, 67);
            FullNameLabel.Name = "FullNameLabel";
            FullNameLabel.Size = new Size(277, 65);
            FullNameLabel.TabIndex = 10;
            FullNameLabel.Text = "ФИО";
            FullNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BirthDayLable
            // 
            BirthDayLable.FlatStyle = FlatStyle.Popup;
            BirthDayLable.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BirthDayLable.Location = new Point(87, 158);
            BirthDayLable.Name = "BirthDayLable";
            BirthDayLable.Size = new Size(277, 27);
            BirthDayLable.TabIndex = 12;
            BirthDayLable.Text = "Date";
            BirthDayLable.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PaymentLabel
            // 
            PaymentLabel.FlatStyle = FlatStyle.Popup;
            PaymentLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PaymentLabel.Location = new Point(87, 247);
            PaymentLabel.Name = "PaymentLabel";
            PaymentLabel.Size = new Size(277, 27);
            PaymentLabel.TabIndex = 13;
            PaymentLabel.Text = "Payment";
            PaymentLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AnimalCheckBox
            // 
            AnimalCheckBox.AutoSize = true;
            AnimalCheckBox.Location = new Point(87, 379);
            AnimalCheckBox.Name = "AnimalCheckBox";
            AnimalCheckBox.Size = new Size(212, 24);
            AnimalCheckBox.TabIndex = 14;
            AnimalCheckBox.Text = "Путешествую с животным";
            AnimalCheckBox.UseVisualStyleBackColor = true;
            // 
            // PersonCardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 450);
            Controls.Add(AnimalCheckBox);
            Controls.Add(PaymentLabel);
            Controls.Add(BirthDayLable);
            Controls.Add(FullNameLabel);
            Controls.Add(CardOfPersonLable);
            Name = "PersonCardForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CardOfPersonLable;
        private Label FullNameLabel;
        private Label BirthDayLable;
        private Label PaymentLabel;
        private CheckBox AnimalCheckBox;
    }
}