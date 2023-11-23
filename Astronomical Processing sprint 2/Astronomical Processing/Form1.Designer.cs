namespace Astronomical_Processing
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            editBtn = new Button();
            sortBtn = new Button();
            searchBtn = new Button();
            genBtn = new Button();
            midBtn = new Button();
            modeBtn = new Button();
            aveBtn = new Button();
            ranBtn = new Button();
            binSearchBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            midTip = new ToolTip(components);
            modeTip = new ToolTip(components);
            averageTip = new ToolTip(components);
            rangeTip = new ToolTip(components);
            binaryTip = new ToolTip(components);
            linearTip = new ToolTip(components);
            editTip = new ToolTip(components);
            sortTip = new ToolTip(components);
            TextBoxTip = new ToolTip(components);
            ListBoxTip = new ToolTip(components);
            GenTip = new ToolTip(components);
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(350, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(203, 23);
            textBox1.TabIndex = 0;
            TextBoxTip.SetToolTip(textBox1, "Type your number");
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(163, 80);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(181, 274);
            listBox1.TabIndex = 1;
            ListBoxTip.SetToolTip(listBox1, "List of numbers ");
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // editBtn
            // 
            editBtn.Location = new Point(357, 143);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(87, 23);
            editBtn.TabIndex = 2;
            editBtn.Text = "Edit";
            editTip.SetToolTip(editBtn, "Select from the listbox and use textbox to edit");
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // sortBtn
            // 
            sortBtn.Location = new Point(450, 143);
            sortBtn.Name = "sortBtn";
            sortBtn.Size = new Size(94, 23);
            sortBtn.TabIndex = 3;
            sortBtn.Text = "Sort";
            sortTip.SetToolTip(sortBtn, "Click to sort the List Box");
            sortBtn.UseVisualStyleBackColor = true;
            sortBtn.Click += sortBtn_Click;
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(450, 114);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(94, 23);
            searchBtn.TabIndex = 4;
            searchBtn.Text = "Linear Search";
            linearTip.SetToolTip(searchBtn, "Use the text box to input your number and click to perform linear search");
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // genBtn
            // 
            genBtn.BackColor = Color.CornflowerBlue;
            genBtn.Location = new Point(357, 331);
            genBtn.Name = "genBtn";
            genBtn.Size = new Size(187, 23);
            genBtn.TabIndex = 5;
            genBtn.Text = "Generate Random Numbers";
            GenTip.SetToolTip(genBtn, "Click to Generate numbers");
            genBtn.UseVisualStyleBackColor = false;
            genBtn.Click += genBtn_Click;
            // 
            // midBtn
            // 
            midBtn.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            midBtn.Location = new Point(357, 235);
            midBtn.Name = "midBtn";
            midBtn.Size = new Size(87, 23);
            midBtn.TabIndex = 6;
            midBtn.Text = "Mid - Extreme";
            midTip.SetToolTip(midBtn, "Click to calculate the Mean of the list box");
            midBtn.UseVisualStyleBackColor = true;
            midBtn.Click += midBtn_Click;
            // 
            // modeBtn
            // 
            modeBtn.Location = new Point(450, 235);
            modeBtn.Name = "modeBtn";
            modeBtn.Size = new Size(94, 23);
            modeBtn.TabIndex = 7;
            modeBtn.Text = "Mode";
            modeTip.SetToolTip(modeBtn, "Click to calculate the Mode of the list box");
            modeBtn.UseVisualStyleBackColor = true;
            modeBtn.Click += modeBtn_Click;
            // 
            // aveBtn
            // 
            aveBtn.Location = new Point(357, 264);
            aveBtn.Name = "aveBtn";
            aveBtn.Size = new Size(87, 23);
            aveBtn.TabIndex = 8;
            aveBtn.Text = "Average";
            averageTip.SetToolTip(aveBtn, "Click to calculate the Average of the list box");
            aveBtn.UseVisualStyleBackColor = true;
            aveBtn.Click += aveBtn_Click;
            // 
            // ranBtn
            // 
            ranBtn.Location = new Point(450, 264);
            ranBtn.Name = "ranBtn";
            ranBtn.Size = new Size(94, 23);
            ranBtn.TabIndex = 9;
            ranBtn.Text = "Range";
            rangeTip.SetToolTip(ranBtn, "Click to calculate the Range of the list box");
            ranBtn.UseVisualStyleBackColor = true;
            ranBtn.Click += ranBtn_Click;
            // 
            // binSearchBtn
            // 
            binSearchBtn.Location = new Point(357, 114);
            binSearchBtn.Name = "binSearchBtn";
            binSearchBtn.Size = new Size(87, 23);
            binSearchBtn.TabIndex = 10;
            binSearchBtn.Text = "Binary Search";
            binaryTip.SetToolTip(binSearchBtn, "Use the text box to input your number and click to perform binary search");
            binSearchBtn.UseVisualStyleBackColor = true;
            binSearchBtn.Click += binSearchBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(350, 217);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 11;
            label1.Text = "Calculations";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(350, 62);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 12;
            label2.Text = "Text Box";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(163, 62);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 13;
            label3.Text = "List";
            // 
            // midTip
            // 
            midTip.Popup += midTip_Popup;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(binSearchBtn);
            Controls.Add(ranBtn);
            Controls.Add(aveBtn);
            Controls.Add(modeBtn);
            Controls.Add(midBtn);
            Controls.Add(genBtn);
            Controls.Add(searchBtn);
            Controls.Add(sortBtn);
            Controls.Add(editBtn);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Astronomical Processing";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private ListBox listBox1;
        private Button editBtn;
        private Button sortBtn;
        private Button searchBtn;
        private Button genBtn;
        private Button midBtn;
        private Button modeBtn;
        private Button aveBtn;
        private Button ranBtn;
        private Button binSearchBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private ToolTip midTip;
        private ToolTip modeTip;
        private ToolTip averageTip;
        private ToolTip rangeTip;
        private ToolTip binaryTip;
        private ToolTip linearTip;
        private ToolTip editTip;
        private ToolTip sortTip;
        private ToolTip TextBoxTip;
        private ToolTip ListBoxTip;
        private ToolTip GenTip;
    }
}