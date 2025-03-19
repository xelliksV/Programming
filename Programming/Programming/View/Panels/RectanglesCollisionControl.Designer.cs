namespace Programming.View
{
    partial class RectanglesCollisionControl
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
            tabControl1 = new TabControl();
            Rectangles = new TabPage();
            panel1 = new Panel();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            textBox9 = new TextBox();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            label13 = new Label();
            button4 = new Button();
            button3 = new Button();
            listBox3 = new ListBox();
            tabControl1.SuspendLayout();
            Rectangles.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Rectangles);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(750, 478);
            tabControl1.TabIndex = 1;
            // 
            // Rectangles
            // 
            Rectangles.BorderStyle = BorderStyle.FixedSingle;
            Rectangles.Controls.Add(panel1);
            Rectangles.Controls.Add(label18);
            Rectangles.Controls.Add(label17);
            Rectangles.Controls.Add(label16);
            Rectangles.Controls.Add(label15);
            Rectangles.Controls.Add(label14);
            Rectangles.Controls.Add(textBox9);
            Rectangles.Controls.Add(textBox8);
            Rectangles.Controls.Add(textBox7);
            Rectangles.Controls.Add(textBox6);
            Rectangles.Controls.Add(textBox5);
            Rectangles.Controls.Add(label13);
            Rectangles.Controls.Add(button4);
            Rectangles.Controls.Add(button3);
            Rectangles.Controls.Add(listBox3);
            Rectangles.Location = new Point(4, 24);
            Rectangles.Name = "Rectangles";
            Rectangles.Padding = new Padding(3);
            Rectangles.Size = new Size(742, 450);
            Rectangles.TabIndex = 2;
            Rectangles.Text = "Rectangles";
            Rectangles.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(224, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(559, 407);
            panel1.TabIndex = 14;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(49, 278);
            label18.Name = "label18";
            label18.Size = new Size(20, 15);
            label18.TabIndex = 13;
            label18.Text = "Id:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(52, 333);
            label17.Name = "label17";
            label17.Size = new Size(17, 15);
            label17.TabIndex = 12;
            label17.Text = "Y:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(27, 362);
            label16.Name = "label16";
            label16.Size = new Size(42, 15);
            label16.TabIndex = 11;
            label16.Text = "Width:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(27, 394);
            label15.Name = "label15";
            label15.Size = new Size(46, 15);
            label15.TabIndex = 10;
            label15.Text = "Height:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(52, 304);
            label14.Name = "label14";
            label14.Size = new Size(17, 15);
            label14.TabIndex = 9;
            label14.Text = "X:";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(74, 272);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(100, 23);
            textBox9.TabIndex = 8;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(74, 301);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 7;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(74, 330);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 6;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(74, 359);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 5;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(74, 391);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 4;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(20, 257);
            label13.Name = "label13";
            label13.Size = new Size(109, 15);
            label13.TabIndex = 3;
            label13.Text = "Selected Rectangle:";
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 2;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button4.Location = new Point(164, 211);
            button4.Name = "button4";
            button4.Size = new Size(23, 23);
            button4.TabIndex = 2;
            button4.UseVisualStyleBackColor = true;
            button4.Click += deleteRectangle;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button3.Location = new Point(74, 211);
            button3.Name = "button3";
            button3.Size = new Size(23, 23);
            button3.TabIndex = 1;
            button3.UseVisualStyleBackColor = true;
            button3.Click += addRectangle;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(17, 22);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(201, 169);
            listBox3.TabIndex = 0;
            listBox3.SelectedIndexChanged += listBox3_SelectedIndexChanged;
            // 
            // RectanglesCollisionControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Name = "RectanglesCollisionControl";
            Size = new Size(750, 478);
            tabControl1.ResumeLayout(false);
            Rectangles.ResumeLayout(false);
            Rectangles.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Rectangles;
        private Panel panel1;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private Label label13;
        private Button button4;
        private Button button3;
        private ListBox listBox3;
    }
}
