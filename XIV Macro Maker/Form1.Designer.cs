namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.macroBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.macroBox1 = new System.Windows.Forms.TextBox();
            this.macroBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.macroBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.targetBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.waitBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 27);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(338, 565);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 595);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(357, 13);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.macroBox3);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.macroBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.macroBox4);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.macroBox2);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Size = new System.Drawing.Size(550, 620);
            this.splitContainer1.SplitterDistance = 275;
            this.splitContainer1.TabIndex = 2;
            // 
            // macroBox3
            // 
            this.macroBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.macroBox3.Location = new System.Drawing.Point(0, 329);
            this.macroBox3.Multiline = true;
            this.macroBox3.Name = "macroBox3";
            this.macroBox3.ReadOnly = true;
            this.macroBox3.Size = new System.Drawing.Size(270, 274);
            this.macroBox3.TabIndex = 0;
            this.macroBox3.Click += new System.EventHandler(this.macroBox3_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(2, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(267, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Macro 3";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Macro 1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // macroBox1
            // 
            this.macroBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.macroBox1.Location = new System.Drawing.Point(0, 26);
            this.macroBox1.Multiline = true;
            this.macroBox1.Name = "macroBox1";
            this.macroBox1.ReadOnly = true;
            this.macroBox1.Size = new System.Drawing.Size(270, 274);
            this.macroBox1.TabIndex = 0;
            this.macroBox1.Click += new System.EventHandler(this.macroBox1_Click);
            // 
            // macroBox4
            // 
            this.macroBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.macroBox4.Location = new System.Drawing.Point(0, 329);
            this.macroBox4.Multiline = true;
            this.macroBox4.Name = "macroBox4";
            this.macroBox4.ReadOnly = true;
            this.macroBox4.Size = new System.Drawing.Size(270, 274);
            this.macroBox4.TabIndex = 0;
            this.macroBox4.Click += new System.EventHandler(this.macroBox4_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(2, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(267, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Macro 4";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // macroBox2
            // 
            this.macroBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.macroBox2.Location = new System.Drawing.Point(0, 26);
            this.macroBox2.Multiline = true;
            this.macroBox2.Name = "macroBox2";
            this.macroBox2.ReadOnly = true;
            this.macroBox2.Size = new System.Drawing.Size(270, 274);
            this.macroBox2.TabIndex = 0;
            this.macroBox2.Click += new System.EventHandler(this.macroBox2_Click);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Macro 2";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Abilities";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.targetBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.waitBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 621);
            this.panel1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(266, 595);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "About";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // targetBox
            // 
            this.targetBox.Location = new System.Drawing.Point(202, 597);
            this.targetBox.Name = "targetBox";
            this.targetBox.Size = new System.Drawing.Size(57, 20);
            this.targetBox.TabIndex = 6;
            this.targetBox.Text = "<me>";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(158, 600);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Target";
            // 
            // waitBox
            // 
            this.waitBox.Location = new System.Drawing.Point(119, 597);
            this.waitBox.Name = "waitBox";
            this.waitBox.Size = new System.Drawing.Size(32, 20);
            this.waitBox.TabIndex = 4;
            this.waitBox.Text = "3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(84, 600);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Wait";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(339, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Actions";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 645);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "X|V Macro Maker";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox macroBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox macroBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox macroBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox macroBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox targetBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox waitBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
    }
}

