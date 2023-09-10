namespace WinFormsApp1
{
    partial class frmUpdateAndDelete
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
            btnUpdate = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            Label1 = new Label();
            txtAddress = new TextBox();
            txtLname = new TextBox();
            txtFname = new TextBox();
            txtID = new TextBox();
            comboBox1 = new ComboBox();
            Delete = new Button();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(413, 350);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(68, 25);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(583, 355);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 18;
            label5.Text = "label5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(168, 283);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 17;
            label4.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(167, 204);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 16;
            label3.Text = "Lname";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(168, 140);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 15;
            label2.Text = "Fname";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(169, 76);
            Label1.Name = "Label1";
            Label1.Size = new Size(22, 20);
            Label1.TabIndex = 14;
            Label1.Text = "id";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(229, 276);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(140, 27);
            txtAddress.TabIndex = 13;
            // 
            // txtLname
            // 
            txtLname.Location = new Point(233, 198);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(136, 27);
            txtLname.TabIndex = 12;
            // 
            // txtFname
            // 
            txtFname.Location = new Point(235, 129);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(125, 27);
            txtFname.TabIndex = 11;
            // 
            // txtID
            // 
            txtID.Location = new Point(235, 76);
            txtID.Name = "txtID";
            txtID.Size = new Size(125, 27);
            txtID.TabIndex = 10;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(235, 26);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(118, 28);
            comboBox1.TabIndex = 20;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Delete
            // 
            Delete.Location = new Point(412, 280);
            Delete.Name = "Delete";
            Delete.Size = new Size(79, 22);
            Delete.TabIndex = 21;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // frmUpdateAndDelete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Delete);
            Controls.Add(comboBox1);
            Controls.Add(btnUpdate);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Label1);
            Controls.Add(txtAddress);
            Controls.Add(txtLname);
            Controls.Add(txtFname);
            Controls.Add(txtID);
            Name = "frmUpdateAndDelete";
            Text = "frmUpdateAndDelete";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdate;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label Label1;
        private TextBox txtAddress;
        private TextBox txtLname;
        private TextBox txtFname;
        private TextBox txtID;
        private ComboBox comboBox1;
        private Button Delete;
    }
}