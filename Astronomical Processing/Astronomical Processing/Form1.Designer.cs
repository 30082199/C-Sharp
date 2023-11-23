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
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            editBtn = new Button();
            sortBtn = new Button();
            searchBtn = new Button();
            genBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(350, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(203, 23);
            textBox1.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(163, 80);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(181, 274);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // editBtn
            // 
            editBtn.Location = new Point(357, 115);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(59, 23);
            editBtn.TabIndex = 2;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // sortBtn
            // 
            sortBtn.Location = new Point(422, 115);
            sortBtn.Name = "sortBtn";
            sortBtn.Size = new Size(59, 23);
            sortBtn.TabIndex = 3;
            sortBtn.Text = "Sort";
            sortBtn.UseVisualStyleBackColor = true;
            sortBtn.Click += sortBtn_Click;
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(485, 115);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(59, 23);
            searchBtn.TabIndex = 4;
            searchBtn.Text = "Search";
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
            genBtn.UseVisualStyleBackColor = false;
            genBtn.Click += genBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(350, 62);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 6;
            label1.Text = "Text Box";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(163, 62);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 7;
            label2.Text = "List";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(genBtn);
            Controls.Add(searchBtn);
            Controls.Add(sortBtn);
            Controls.Add(editBtn);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Astronomical Processing";
            Load += Form1_Load;
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
        private Label label1;
        private Label label2;
    }
}