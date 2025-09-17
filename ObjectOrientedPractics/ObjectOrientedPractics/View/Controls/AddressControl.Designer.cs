namespace ObjectOrientedPractics.View.Controls
{
    partial class AddressControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            addressLabel = new Label();
            postLabel = new Label();
            countryLabel = new Label();
            streetLabel = new Label();
            buldingLabel = new Label();
            apartmentLabel = new Label();
            cityLabel = new Label();
            buildingTextBox = new TextBox();
            apartmentTextBox = new TextBox();
            cityTextBox = new TextBox();
            postTextBox = new TextBox();
            countryTextBox = new TextBox();
            streetTextBox = new TextBox();
            saveButton = new Button();
            SuspendLayout();
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            addressLabel.Location = new Point(3, 10);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(101, 15);
            addressLabel.TabIndex = 0;
            addressLabel.Text = "Delivery Address";
            // 
            // postLabel
            // 
            postLabel.AutoSize = true;
            postLabel.Location = new Point(3, 36);
            postLabel.Name = "postLabel";
            postLabel.Size = new Size(64, 15);
            postLabel.TabIndex = 1;
            postLabel.Text = "Post Index:";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new Point(3, 70);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(53, 15);
            countryLabel.TabIndex = 2;
            countryLabel.Text = "Country:";
            // 
            // streetLabel
            // 
            streetLabel.AutoSize = true;
            streetLabel.Location = new Point(3, 102);
            streetLabel.Name = "streetLabel";
            streetLabel.Size = new Size(40, 15);
            streetLabel.TabIndex = 3;
            streetLabel.Text = "Street:";
            // 
            // buldingLabel
            // 
            buldingLabel.AutoSize = true;
            buldingLabel.Location = new Point(3, 134);
            buldingLabel.Name = "buldingLabel";
            buldingLabel.Size = new Size(54, 15);
            buldingLabel.TabIndex = 4;
            buldingLabel.Text = "Building:";
            // 
            // apartmentLabel
            // 
            apartmentLabel.AutoSize = true;
            apartmentLabel.Location = new Point(226, 136);
            apartmentLabel.Name = "apartmentLabel";
            apartmentLabel.Size = new Size(67, 15);
            apartmentLabel.TabIndex = 5;
            apartmentLabel.Text = "Apartment:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new Point(322, 71);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(31, 15);
            cityLabel.TabIndex = 6;
            cityLabel.Text = "City:";
            // 
            // buildingTextBox
            // 
            buildingTextBox.BorderStyle = BorderStyle.FixedSingle;
            buildingTextBox.Location = new Point(73, 134);
            buildingTextBox.Name = "buildingTextBox";
            buildingTextBox.Size = new Size(100, 23);
            buildingTextBox.TabIndex = 7;
            buildingTextBox.TextChanged += buildingTextBox_TextChanged;
            // 
            // apartmentTextBox
            // 
            apartmentTextBox.BorderStyle = BorderStyle.FixedSingle;
            apartmentTextBox.Location = new Point(299, 134);
            apartmentTextBox.Name = "apartmentTextBox";
            apartmentTextBox.Size = new Size(100, 23);
            apartmentTextBox.TabIndex = 8;
            apartmentTextBox.TextChanged += apartmentTextBox_TextChanged;
            // 
            // cityTextBox
            // 
            cityTextBox.BorderStyle = BorderStyle.FixedSingle;
            cityTextBox.Location = new Point(359, 68);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new Size(100, 23);
            cityTextBox.TabIndex = 9;
            cityTextBox.TextChanged += cityTextBox_TextChanged;
            // 
            // postTextBox
            // 
            postTextBox.BorderStyle = BorderStyle.FixedSingle;
            postTextBox.Location = new Point(73, 33);
            postTextBox.Name = "postTextBox";
            postTextBox.Size = new Size(133, 23);
            postTextBox.TabIndex = 10;
            postTextBox.TextChanged += postTextBox_TextChanged;
            // 
            // countryTextBox
            // 
            countryTextBox.BorderStyle = BorderStyle.FixedSingle;
            countryTextBox.Location = new Point(73, 69);
            countryTextBox.Name = "countryTextBox";
            countryTextBox.Size = new Size(220, 23);
            countryTextBox.TabIndex = 11;
            countryTextBox.TextChanged += countryTextBox_TextChanged;
            // 
            // streetTextBox
            // 
            streetTextBox.BorderStyle = BorderStyle.FixedSingle;
            streetTextBox.Location = new Point(73, 102);
            streetTextBox.Name = "streetTextBox";
            streetTextBox.Size = new Size(386, 23);
            streetTextBox.TabIndex = 12;
            streetTextBox.TextChanged += streetTextBox_TextChanged;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(3, 163);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 13;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // AddressControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(saveButton);
            Controls.Add(streetTextBox);
            Controls.Add(countryTextBox);
            Controls.Add(postTextBox);
            Controls.Add(cityTextBox);
            Controls.Add(apartmentTextBox);
            Controls.Add(buildingTextBox);
            Controls.Add(cityLabel);
            Controls.Add(apartmentLabel);
            Controls.Add(buldingLabel);
            Controls.Add(streetLabel);
            Controls.Add(countryLabel);
            Controls.Add(postLabel);
            Controls.Add(addressLabel);
            Name = "AddressControl";
            Size = new Size(486, 193);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label addressLabel;
        private Label postLabel;
        private Label countryLabel;
        private Label streetLabel;
        private Label buldingLabel;
        private Label apartmentLabel;
        private Label cityLabel;
        private TextBox buildingTextBox;
        private TextBox apartmentTextBox;
        private TextBox cityTextBox;
        private TextBox postTextBox;
        private TextBox countryTextBox;
        private TextBox streetTextBox;
        private Button saveButton;
    }
}
