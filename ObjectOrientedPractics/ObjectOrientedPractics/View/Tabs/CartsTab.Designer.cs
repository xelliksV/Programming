namespace ObjectOrientedPractics.View.Tabs
{
    partial class CartsTab
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
            itemLabel = new Label();
            itemsListBox = new ListBox();
            CustomerLabel = new Label();
            customerComboBox = new ComboBox();
            cartLabel = new Label();
            cartListBox = new ListBox();
            addButton = new Button();
            createButton = new Button();
            clearButton = new Button();
            removeButton = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // itemLabel
            // 
            itemLabel.AutoSize = true;
            itemLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            itemLabel.Location = new Point(19, 11);
            itemLabel.Name = "itemLabel";
            itemLabel.Size = new Size(39, 15);
            itemLabel.TabIndex = 0;
            itemLabel.Text = "Items";
            // 
            // itemsListBox
            // 
            itemsListBox.FormattingEnabled = true;
            itemsListBox.ItemHeight = 15;
            itemsListBox.Location = new Point(19, 29);
            itemsListBox.Name = "itemsListBox";
            itemsListBox.Size = new Size(271, 469);
            itemsListBox.TabIndex = 1;
            // 
            // CustomerLabel
            // 
            CustomerLabel.AutoSize = true;
            CustomerLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CustomerLabel.Location = new Point(296, 11);
            CustomerLabel.Name = "CustomerLabel";
            CustomerLabel.Size = new Size(64, 15);
            CustomerLabel.TabIndex = 2;
            CustomerLabel.Text = "Customer:";
            // 
            // customerComboBox
            // 
            customerComboBox.FormattingEnabled = true;
            customerComboBox.Location = new Point(366, 11);
            customerComboBox.Name = "customerComboBox";
            customerComboBox.Size = new Size(417, 23);
            customerComboBox.TabIndex = 3;
            customerComboBox.SelectedIndexChanged += customerComboBox_SelectedIndexChanged;
            // 
            // cartLabel
            // 
            cartLabel.AutoSize = true;
            cartLabel.Location = new Point(296, 53);
            cartLabel.Name = "cartLabel";
            cartLabel.Size = new Size(32, 15);
            cartLabel.TabIndex = 4;
            cartLabel.Text = "Cart:";
            // 
            // cartListBox
            // 
            cartListBox.FormattingEnabled = true;
            cartListBox.ItemHeight = 15;
            cartListBox.Location = new Point(296, 71);
            cartListBox.Name = "cartListBox";
            cartListBox.Size = new Size(487, 184);
            cartListBox.TabIndex = 5;
            // 
            // addButton
            // 
            addButton.Location = new Point(19, 504);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 39);
            addButton.TabIndex = 6;
            addButton.Text = "Add to cart";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // createButton
            // 
            createButton.Location = new Point(296, 321);
            createButton.Name = "createButton";
            createButton.Size = new Size(85, 39);
            createButton.TabIndex = 7;
            createButton.Text = "Create Order";
            createButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(698, 321);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(85, 39);
            clearButton.TabIndex = 8;
            clearButton.Text = "Clear cart";
            clearButton.UseVisualStyleBackColor = true;
            // 
            // removeButton
            // 
            removeButton.Location = new Point(607, 321);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(85, 39);
            removeButton.TabIndex = 9;
            removeButton.Text = "Remove item";
            removeButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(729, 258);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 10;
            label1.Text = "Amount:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(745, 273);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 11;
            label2.Text = "label2";
            // 
            // CartsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(removeButton);
            Controls.Add(clearButton);
            Controls.Add(createButton);
            Controls.Add(addButton);
            Controls.Add(cartListBox);
            Controls.Add(cartLabel);
            Controls.Add(customerComboBox);
            Controls.Add(CustomerLabel);
            Controls.Add(itemsListBox);
            Controls.Add(itemLabel);
            Name = "CartsTab";
            Size = new Size(810, 555);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label itemLabel;
        private ListBox itemsListBox;
        private Label CustomerLabel;
        private ComboBox customerComboBox;
        private Label cartLabel;
        private ListBox cartListBox;
        private Button addButton;
        private Button createButton;
        private Button clearButton;
        private Button removeButton;
        private Label label1;
        private Label label2;
    }
}
