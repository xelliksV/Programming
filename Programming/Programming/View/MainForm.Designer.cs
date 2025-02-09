namespace Programming
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
            Classes = new TabPage();
            movieTab = new TabControl();
            Rectangles = new TabPage();
            button1 = new Button();
            label5 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            Movies = new TabPage();
            genre = new ComboBox();
            button2 = new Button();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            raiting = new TextBox();
            year = new TextBox();
            duration = new TextBox();
            name = new TextBox();
            listBox2 = new ListBox();
            tabPage1 = new TabPage();
            seasonTab = new TabControl();
            tabPage4 = new TabPage();
            seasonButton = new Button();
            seasonBox = new ComboBox();
            label2 = new Label();
            enumParseTab = new TabControl();
            tabPage3 = new TabPage();
            parseLabel = new Label();
            parsingButton = new Button();
            parsingBox = new TextBox();
            label1 = new Label();
            choosenValue = new Label();
            valueLabel = new Label();
            enumLabel = new Label();
            ValueBox = new TextBox();
            ValuesListBox = new ListBox();
            EnumsListBox = new ListBox();
            tabControl1 = new TabControl();
            Classes.SuspendLayout();
            movieTab.SuspendLayout();
            Rectangles.SuspendLayout();
            Movies.SuspendLayout();
            tabPage1.SuspendLayout();
            seasonTab.SuspendLayout();
            tabPage4.SuspendLayout();
            enumParseTab.SuspendLayout();
            tabPage3.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // Classes
            // 
            Classes.BackColor = SystemColors.Window;
            Classes.Controls.Add(movieTab);
            Classes.Location = new Point(4, 24);
            Classes.Name = "Classes";
            Classes.Padding = new Padding(3);
            Classes.Size = new Size(792, 422);
            Classes.TabIndex = 1;
            Classes.Text = "Classes";
            // 
            // movieTab
            // 
            movieTab.Controls.Add(Rectangles);
            movieTab.Controls.Add(Movies);
            movieTab.Location = new Point(8, 8);
            movieTab.Name = "movieTab";
            movieTab.SelectedIndex = 0;
            movieTab.Size = new Size(257, 282);
            movieTab.TabIndex = 0;
            // 
            // Rectangles
            // 
            Rectangles.Controls.Add(button1);
            Rectangles.Controls.Add(label5);
            Rectangles.Controls.Add(textBox3);
            Rectangles.Controls.Add(label4);
            Rectangles.Controls.Add(textBox2);
            Rectangles.Controls.Add(label3);
            Rectangles.Controls.Add(textBox1);
            Rectangles.Controls.Add(listBox1);
            Rectangles.Location = new Point(4, 24);
            Rectangles.Name = "Rectangles";
            Rectangles.Padding = new Padding(3);
            Rectangles.Size = new Size(249, 254);
            Rectangles.TabIndex = 1;
            Rectangles.Text = "Rectangles";
            Rectangles.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(129, 152);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Find";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(129, 95);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 5;
            label5.Text = "Color:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(129, 113);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 1;
            textBox3.TextChanged += colorChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(129, 51);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 4;
            label4.Text = "Width:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(129, 69);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += WidthChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(129, 6);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 2;
            label3.Text = "Height:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(129, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += HeightChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "Rectangle 1", "Rectangle 2", "Rectangle 3", "Rectangle 4", "Rectangle 5" });
            listBox1.Location = new Point(3, 6);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 169);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Movies
            // 
            Movies.Controls.Add(genre);
            Movies.Controls.Add(button2);
            Movies.Controls.Add(label10);
            Movies.Controls.Add(label9);
            Movies.Controls.Add(label8);
            Movies.Controls.Add(label7);
            Movies.Controls.Add(label6);
            Movies.Controls.Add(raiting);
            Movies.Controls.Add(year);
            Movies.Controls.Add(duration);
            Movies.Controls.Add(name);
            Movies.Controls.Add(listBox2);
            Movies.Location = new Point(4, 24);
            Movies.Name = "Movies";
            Movies.Padding = new Padding(3);
            Movies.Size = new Size(249, 254);
            Movies.TabIndex = 2;
            Movies.Text = "Movies";
            Movies.UseVisualStyleBackColor = true;
            // 
            // genre
            // 
            genre.FormattingEnabled = true;
            genre.Items.AddRange(new object[] { "Comedy", "Drama", "Thriller", "Action", "Horror", "Blockbuster" });
            genre.Location = new Point(132, 151);
            genre.Name = "genre";
            genre.Size = new Size(100, 23);
            genre.TabIndex = 9;
            // 
            // button2
            // 
            button2.Location = new Point(88, 226);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Find";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(132, 179);
            label10.Name = "label10";
            label10.Size = new Size(47, 15);
            label10.TabIndex = 8;
            label10.Text = "Raiting:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(132, 133);
            label9.Name = "label9";
            label9.Size = new Size(41, 15);
            label9.TabIndex = 7;
            label9.Text = "Genre:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(132, 89);
            label8.Name = "label8";
            label8.Size = new Size(85, 15);
            label8.TabIndex = 1;
            label8.Text = "Year of release:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(132, 44);
            label7.Name = "label7";
            label7.Size = new Size(56, 15);
            label7.TabIndex = 1;
            label7.Text = "Duration:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(132, 3);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 6;
            label6.Text = "Name:";
            // 
            // raiting
            // 
            raiting.Location = new Point(132, 197);
            raiting.Name = "raiting";
            raiting.Size = new Size(100, 23);
            raiting.TabIndex = 5;
            raiting.TextChanged += raiting_TextChanged;
            // 
            // year
            // 
            year.Location = new Point(132, 107);
            year.Name = "year";
            year.Size = new Size(100, 23);
            year.TabIndex = 3;
            year.TextChanged += year_TextChanged;
            // 
            // duration
            // 
            duration.Location = new Point(132, 62);
            duration.Name = "duration";
            duration.Size = new Size(100, 23);
            duration.TabIndex = 2;
            duration.TextChanged += duration_TextChanged;
            // 
            // name
            // 
            name.Location = new Point(132, 18);
            name.Name = "name";
            name.Size = new Size(100, 23);
            name.TabIndex = 1;
            name.TextChanged += name_TextChanged;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Items.AddRange(new object[] { "Movie 1", "Movie 2", "Movie 3", "Movie 4", "Movie 5" });
            listBox2.Location = new Point(6, 6);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(120, 214);
            listBox2.TabIndex = 0;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(seasonTab);
            tabPage1.Controls.Add(enumParseTab);
            tabPage1.Controls.Add(choosenValue);
            tabPage1.Controls.Add(valueLabel);
            tabPage1.Controls.Add(enumLabel);
            tabPage1.Controls.Add(ValueBox);
            tabPage1.Controls.Add(ValuesListBox);
            tabPage1.Controls.Add(EnumsListBox);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Enums";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // seasonTab
            // 
            seasonTab.Controls.Add(tabPage4);
            seasonTab.Location = new Point(329, 262);
            seasonTab.Name = "seasonTab";
            seasonTab.SelectedIndex = 0;
            seasonTab.Size = new Size(279, 148);
            seasonTab.TabIndex = 10;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(seasonButton);
            tabPage4.Controls.Add(seasonBox);
            tabPage4.Controls.Add(label2);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(271, 120);
            tabPage4.TabIndex = 1;
            tabPage4.Text = "Season Handle";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // seasonButton
            // 
            seasonButton.Location = new Point(133, 30);
            seasonButton.Name = "seasonButton";
            seasonButton.Size = new Size(75, 23);
            seasonButton.TabIndex = 10;
            seasonButton.Text = "Go!";
            seasonButton.UseVisualStyleBackColor = true;
            seasonButton.Click += seasonButton_Click;
            // 
            // seasonBox
            // 
            seasonBox.FormattingEnabled = true;
            seasonBox.Items.AddRange(new object[] { "Spring", "Summer", "Autumn", "Winter" });
            seasonBox.Location = new Point(6, 31);
            seasonBox.Name = "seasonBox";
            seasonBox.Size = new Size(121, 23);
            seasonBox.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 13);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 0;
            label2.Text = "Choose season:";
            // 
            // enumParseTab
            // 
            enumParseTab.Controls.Add(tabPage3);
            enumParseTab.Location = new Point(6, 262);
            enumParseTab.Name = "enumParseTab";
            enumParseTab.SelectedIndex = 0;
            enumParseTab.Size = new Size(294, 152);
            enumParseTab.TabIndex = 6;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(parseLabel);
            tabPage3.Controls.Add(parsingButton);
            tabPage3.Controls.Add(parsingBox);
            tabPage3.Controls.Add(label1);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(286, 124);
            tabPage3.TabIndex = 1;
            tabPage3.Text = "Weekday Parsing";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // parseLabel
            // 
            parseLabel.AutoSize = true;
            parseLabel.Location = new Point(6, 57);
            parseLabel.Name = "parseLabel";
            parseLabel.Size = new Size(0, 15);
            parseLabel.TabIndex = 9;
            // 
            // parsingButton
            // 
            parsingButton.Location = new Point(190, 31);
            parsingButton.Name = "parsingButton";
            parsingButton.Size = new Size(75, 23);
            parsingButton.TabIndex = 8;
            parsingButton.Text = "Parse";
            parsingButton.UseVisualStyleBackColor = true;
            parsingButton.Click += parsingButton_Click;
            // 
            // parsingBox
            // 
            parsingBox.Location = new Point(6, 31);
            parsingBox.Name = "parsingBox";
            parsingBox.Size = new Size(178, 23);
            parsingBox.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 13);
            label1.Name = "label1";
            label1.Size = new Size(126, 15);
            label1.TabIndex = 7;
            label1.Text = "Type value for parsing:";
            // 
            // choosenValue
            // 
            choosenValue.AutoSize = true;
            choosenValue.Location = new Point(329, 23);
            choosenValue.Name = "choosenValue";
            choosenValue.Size = new Size(55, 15);
            choosenValue.TabIndex = 5;
            choosenValue.Text = "int value:";
            // 
            // valueLabel
            // 
            valueLabel.AutoSize = true;
            valueLabel.Location = new Point(162, 23);
            valueLabel.Name = "valueLabel";
            valueLabel.Size = new Size(81, 15);
            valueLabel.TabIndex = 4;
            valueLabel.Text = "Choose value:";
            // 
            // enumLabel
            // 
            enumLabel.AutoSize = true;
            enumLabel.Location = new Point(3, 23);
            enumLabel.Name = "enumLabel";
            enumLabel.Size = new Size(121, 15);
            enumLabel.TabIndex = 3;
            enumLabel.Text = "Choose enumaration:";
            // 
            // ValueBox
            // 
            ValueBox.Location = new Point(329, 38);
            ValueBox.Name = "ValueBox";
            ValueBox.Size = new Size(100, 23);
            ValueBox.TabIndex = 2;
            // 
            // ValuesListBox
            // 
            ValuesListBox.FormattingEnabled = true;
            ValuesListBox.ItemHeight = 15;
            ValuesListBox.Location = new Point(162, 38);
            ValuesListBox.Name = "ValuesListBox";
            ValuesListBox.Size = new Size(138, 199);
            ValuesListBox.TabIndex = 1;
            ValuesListBox.SelectedIndexChanged += ValuesListBox_SelectedIndexChanged;
            // 
            // EnumsListBox
            // 
            EnumsListBox.FormattingEnabled = true;
            EnumsListBox.ItemHeight = 15;
            EnumsListBox.Items.AddRange(new object[] { "Color", "Form of Education", "Genre", "Season", "Manufactures", "Weekday" });
            EnumsListBox.Location = new Point(6, 38);
            EnumsListBox.Name = "EnumsListBox";
            EnumsListBox.Size = new Size(137, 199);
            EnumsListBox.TabIndex = 0;
            EnumsListBox.SelectedIndexChanged += EnumsListBox_SelectedIndexChanged;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(Classes);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "Form1";
            Classes.ResumeLayout(false);
            movieTab.ResumeLayout(false);
            Rectangles.ResumeLayout(false);
            Rectangles.PerformLayout();
            Movies.ResumeLayout(false);
            Movies.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            seasonTab.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            enumParseTab.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage Classes;
        private TabControl movieTab;
        private TabPage Rectangles;
        private ListBox listBox1;
        private TabPage tabPage1;
        private TabControl seasonTab;
        private TabPage tabPage4;
        private Button seasonButton;
        private ComboBox seasonBox;
        private Label label2;
        private TabControl enumParseTab;
        private TabPage tabPage3;
        private Label parseLabel;
        private Button parsingButton;
        private TextBox parsingBox;
        private Label label1;
        private Label choosenValue;
        private Label valueLabel;
        private Label enumLabel;
        private TextBox ValueBox;
        private ListBox ValuesListBox;
        private ListBox EnumsListBox;
        private TabControl tabControl1;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Button button1;
        private Label label5;
        private TabPage Movies;
        private ListBox listBox2;
        private TextBox name;
        private TextBox duration;
        private Button button2;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox raiting;
        private TextBox year;
        private ComboBox genre;
    }
}
