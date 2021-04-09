
namespace BT02_NguyenManhDuc
{
    partial class Form2
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
            this.MSSVInput = new System.Windows.Forms.TextBox();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.CbbLSH = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Femalerdo = new System.Windows.Forms.RadioButton();
            this.Malerdo = new System.Windows.Forms.RadioButton();
            this.Okbtn = new System.Windows.Forms.Button();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.txtmssv = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.Label();
            this.txtlsh = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MSSVInput
            // 
            this.MSSVInput.Location = new System.Drawing.Point(84, 52);
            this.MSSVInput.Name = "MSSVInput";
            this.MSSVInput.Size = new System.Drawing.Size(146, 22);
            this.MSSVInput.TabIndex = 0;
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(84, 105);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(146, 22);
            this.NameInput.TabIndex = 2;
            // 
            // CbbLSH
            // 
            this.CbbLSH.FormattingEnabled = true;
            this.CbbLSH.Location = new System.Drawing.Point(84, 157);
            this.CbbLSH.Name = "CbbLSH";
            this.CbbLSH.Size = new System.Drawing.Size(146, 24);
            this.CbbLSH.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(358, 52);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(237, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Femalerdo);
            this.groupBox1.Controls.Add(this.Malerdo);
            this.groupBox1.Location = new System.Drawing.Point(358, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // Femalerdo
            // 
            this.Femalerdo.AutoSize = true;
            this.Femalerdo.Location = new System.Drawing.Point(127, 52);
            this.Femalerdo.Name = "Femalerdo";
            this.Femalerdo.Size = new System.Drawing.Size(75, 21);
            this.Femalerdo.TabIndex = 1;
            this.Femalerdo.TabStop = true;
            this.Femalerdo.Text = "Female";
            this.Femalerdo.UseVisualStyleBackColor = true;
            // 
            // Malerdo
            // 
            this.Malerdo.AutoSize = true;
            this.Malerdo.Location = new System.Drawing.Point(26, 52);
            this.Malerdo.Name = "Malerdo";
            this.Malerdo.Size = new System.Drawing.Size(59, 21);
            this.Malerdo.TabIndex = 0;
            this.Malerdo.TabStop = true;
            this.Malerdo.Text = "Male";
            this.Malerdo.UseVisualStyleBackColor = true;
            // 
            // Okbtn
            // 
            this.Okbtn.Location = new System.Drawing.Point(135, 256);
            this.Okbtn.Name = "Okbtn";
            this.Okbtn.Size = new System.Drawing.Size(85, 30);
            this.Okbtn.TabIndex = 6;
            this.Okbtn.Text = "OK";
            this.Okbtn.UseVisualStyleBackColor = true;
            this.Okbtn.Click += new System.EventHandler(this.Okbtn_Click);
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.Location = new System.Drawing.Point(384, 256);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(85, 30);
            this.Cancelbtn.TabIndex = 7;
            this.Cancelbtn.Text = "Cancel";
            this.Cancelbtn.UseVisualStyleBackColor = true;
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // txtmssv
            // 
            this.txtmssv.AutoSize = true;
            this.txtmssv.Location = new System.Drawing.Point(12, 55);
            this.txtmssv.Name = "txtmssv";
            this.txtmssv.Size = new System.Drawing.Size(46, 17);
            this.txtmssv.TabIndex = 8;
            this.txtmssv.Text = "MSSV";
            // 
            // txtname
            // 
            this.txtname.AutoSize = true;
            this.txtname.Location = new System.Drawing.Point(12, 110);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(45, 17);
            this.txtname.TabIndex = 9;
            this.txtname.Text = "Name";
            // 
            // txtlsh
            // 
            this.txtlsh.AutoSize = true;
            this.txtlsh.Location = new System.Drawing.Point(12, 161);
            this.txtlsh.Name = "txtlsh";
            this.txtlsh.Size = new System.Drawing.Size(51, 17);
            this.txtlsh.TabIndex = 10;
            this.txtlsh.Text = "LopSH";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 338);
            this.Controls.Add(this.txtlsh);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtmssv);
            this.Controls.Add(this.Cancelbtn);
            this.Controls.Add(this.Okbtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.CbbLSH);
            this.Controls.Add(this.NameInput);
            this.Controls.Add(this.MSSVInput);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MSSVInput;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.ComboBox CbbLSH;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Femalerdo;
        private System.Windows.Forms.RadioButton Malerdo;
        private System.Windows.Forms.Button Okbtn;
        private System.Windows.Forms.Button Cancelbtn;
        private System.Windows.Forms.Label txtmssv;
        private System.Windows.Forms.Label txtname;
        private System.Windows.Forms.Label txtlsh;
    }
}