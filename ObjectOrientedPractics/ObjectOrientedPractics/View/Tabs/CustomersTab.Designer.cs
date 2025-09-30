namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
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
            Model.Address address1 = new Model.Address();
            customersLabel = new Label();
            customersListBox = new ListBox();
            addButton = new Button();
            removeButton = new Button();
            refactorButton = new Button();
            selectedLabel = new Label();
            idLabel = new Label();
            nameLabel = new Label();
            idTextBox = new TextBox();
            nameTextBox = new TextBox();
            addressControl = new Controls.AddressControl();
            priorityCheckBox = new CheckBox();
            label1 = new Label();
            discountsListBox = new ListBox();
            addDiscButton = new Button();
            removeDiscButton = new Button();
            SuspendLayout();
            // 
            // customersLabel
            // 
            customersLabel.AutoSize = true;
            customersLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            customersLabel.Location = new Point(3, 0);
            customersLabel.Name = "customersLabel";
            customersLabel.Size = new Size(66, 15);
            customersLabel.TabIndex = 0;
            customersLabel.Text = "Customers";
            // 
            // customersListBox
            // 
            customersListBox.FormattingEnabled = true;
            customersListBox.ItemHeight = 15;
            customersListBox.Location = new Point(3, 18);
            customersListBox.Name = "customersListBox";
            customersListBox.Size = new Size(303, 499);
            customersListBox.TabIndex = 1;
            customersListBox.SelectedIndexChanged += customersListBox_SelectedIndexChanged;
            // 
            // addButton
            // 
            addButton.Location = new Point(3, 523);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 37);
            addButton.TabIndex = 2;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // removeButton
            // 
            removeButton.Location = new Point(84, 523);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(75, 37);
            removeButton.TabIndex = 3;
            removeButton.Text = "Remove";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // refactorButton
            // 
            refactorButton.Location = new Point(165, 523);
            refactorButton.Name = "refactorButton";
            refactorButton.Size = new Size(75, 37);
            refactorButton.TabIndex = 4;
            refactorButton.Text = "Refactor";
            refactorButton.UseVisualStyleBackColor = true;
            refactorButton.Click += refactorButton_Click;
            // 
            // selectedLabel
            // 
            selectedLabel.AutoSize = true;
            selectedLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            selectedLabel.Location = new Point(312, 0);
            selectedLabel.Name = "selectedLabel";
            selectedLabel.Size = new Size(113, 15);
            selectedLabel.TabIndex = 5;
            selectedLabel.Text = "Selected Customer";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(312, 28);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(21, 15);
            idLabel.TabIndex = 6;
            idLabel.Text = "ID:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(312, 55);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(62, 15);
            nameLabel.TabIndex = 7;
            nameLabel.Text = "Full name:";
            // 
            // idTextBox
            // 
            idTextBox.BorderStyle = BorderStyle.FixedSingle;
            idTextBox.Location = new Point(377, 25);
            idTextBox.Name = "idTextBox";
            idTextBox.ReadOnly = true;
            idTextBox.Size = new Size(100, 23);
            idTextBox.TabIndex = 9;
            // 
            // nameTextBox
            // 
            nameTextBox.BorderStyle = BorderStyle.FixedSingle;
            nameTextBox.Location = new Point(377, 52);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(351, 23);
            nameTextBox.TabIndex = 10;
            nameTextBox.TextChanged += nameTextBox_TextChanged;
            // 
            // addressControl
            // 
            address1.Apartment = " ";
            address1.Building = " ";
            address1.City = " ";
            address1.Country = " ";
            address1.Index = 0;
            address1.Street = " ";
            addressControl.Address = address1;
            addressControl.Location = new Point(312, 102);
            addressControl.Name = "addressControl";
            addressControl.Size = new Size(463, 193);
            addressControl.TabIndex = 11;
            // 
            // priorityCheckBox
            // 
            priorityCheckBox.AutoSize = true;
            priorityCheckBox.Location = new Point(377, 81);
            priorityCheckBox.Name = "priorityCheckBox";
            priorityCheckBox.Size = new Size(75, 19);
            priorityCheckBox.TabIndex = 12;
            priorityCheckBox.Text = "Is Priority";
            priorityCheckBox.UseVisualStyleBackColor = true;
            priorityCheckBox.CheckedChanged += priorityCheckBox_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(312, 298);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 13;
            label1.Text = "Discounts";
            // 
            // discountsListBox
            // 
            discountsListBox.FormattingEnabled = true;
            discountsListBox.ItemHeight = 15;
            discountsListBox.Location = new Point(312, 316);
            discountsListBox.Name = "discountsListBox";
            discountsListBox.Size = new Size(266, 94);
            discountsListBox.TabIndex = 14;
            // 
            // addDiscButton
            // 
            addDiscButton.Location = new Point(584, 316);
            addDiscButton.Name = "addDiscButton";
            addDiscButton.Size = new Size(75, 46);
            addDiscButton.TabIndex = 15;
            addDiscButton.Text = "Add";
            addDiscButton.UseVisualStyleBackColor = true;
            addDiscButton.Click += addDiscButton_Click;
            // 
            // removeDiscButton
            // 
            removeDiscButton.Location = new Point(584, 364);
            removeDiscButton.Name = "removeDiscButton";
            removeDiscButton.Size = new Size(75, 46);
            removeDiscButton.TabIndex = 16;
            removeDiscButton.Text = "Remove";
            removeDiscButton.UseVisualStyleBackColor = true;
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(removeDiscButton);
            Controls.Add(addDiscButton);
            Controls.Add(discountsListBox);
            Controls.Add(label1);
            Controls.Add(priorityCheckBox);
            Controls.Add(addressControl);
            Controls.Add(nameTextBox);
            Controls.Add(idTextBox);
            Controls.Add(nameLabel);
            Controls.Add(idLabel);
            Controls.Add(selectedLabel);
            Controls.Add(refactorButton);
            Controls.Add(removeButton);
            Controls.Add(addButton);
            Controls.Add(customersListBox);
            Controls.Add(customersLabel);
            Name = "CustomersTab";
            Size = new Size(775, 563);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label customersLabel;
        private ListBox customersListBox;
        private Button addButton;
        private Button removeButton;
        private Button refactorButton;
        private Label selectedLabel;
        private Label idLabel;
        private Label nameLabel;
        private TextBox idTextBox;
        private TextBox nameTextBox;
        private Controls.AddressControl addressControl;
        private CheckBox priorityCheckBox;
        private Label label1;
        private ListBox discountsListBox;
        private Button addDiscButton;
        private Button removeDiscButton;
    }
}
