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
            tabControl1 = new TabControl();
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
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            seasonTab.SuspendLayout();
            tabPage4.SuspendLayout();
            enumParseTab.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            seasonTab.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            enumParseTab.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label enumLabel;
        private TextBox ValueBox;
        private ListBox ValuesListBox;
        private ListBox EnumsListBox;
        private Label choosenValue;
        private Label valueLabel;
        private TabControl enumParseTab;
        private TabPage tabPage3;
        private Button parsingButton;
        private TextBox parsingBox;
        private Label label1;
        private Label parseLabel;
        private TabControl seasonTab;
        private TabPage tabPage4;
        private Button seasonButton;
        private ComboBox seasonBox;
        private Label label2;
    }
}
