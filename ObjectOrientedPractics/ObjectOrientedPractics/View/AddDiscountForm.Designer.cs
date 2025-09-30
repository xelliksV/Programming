namespace ObjectOrientedPractics.View
{
    partial class AddDiscountForm
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
            percentLabel = new Label();
            categoryLabel = new Label();
            categoryComboBox = new ComboBox();
            okButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // percentLabel
            // 
            percentLabel.AutoSize = true;
            percentLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            percentLabel.Location = new Point(12, 9);
            percentLabel.Name = "percentLabel";
            percentLabel.Size = new Size(106, 15);
            percentLabel.TabIndex = 0;
            percentLabel.Text = "Percent Discount:";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new Point(12, 36);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(58, 15);
            categoryLabel.TabIndex = 1;
            categoryLabel.Text = "Category:";
            // 
            // categoryComboBox
            // 
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(76, 33);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(167, 23);
            categoryComboBox.TabIndex = 2;
            // 
            // okButton
            // 
            okButton.Location = new Point(76, 62);
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 47);
            okButton.TabIndex = 3;
            okButton.Text = "Ok";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += OkButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(168, 62);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 47);
            cancelButton.TabIndex = 4;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += CancelButton_Click;
            // 
            // AddDiscountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(255, 121);
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            Controls.Add(categoryComboBox);
            Controls.Add(categoryLabel);
            Controls.Add(percentLabel);
            Name = "AddDiscountForm";
            Text = "Add Discount";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label percentLabel;
        private Label categoryLabel;
        private ComboBox categoryComboBox;
        private Button okButton;
        private Button cancelButton;
    }
}