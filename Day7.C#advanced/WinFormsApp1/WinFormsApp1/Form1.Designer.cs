namespace WinFormsApp1
{
    public partial class Form1
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
            button1 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn5 = new Button();
            subtract = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            add = new Button();
            multiply = new Button();
            btn6 = new Button();
            divide = new Button();
            button2 = new Button();
            C = new Button();
            equal = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Top;
            textBox1.Enabled = false;
            textBox1.Location = new Point(0, 0);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(358, 67);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(137, 513);
            button1.Name = "button1";
            button1.Size = new Size(94, 34);
            button1.TabIndex = 1;
            button1.Text = "0";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnEvent;
            // 
            // btn1
            // 
            btn1.Location = new Point(29, 409);
            btn1.Name = "btn1";
            btn1.Size = new Size(94, 41);
            btn1.TabIndex = 2;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btnEvent;
            // 
            // btn2
            // 
            btn2.Location = new Point(146, 409);
            btn2.Name = "btn2";
            btn2.Size = new Size(94, 41);
            btn2.TabIndex = 3;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btnEvent;
            // 
            // btn5
            // 
            btn5.Location = new Point(146, 348);
            btn5.Name = "btn5";
            btn5.Size = new Size(94, 38);
            btn5.TabIndex = 4;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btnEvent;
            // 
            // subtract
            // 
            subtract.Location = new Point(99, 187);
            subtract.Name = "subtract";
            subtract.Size = new Size(69, 32);
            subtract.TabIndex = 5;
            subtract.Text = "-";
            subtract.UseVisualStyleBackColor = true;
            subtract.Click += button5_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(29, 287);
            btn7.Name = "btn7";
            btn7.Size = new Size(94, 40);
            btn7.TabIndex = 6;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btnEvent;
            // 
            // btn8
            // 
            btn8.Location = new Point(146, 287);
            btn8.Name = "btn8";
            btn8.Size = new Size(94, 35);
            btn8.TabIndex = 7;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btnEvent;
            // 
            // btn9
            // 
            btn9.Location = new Point(252, 284);
            btn9.Name = "btn9";
            btn9.Size = new Size(94, 40);
            btn9.TabIndex = 8;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btnEvent;
            // 
            // btn3
            // 
            btn3.FlatStyle = FlatStyle.System;
            btn3.Location = new Point(264, 409);
            btn3.Name = "btn3";
            btn3.Size = new Size(94, 41);
            btn3.TabIndex = 9;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btnEvent;
            // 
            // btn4
            // 
            btn4.Location = new Point(29, 348);
            btn4.Name = "btn4";
            btn4.Size = new Size(94, 41);
            btn4.TabIndex = 10;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btnEvent;
            // 
            // add
            // 
            add.Location = new Point(226, 187);
            add.Name = "add";
            add.Size = new Size(66, 29);
            add.TabIndex = 11;
            add.Text = "+";
            add.UseVisualStyleBackColor = true;
            add.Click += button11_Click;
            // 
            // multiply
            // 
            multiply.Location = new Point(29, 187);
            multiply.Name = "multiply";
            multiply.Size = new Size(70, 34);
            multiply.TabIndex = 12;
            multiply.Text = "*";
            multiply.UseVisualStyleBackColor = true;
            multiply.Click += multiply_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(252, 348);
            btn6.Name = "btn6";
            btn6.Size = new Size(106, 38);
            btn6.TabIndex = 13;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btnEvent;
            // 
            // divide
            // 
            divide.Location = new Point(163, 187);
            divide.Name = "divide";
            divide.Size = new Size(57, 29);
            divide.TabIndex = 14;
            divide.Text = "/";
            divide.UseVisualStyleBackColor = true;
            divide.Click += button14_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.System;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(252, 513);
            button2.Name = "button2";
            button2.Size = new Size(94, 34);
            button2.TabIndex = 15;
            button2.Text = ".";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // C
            // 
            C.Location = new Point(29, 513);
            C.Name = "C";
            C.Size = new Size(94, 34);
            C.TabIndex = 16;
            C.Text = "C";
            C.UseVisualStyleBackColor = true;
            C.Click += C_Click;
            // 
            // equal
            // 
            equal.Location = new Point(114, 130);
            equal.Name = "equal";
            equal.Size = new Size(94, 29);
            equal.TabIndex = 17;
            equal.Text = "=";
            equal.UseVisualStyleBackColor = true;
            equal.Click += button3_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(358, 581);
            Controls.Add(equal);
            Controls.Add(C);
            Controls.Add(button2);
            Controls.Add(divide);
            Controls.Add(btn6);
            Controls.Add(multiply);
            Controls.Add(add);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(subtract);
            Controls.Add(btn5);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button btn1;
        private Button btn2;
        private Button btn5;
        private Button subtract;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn3;
        private Button btn4;
        private Button add;
        private Button multiply;
        private Button btn6;
        private Button divide;
        private Button button2;
        private Button C;
        private Button equal;
    }
}