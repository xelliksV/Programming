namespace ObjectOrientedPractics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tabControl1 = new TabControl();
            itemsTab = new TabPage();
            itemTab1 = new View.Tabs.ItemTab();
            Customers = new TabPage();
            customersTab1 = new View.Tabs.CustomersTab();
            cartsPage = new TabPage();
            cartsTab1 = new View.Tabs.CartsTab();
            tabControl1.SuspendLayout();
            itemsTab.SuspendLayout();
            Customers.SuspendLayout();
            cartsPage.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(itemsTab);
            tabControl1.Controls.Add(Customers);
            tabControl1.Controls.Add(cartsPage);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 595);
            tabControl1.TabIndex = 0;
            // 
            // itemsTab
            // 
            itemsTab.Controls.Add(itemTab1);
            itemsTab.Location = new Point(4, 24);
            itemsTab.Name = "itemsTab";
            itemsTab.Padding = new Padding(3);
            itemsTab.Size = new Size(792, 567);
            itemsTab.TabIndex = 1;
            itemsTab.Text = "Items";
            itemsTab.UseVisualStyleBackColor = true;
            // 
            // itemTab1
            // 
            itemTab1.Dock = DockStyle.Fill;
            itemTab1.Location = new Point(3, 3);
            itemTab1.Name = "itemTab1";
            itemTab1.Size = new Size(786, 561);
            itemTab1.TabIndex = 0;
            itemTab1.Load += itemTab1_Load;
            // 
            // Customers
            // 
            Customers.Controls.Add(customersTab1);
            Customers.Location = new Point(4, 24);
            Customers.Name = "Customers";
            Customers.Padding = new Padding(3);
            Customers.Size = new Size(792, 567);
            Customers.TabIndex = 2;
            Customers.Text = "Customers";
            Customers.UseVisualStyleBackColor = true;
            // 
            // customersTab1
            // 
            customersTab1.Location = new Point(0, 0);
            customersTab1.Name = "customersTab1";
            customersTab1.Size = new Size(775, 563);
            customersTab1.TabIndex = 0;
            // 
            // cartsPage
            // 
            cartsPage.Controls.Add(cartsTab1);
            cartsPage.Location = new Point(4, 24);
            cartsPage.Name = "cartsPage";
            cartsPage.Padding = new Padding(3);
            cartsPage.Size = new Size(792, 567);
            cartsPage.TabIndex = 3;
            cartsPage.Text = "Carts";
            cartsPage.UseVisualStyleBackColor = true;
            // 
            // cartsTab1
            // 
            cartsTab1.Location = new Point(0, 0);
            cartsTab1.Name = "cartsTab1";
            cartsTab1.Size = new Size(789, 555);
            cartsTab1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 595);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "Object Oriented Practics";
            tabControl1.ResumeLayout(false);
            itemsTab.ResumeLayout(false);
            Customers.ResumeLayout(false);
            cartsPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage itemsTab;
        private View.Tabs.ItemTab itemTab1;
        private TabPage Customers;
        private View.Tabs.CustomersTab customersTab1;
        private TabPage cartsPage;
        private View.Tabs.CartsTab cartsTab1;
    }
}
