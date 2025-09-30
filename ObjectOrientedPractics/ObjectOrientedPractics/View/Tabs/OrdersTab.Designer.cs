using ObjectOrientedPractics.Model.Orders;

namespace ObjectOrientedPractics.View.Tabs
{
    partial class OrdersTab
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
            components = new System.ComponentModel.Container();
            Model.Address address1 = new Model.Address();
            ordersLabel = new Label();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            created = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            fullName = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            amount = new DataGridViewTextBoxColumn();
            orderBindingSource = new BindingSource(components);
            orderLabel = new Label();
            idLabel = new Label();
            createdLabel = new Label();
            statusLabel = new Label();
            createdTextBox = new TextBox();
            idTextBox = new TextBox();
            statusComboBox = new ComboBox();
            addressControl1 = new Controls.AddressControl();
            itemsLabel = new Label();
            itemsListBox = new ListBox();
            label1 = new Label();
            amountLabel = new Label();
            priorityLabel = new Label();
            deliveryLabel = new Label();
            timeComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).BeginInit();
            SuspendLayout();
            // 
            // ordersLabel
            // 
            ordersLabel.AutoSize = true;
            ordersLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ordersLabel.Location = new Point(3, 10);
            ordersLabel.Name = "ordersLabel";
            ordersLabel.Size = new Size(45, 15);
            ordersLabel.TabIndex = 0;
            ordersLabel.Text = "Orders";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, created, status, fullName, Address, amount });
            dataGridView1.Location = new Point(3, 28);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(366, 433);
            dataGridView1.TabIndex = 1;
            dataGridView1.SelectionChanged += selectedRowChanged;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.Width = 80;
            // 
            // created
            // 
            created.HeaderText = "Created";
            created.Name = "created";
            created.Width = 80;
            // 
            // status
            // 
            status.HeaderText = "Order Status";
            status.Name = "status";
            status.Width = 80;
            // 
            // fullName
            // 
            fullName.HeaderText = "Full Name";
            fullName.Name = "fullName";
            fullName.Width = 80;
            // 
            // Address
            // 
            Address.HeaderText = "Address";
            Address.Name = "Address";
            Address.Width = 80;
            // 
            // amount
            // 
            amount.HeaderText = "Total Price";
            amount.Name = "amount";
            amount.Width = 80;
            // 
            // orderBindingSource
            // 
            orderBindingSource.DataSource = typeof(Order);
            // 
            // orderLabel
            // 
            orderLabel.AutoSize = true;
            orderLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            orderLabel.Location = new Point(375, 10);
            orderLabel.Name = "orderLabel";
            orderLabel.Size = new Size(92, 15);
            orderLabel.TabIndex = 2;
            orderLabel.Text = "Selected Order";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(375, 42);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(21, 15);
            idLabel.TabIndex = 3;
            idLabel.Text = "ID:";
            // 
            // createdLabel
            // 
            createdLabel.AutoSize = true;
            createdLabel.Location = new Point(375, 71);
            createdLabel.Name = "createdLabel";
            createdLabel.Size = new Size(51, 15);
            createdLabel.TabIndex = 4;
            createdLabel.Text = "Created:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new Point(375, 100);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(42, 15);
            statusLabel.TabIndex = 5;
            statusLabel.Text = "Status:";
            // 
            // createdTextBox
            // 
            createdTextBox.Location = new Point(429, 68);
            createdTextBox.Name = "createdTextBox";
            createdTextBox.ReadOnly = true;
            createdTextBox.Size = new Size(121, 23);
            createdTextBox.TabIndex = 6;
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(429, 34);
            idTextBox.Name = "idTextBox";
            idTextBox.ReadOnly = true;
            idTextBox.Size = new Size(121, 23);
            idTextBox.TabIndex = 7;
            // 
            // statusComboBox
            // 
            statusComboBox.FormattingEnabled = true;
            statusComboBox.Location = new Point(429, 97);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.Size = new Size(121, 23);
            statusComboBox.TabIndex = 8;
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
            addressControl1.Location = new Point(375, 126);
            addressControl1.Name = "addressControl1";
            addressControl1.Size = new Size(486, 193);
            addressControl1.TabIndex = 9;
            // 
            // itemsLabel
            // 
            itemsLabel.AutoSize = true;
            itemsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            itemsLabel.Location = new Point(375, 322);
            itemsLabel.Name = "itemsLabel";
            itemsLabel.Size = new Size(75, 15);
            itemsLabel.TabIndex = 10;
            itemsLabel.Text = "Order Items";
            // 
            // itemsListBox
            // 
            itemsListBox.FormattingEnabled = true;
            itemsListBox.ItemHeight = 15;
            itemsListBox.Location = new Point(375, 340);
            itemsListBox.Name = "itemsListBox";
            itemsListBox.Size = new Size(462, 94);
            itemsListBox.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(782, 446);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 12;
            label1.Text = "Amount:";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new Point(782, 472);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(38, 15);
            amountLabel.TabIndex = 13;
            amountLabel.Text = "label2";
            // 
            // priorityLabel
            // 
            priorityLabel.AutoSize = true;
            priorityLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            priorityLabel.Location = new Point(653, 10);
            priorityLabel.Name = "priorityLabel";
            priorityLabel.Size = new Size(94, 15);
            priorityLabel.TabIndex = 14;
            priorityLabel.Text = "Priority Options";
            // 
            // deliveryLabel
            // 
            deliveryLabel.AutoSize = true;
            deliveryLabel.Location = new Point(653, 37);
            deliveryLabel.Name = "deliveryLabel";
            deliveryLabel.Size = new Size(79, 15);
            deliveryLabel.TabIndex = 15;
            deliveryLabel.Text = "Delivery time:";
            // 
            // timeComboBox
            // 
            timeComboBox.FormattingEnabled = true;
            timeComboBox.Items.AddRange(new object[] { "9:00-11:00", "11:00-13:00", "13:00-15:00", "15:00-17:00", "17:00-19:00", "19:00-21:00" });
            timeComboBox.Location = new Point(740, 34);
            timeComboBox.Name = "timeComboBox";
            timeComboBox.Size = new Size(121, 23);
            timeComboBox.TabIndex = 16;
            timeComboBox.SelectedIndexChanged += timeComboBox_SelectedIndexChanged;
            // 
            // OrdersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(timeComboBox);
            Controls.Add(deliveryLabel);
            Controls.Add(priorityLabel);
            Controls.Add(amountLabel);
            Controls.Add(label1);
            Controls.Add(itemsListBox);
            Controls.Add(itemsLabel);
            Controls.Add(addressControl1);
            Controls.Add(statusComboBox);
            Controls.Add(idTextBox);
            Controls.Add(createdTextBox);
            Controls.Add(statusLabel);
            Controls.Add(createdLabel);
            Controls.Add(idLabel);
            Controls.Add(orderLabel);
            Controls.Add(dataGridView1);
            Controls.Add(ordersLabel);
            Name = "OrdersTab";
            Size = new Size(903, 576);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ordersLabel;
        private DataGridView dataGridView1;
        private BindingSource orderBindingSource;
        private Label orderLabel;
        private Label idLabel;
        private Label createdLabel;
        private Label statusLabel;
        private TextBox createdTextBox;
        private TextBox idTextBox;
        private ComboBox statusComboBox;
        private Controls.AddressControl addressControl1;
        private Label itemsLabel;
        private ListBox itemsListBox;
        private Label label1;
        private Label amountLabel;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn created;
        private DataGridViewTextBoxColumn status;
        private DataGridViewTextBoxColumn fullName;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn amount;
        private Label priorityLabel;
        private Label deliveryLabel;
        private ComboBox timeComboBox;
    }
}
