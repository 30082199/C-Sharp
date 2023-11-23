namespace Astronomical_Processsing
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
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            editBtn = new Button();
            sortBtn = new Button();
            searchBtn = new Button();
            genBtn = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(28, 28);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(290, 344);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(350, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(195, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // editBtn
            // 
            editBtn.Location = new Point(350, 72);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(54, 24);
            editBtn.TabIndex = 2;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // sortBtn
            // 
            sortBtn.Location = new Point(422, 72);
            sortBtn.Name = "sortBtn";
            sortBtn.Size = new Size(54, 24);
            sortBtn.TabIndex = 3;
            sortBtn.Text = "Sort";
            sortBtn.UseVisualStyleBackColor = true;
            sortBtn.Click += sortBtn_Click;
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(491, 72);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(54, 24);
            searchBtn.TabIndex = 4;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // genBtn
            // 
            genBtn.Location = new Point(350, 321);
            genBtn.Name = "genBtn";
            genBtn.Size = new Size(199, 51);
            genBtn.TabIndex = 5;
            genBtn.Text = "Generate Random Numbers";
            genBtn.UseVisualStyleBackColor = true;
            genBtn.Click += genBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 450);
            Controls.Add(genBtn);
            Controls.Add(searchBtn);
            Controls.Add(sortBtn);
            Controls.Add(editBtn);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private TextBox textBox1;
        private Button editBtn;
        private Button sortBtn;
        private Button searchBtn;
        private Button genBtn;
    }
}