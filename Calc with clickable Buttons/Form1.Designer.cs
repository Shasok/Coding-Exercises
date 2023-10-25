namespace Calc_with_clickable_Buttons
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
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            b1 = new Button();
            b2 = new Button();
            b3 = new Button();
            b4 = new Button();
            b5 = new Button();
            b6 = new Button();
            b7 = new Button();
            b8 = new Button();
            b9 = new Button();
            b0 = new Button();
            bdeci = new Button();
            bequal = new Button();
            bplus = new Button();
            bminus = new Button();
            bmulti = new Button();
            bdiv = new Button();
            bClear = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 1);
            tableLayoutPanel1.Controls.Add(textBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.Size = new Size(468, 379);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(b1);
            flowLayoutPanel1.Controls.Add(b2);
            flowLayoutPanel1.Controls.Add(b3);
            flowLayoutPanel1.Controls.Add(b4);
            flowLayoutPanel1.Controls.Add(b5);
            flowLayoutPanel1.Controls.Add(b6);
            flowLayoutPanel1.Controls.Add(b7);
            flowLayoutPanel1.Controls.Add(b8);
            flowLayoutPanel1.Controls.Add(b9);
            flowLayoutPanel1.Controls.Add(b0);
            flowLayoutPanel1.Controls.Add(bdeci);
            flowLayoutPanel1.Controls.Add(bequal);
            flowLayoutPanel1.Controls.Add(bplus);
            flowLayoutPanel1.Controls.Add(bminus);
            flowLayoutPanel1.Controls.Add(bmulti);
            flowLayoutPanel1.Controls.Add(bdiv);
            flowLayoutPanel1.Controls.Add(bClear);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 116);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(368, 260);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // b1
            // 
            b1.Location = new Point(3, 3);
            b1.Name = "b1";
            b1.Size = new Size(94, 29);
            b1.TabIndex = 0;
            b1.Text = "1";
            b1.UseVisualStyleBackColor = true;
            b1.Click += button1_Click;
            // 
            // b2
            // 
            b2.Location = new Point(103, 3);
            b2.Name = "b2";
            b2.Size = new Size(94, 29);
            b2.TabIndex = 1;
            b2.Text = "2";
            b2.UseVisualStyleBackColor = true;
            b2.Click += button2_Click;
            // 
            // b3
            // 
            b3.Location = new Point(203, 3);
            b3.Name = "b3";
            b3.Size = new Size(94, 29);
            b3.TabIndex = 2;
            b3.Text = "3";
            b3.UseVisualStyleBackColor = true;
            b3.Click += b3_Click;
            // 
            // b4
            // 
            b4.Location = new Point(3, 38);
            b4.Name = "b4";
            b4.Size = new Size(94, 29);
            b4.TabIndex = 3;
            b4.Text = "4";
            b4.UseVisualStyleBackColor = true;
            b4.Click += b4_Click;
            // 
            // b5
            // 
            b5.Location = new Point(103, 38);
            b5.Name = "b5";
            b5.Size = new Size(94, 29);
            b5.TabIndex = 4;
            b5.Text = "5";
            b5.UseVisualStyleBackColor = true;
            b5.Click += b5_Click;
            // 
            // b6
            // 
            b6.Location = new Point(203, 38);
            b6.Name = "b6";
            b6.Size = new Size(94, 29);
            b6.TabIndex = 5;
            b6.Text = "6";
            b6.UseVisualStyleBackColor = true;
            b6.Click += b6_Click;
            // 
            // b7
            // 
            b7.Location = new Point(3, 73);
            b7.Name = "b7";
            b7.Size = new Size(94, 29);
            b7.TabIndex = 6;
            b7.Text = "7";
            b7.UseVisualStyleBackColor = true;
            b7.Click += b7_Click;
            // 
            // b8
            // 
            b8.Location = new Point(103, 73);
            b8.Name = "b8";
            b8.Size = new Size(94, 29);
            b8.TabIndex = 7;
            b8.Text = "8";
            b8.UseVisualStyleBackColor = true;
            b8.Click += b8_Click;
            // 
            // b9
            // 
            b9.Location = new Point(203, 73);
            b9.Name = "b9";
            b9.Size = new Size(94, 29);
            b9.TabIndex = 8;
            b9.Text = "9";
            b9.UseVisualStyleBackColor = true;
            b9.Click += b9_Click;
            // 
            // b0
            // 
            b0.Location = new Point(3, 108);
            b0.Name = "b0";
            b0.Size = new Size(94, 29);
            b0.TabIndex = 9;
            b0.Text = "0";
            b0.UseVisualStyleBackColor = true;
            b0.Click += b0_Click;
            // 
            // bdeci
            // 
            bdeci.Location = new Point(103, 108);
            bdeci.Name = "bdeci";
            bdeci.Size = new Size(94, 29);
            bdeci.TabIndex = 10;
            bdeci.Text = ",";
            bdeci.UseVisualStyleBackColor = true;
            bdeci.Click += bdeci_Click;
            // 
            // bequal
            // 
            bequal.Location = new Point(203, 108);
            bequal.Name = "bequal";
            bequal.Size = new Size(94, 29);
            bequal.TabIndex = 11;
            bequal.Text = "=";
            bequal.UseVisualStyleBackColor = true;
            bequal.Click += bequal_Click;
            // 
            // bplus
            // 
            bplus.Location = new Point(3, 143);
            bplus.Name = "bplus";
            bplus.Size = new Size(94, 29);
            bplus.TabIndex = 12;
            bplus.Text = "+";
            bplus.UseVisualStyleBackColor = true;
            bplus.Click += bplus_Click;
            // 
            // bminus
            // 
            bminus.Location = new Point(103, 143);
            bminus.Name = "bminus";
            bminus.Size = new Size(94, 29);
            bminus.TabIndex = 13;
            bminus.Text = "-";
            bminus.UseVisualStyleBackColor = true;
            bminus.Click += bminus_Click;
            // 
            // bmulti
            // 
            bmulti.Location = new Point(203, 143);
            bmulti.Name = "bmulti";
            bmulti.Size = new Size(94, 29);
            bmulti.TabIndex = 14;
            bmulti.Text = "*";
            bmulti.UseVisualStyleBackColor = true;
            bmulti.Click += bmulti_Click;
            // 
            // bdiv
            // 
            bdiv.Location = new Point(3, 178);
            bdiv.Name = "bdiv";
            bdiv.Size = new Size(94, 29);
            bdiv.TabIndex = 15;
            bdiv.Text = "/";
            bdiv.UseVisualStyleBackColor = true;
            bdiv.Click += bdiv_Click;
            // 
            // bClear
            // 
            bClear.Location = new Point(103, 178);
            bClear.Name = "bClear";
            bClear.Size = new Size(94, 29);
            bClear.TabIndex = 16;
            bClear.Text = "Clear";
            bClear.UseVisualStyleBackColor = true;
            bClear.Click += bClear_Click;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Bottom;
            textBox1.Location = new Point(3, 62);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(368, 48);
            textBox1.TabIndex = 1;
            textBox1.Text = "0";
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Dock = DockStyle.Bottom;
            label1.Location = new Point(377, 91);
            label1.Name = "label1";
            label1.Size = new Size(88, 22);
            label1.TabIndex = 2;
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 379);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button b1;
        private Button b2;
        private Button b3;
        private Button b4;
        private Button b5;
        private Button b6;
        private Button b7;
        private Button b8;
        private Button b9;
        private Button b0;
        private Button bdeci;
        private Button bequal;
        private Button bplus;
        private Button bminus;
        private Button bmulti;
        private Button bdiv;
        private TextBox textBox1;
        private Label label1;
        private Button bClear;
    }
}