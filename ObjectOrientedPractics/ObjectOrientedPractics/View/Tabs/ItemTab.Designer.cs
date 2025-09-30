namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemTab
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
            itemsLabel = new Label();
            itemsListBox = new ListBox();
            AddButton = new Button();
            RemoveButton = new Button();
            selectedLabel = new Label();
            idLabel = new Label();
            costLabel = new Label();
            nameLabel = new Label();
            infoLabel = new Label();
            idTextBox = new TextBox();
            costTextBox = new TextBox();
            nameTextBox = new TextBox();
            infoTextBox = new TextBox();
            refactorButton = new Button();
            categoryLabel = new Label();
            categoryComboBox = new ComboBox();
            findLabel = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // itemsLabel
            // 
            itemsLabel.AutoSize = true;
            itemsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            itemsLabel.Location = new Point(0, 0);
            itemsLabel.Name = "itemsLabel";
            itemsLabel.Size = new Size(39, 15);
            itemsLabel.TabIndex = 0;
            itemsLabel.Text = "Items";
            // 
            // itemsListBox
            // 
            itemsListBox.FormattingEnabled = true;
            itemsListBox.ItemHeight = 15;
            itemsListBox.Location = new Point(0, 60);
            itemsListBox.Name = "itemsListBox";
            itemsListBox.Size = new Size(351, 484);
            itemsListBox.TabIndex = 1;
            itemsListBox.SelectedIndexChanged += itemsListBox_SelectedIndexChanged;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(3, 580);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(91, 42);
            AddButton.TabIndex = 2;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Location = new Point(100, 580);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(91, 42);
            RemoveButton.TabIndex = 3;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // selectedLabel
            // 
            selectedLabel.AutoSize = true;
            selectedLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            selectedLabel.Location = new Point(357, 0);
            selectedLabel.Name = "selectedLabel";
            selectedLabel.Size = new Size(86, 15);
            selectedLabel.TabIndex = 4;
            selectedLabel.Text = "Selected Item";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(357, 30);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(21, 15);
            idLabel.TabIndex = 5;
            idLabel.Text = "ID:";
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new Point(357, 62);
            costLabel.Name = "costLabel";
            costLabel.Size = new Size(34, 15);
            costLabel.TabIndex = 6;
            costLabel.Text = "Cost:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(357, 123);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(42, 15);
            nameLabel.TabIndex = 7;
            nameLabel.Text = "Name:";
            // 
            // infoLabel
            // 
            infoLabel.AutoSize = true;
            infoLabel.Location = new Point(357, 245);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(31, 15);
            infoLabel.TabIndex = 8;
            infoLabel.Text = "Info:";
            // 
            // idTextBox
            // 
            idTextBox.BorderStyle = BorderStyle.FixedSingle;
            idTextBox.Location = new Point(420, 28);
            idTextBox.Name = "idTextBox";
            idTextBox.ReadOnly = true;
            idTextBox.Size = new Size(122, 23);
            idTextBox.TabIndex = 9;
            // 
            // costTextBox
            // 
            costTextBox.BackColor = SystemColors.Control;
            costTextBox.BorderStyle = BorderStyle.FixedSingle;
            costTextBox.Location = new Point(420, 60);
            costTextBox.Name = "costTextBox";
            costTextBox.Size = new Size(122, 23);
            costTextBox.TabIndex = 10;
            costTextBox.TextChanged += costTextBox_TextChanged;
            // 
            // nameTextBox
            // 
            nameTextBox.BackColor = SystemColors.Control;
            nameTextBox.BorderStyle = BorderStyle.FixedSingle;
            nameTextBox.Location = new Point(357, 141);
            nameTextBox.Multiline = true;
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(518, 101);
            nameTextBox.TabIndex = 11;
            nameTextBox.TextChanged += nameTextBox_TextChanged;
            // 
            // infoTextBox
            // 
            infoTextBox.BackColor = SystemColors.Control;
            infoTextBox.BorderStyle = BorderStyle.FixedSingle;
            infoTextBox.Location = new Point(357, 263);
            infoTextBox.Multiline = true;
            infoTextBox.Name = "infoTextBox";
            infoTextBox.Size = new Size(518, 181);
            infoTextBox.TabIndex = 12;
            infoTextBox.TextChanged += infoTextBox_TextChanged;
            // 
            // refactorButton
            // 
            refactorButton.Location = new Point(197, 580);
            refactorButton.Name = "refactorButton";
            refactorButton.Size = new Size(91, 42);
            refactorButton.TabIndex = 13;
            refactorButton.Text = "Refactor";
            refactorButton.UseVisualStyleBackColor = true;
            refactorButton.Click += refactorButton_Click;
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new Point(357, 98);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(58, 15);
            categoryLabel.TabIndex = 14;
            categoryLabel.Text = "Category:";
            // 
            // categoryComboBox
            // 
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(420, 95);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(121, 23);
            categoryComboBox.TabIndex = 15;
            // 
            // findLabel
            // 
            findLabel.AutoSize = true;
            findLabel.Location = new Point(3, 23);
            findLabel.Name = "findLabel";
            findLabel.Size = new Size(33, 15);
            findLabel.TabIndex = 16;
            findLabel.Text = "Find:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(42, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(309, 23);
            textBox1.TabIndex = 17;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 547);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 18;
            label1.Text = "Order by:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Cost (Ascending)", "Cost (Descending)", "Name" });
            comboBox1.Location = new Point(56, 547);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 19;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // ItemTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(findLabel);
            Controls.Add(categoryComboBox);
            Controls.Add(categoryLabel);
            Controls.Add(refactorButton);
            Controls.Add(infoTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(costTextBox);
            Controls.Add(idTextBox);
            Controls.Add(infoLabel);
            Controls.Add(nameLabel);
            Controls.Add(costLabel);
            Controls.Add(idLabel);
            Controls.Add(selectedLabel);
            Controls.Add(RemoveButton);
            Controls.Add(AddButton);
            Controls.Add(itemsListBox);
            Controls.Add(itemsLabel);
            Name = "ItemTab";
            Size = new Size(897, 639);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label itemsLabel;
        private ListBox itemsListBox;
        private Button AddButton;
        private Button RemoveButton;
        private Label selectedLabel;
        private Label idLabel;
        private Label costLabel;
        private Label nameLabel;
        private Label infoLabel;
        private TextBox idTextBox;
        private TextBox costTextBox;
        private TextBox nameTextBox;
        private TextBox infoTextBox;
        private Button refactorButton;
        private Label categoryLabel;
        private ComboBox categoryComboBox;
        private Label findLabel;
        private TextBox textBox1;
        private Label label1;
        private ComboBox comboBox1;
    }
}
