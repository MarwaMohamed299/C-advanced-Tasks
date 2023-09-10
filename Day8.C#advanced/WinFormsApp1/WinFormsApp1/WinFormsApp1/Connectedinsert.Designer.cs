namespace WinFormsApp1
{
    partial class Connectedinsert
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
            txtID = new TextBox();
            txtFname = new TextBox();
            txtLname = new TextBox();
            txtAddress = new TextBox();
            Label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnInsert = new Button();
            SuspendLayout();
            // 
            // txtID
            // 
            txtID.Location = new Point(100, 77);
            txtID.Name = "txtID";
            txtID.Size = new Size(125, 27);
            txtID.TabIndex = 0;
            // 
            // txtFname
            // 
            txtFname.Location = new Point(100, 130);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(125, 27);
            txtFname.TabIndex = 1;
            txtFname.TextChanged += textBox2_TextChanged;
            // 
            // txtLname
            // 
            txtLname.Location = new Point(98, 199);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(136, 27);
            txtLname.TabIndex = 2;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(94, 277);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(140, 27);
            txtAddress.TabIndex = 3;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(34, 77);
            Label1.Name = "Label1";
            Label1.Size = new Size(22, 20);
            Label1.TabIndex = 4;
            Label1.Text = "id";
            Label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 141);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 5;
            label2.Text = "Fname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 205);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 6;
            label3.Text = "Lname";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 284);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 7;
            label4.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(448, 356);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 8;
            label5.Text = "label5";
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(278, 351);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(68, 25);
            btnInsert.TabIndex = 9;
            btnInsert.Text = "insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += button1_Click;
            // 
            // Connectedinsert
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnInsert);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Label1);
            Controls.Add(txtAddress);
            Controls.Add(txtLname);
            Controls.Add(txtFname);
            Controls.Add(txtID);
            Name = "Connectedinsert";
            Text = "Connectedinsert";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label Label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private TextBox txtID;
        private TextBox txtFname;
        private TextBox txtLname;
        private TextBox txtAddress;
        private Button btnInsert;
    }
}