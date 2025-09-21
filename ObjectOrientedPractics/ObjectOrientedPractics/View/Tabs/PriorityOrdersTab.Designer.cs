namespace ObjectOrientedPractics.View.Tabs
{
    partial class PriorityOrdersTab
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
            selectedLabel = new Label();
            idLabel = new Label();
            createdLabel = new Label();
            statusLabel = new Label();
            idTextBox = new TextBox();
            createdTextBox = new TextBox();
            statusComboBox = new ComboBox();
            addressControl1 = new Controls.AddressControl();
            orderLabel = new Label();
            itemsListBox = new ListBox();
            addButton = new Button();
            removeButton = new Button();
            clearButton = new Button();
            label1 = new Label();
            amountLabel = new Label();
            priorityLabel = new Label();
            timeLabel = new Label();
            timeComboBox = new ComboBox();
            SuspendLayout();
            // 
            // selectedLabel
            // 
            selectedLabel.AutoSize = true;
            selectedLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            selectedLabel.Location = new Point(3, 10);
            selectedLabel.Name = "selectedLabel";
            selectedLabel.Size = new Size(92, 15);
            selectedLabel.TabIndex = 0;
            selectedLabel.Text = "Selected Order";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(3, 35);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(21, 15);
            idLabel.TabIndex = 1;
            idLabel.Text = "ID:";
            // 
            // createdLabel
            // 
            createdLabel.AutoSize = true;
            createdLabel.Location = new Point(3, 61);
            createdLabel.Name = "createdLabel";
            createdLabel.Size = new Size(51, 15);
            createdLabel.TabIndex = 2;
            createdLabel.Text = "Created:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new Point(3, 91);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(42, 15);
            statusLabel.TabIndex = 3;
            statusLabel.Text = "Status:";
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(58, 32);
            idTextBox.Name = "idTextBox";
            idTextBox.ReadOnly = true;
            idTextBox.Size = new Size(121, 23);
            idTextBox.TabIndex = 4;
            // 
            // createdTextBox
            // 
            createdTextBox.Location = new Point(58, 58);
            createdTextBox.Name = "createdTextBox";
            createdTextBox.ReadOnly = true;
            createdTextBox.Size = new Size(121, 23);
            createdTextBox.TabIndex = 5;
            // 
            // statusComboBox
            // 
            statusComboBox.FormattingEnabled = true;
            statusComboBox.Location = new Point(58, 87);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.Size = new Size(121, 23);
            statusComboBox.TabIndex = 6;
            statusComboBox.SelectedIndexChanged += statusComboBox_SelectedIndexChanged;
            // 
            // addressControl1
            // 
            address1.Apartment = " ";
            address1.Building = " ";
            address1.City = " ";
            address1.Country = " ";
            address1.Index = 0;
            address1.Street = " ";
            addressControl1.Address = address1;
            addressControl1.Location = new Point(0, 116);
            addressControl1.Name = "addressControl1";
            addressControl1.Size = new Size(486, 193);
            addressControl1.TabIndex = 8;
            // 
            // orderLabel
            // 
            orderLabel.AutoSize = true;
            orderLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            orderLabel.Location = new Point(3, 312);
            orderLabel.Name = "orderLabel";
            orderLabel.Size = new Size(75, 15);
            orderLabel.TabIndex = 9;
            orderLabel.Text = "Order Items";
            // 
            // itemsListBox
            // 
            itemsListBox.FormattingEnabled = true;
            itemsListBox.ItemHeight = 15;
            itemsListBox.Location = new Point(0, 330);
            itemsListBox.Name = "itemsListBox";
            itemsListBox.Size = new Size(486, 139);
            itemsListBox.TabIndex = 10;
            // 
            // addButton
            // 
            addButton.Location = new Point(0, 523);
            addButton.Name = "addButton";
            addButton.Size = new Size(95, 41);
            addButton.TabIndex = 11;
            addButton.Text = "Add Item";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // removeButton
            // 
            removeButton.Location = new Point(96, 523);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(98, 41);
            removeButton.TabIndex = 12;
            removeButton.Text = "Remove Item";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(394, 523);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(92, 41);
            clearButton.TabIndex = 13;
            clearButton.Text = "Clear Order";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(431, 472);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 14;
            label1.Text = "Amount:";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new Point(431, 487);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(38, 15);
            amountLabel.TabIndex = 15;
            amountLabel.Text = "label2";
            // 
            // priorityLabel
            // 
            priorityLabel.AutoSize = true;
            priorityLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            priorityLabel.Location = new Point(252, 10);
            priorityLabel.Name = "priorityLabel";
            priorityLabel.Size = new Size(94, 15);
            priorityLabel.TabIndex = 16;
            priorityLabel.Text = "Priority Options";
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Location = new Point(252, 32);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(82, 15);
            timeLabel.TabIndex = 17;
            timeLabel.Text = "Delivery Time:";
            // 
            // timeComboBox
            // 
            timeComboBox.FormattingEnabled = true;
            timeComboBox.Items.AddRange(new object[] { "9:00-11:00", "11:00-13:00", "13:00-15:00", "15:00-17:00", "17:00-19:00", "19:00-21:00" });
            timeComboBox.Location = new Point(340, 27);
            timeComboBox.Name = "timeComboBox";
            timeComboBox.Size = new Size(121, 23);
            timeComboBox.TabIndex = 18;
            timeComboBox.SelectedIndexChanged += timeComboBox_SelectedIndexChanged;
            // 
            // PriorityOrdersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(timeComboBox);
            Controls.Add(timeLabel);
            Controls.Add(priorityLabel);
            Controls.Add(amountLabel);
            Controls.Add(label1);
            Controls.Add(clearButton);
            Controls.Add(removeButton);
            Controls.Add(addButton);
            Controls.Add(itemsListBox);
            Controls.Add(orderLabel);
            Controls.Add(addressControl1);
            Controls.Add(statusComboBox);
            Controls.Add(createdTextBox);
            Controls.Add(idTextBox);
            Controls.Add(statusLabel);
            Controls.Add(createdLabel);
            Controls.Add(idLabel);
            Controls.Add(selectedLabel);
            Name = "PriorityOrdersTab";
            Size = new Size(492, 567);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label selectedLabel;
        private Label idLabel;
        private Label createdLabel;
        private Label statusLabel;
        private TextBox idTextBox;
        private TextBox createdTextBox;
        private ComboBox statusComboBox;
        private Controls.AddressControl addressControl1;
        private Label orderLabel;
        private ListBox itemsListBox;
        private Button addButton;
        private Button removeButton;
        private Button clearButton;
        private Label label1;
        private Label amountLabel;
        private Label priorityLabel;
        private Label timeLabel;
        private ComboBox timeComboBox;
    }
}
