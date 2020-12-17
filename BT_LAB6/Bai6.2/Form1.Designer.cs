namespace Bai6._2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsob = new System.Windows.Forms.TextBox();
            this.txtsoc = new System.Windows.Forms.TextBox();
            this.txtkqua = new System.Windows.Forms.TextBox();
            this.txtsoa = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdpt1 = new System.Windows.Forms.RadioButton();
            this.rdpt2 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(188, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "GIẢI PHƯƠNG TRÌNH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập vào số a";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập vào số b";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhập vào số c";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kết quả";
            // 
            // txtsob
            // 
            this.txtsob.Location = new System.Drawing.Point(412, 130);
            this.txtsob.Name = "txtsob";
            this.txtsob.Size = new System.Drawing.Size(100, 22);
            this.txtsob.TabIndex = 5;
            // 
            // txtsoc
            // 
            this.txtsoc.Location = new System.Drawing.Point(412, 166);
            this.txtsoc.Name = "txtsoc";
            this.txtsoc.Size = new System.Drawing.Size(100, 22);
            this.txtsoc.TabIndex = 6;
            // 
            // txtkqua
            // 
            this.txtkqua.Location = new System.Drawing.Point(292, 210);
            this.txtkqua.Name = "txtkqua";
            this.txtkqua.Size = new System.Drawing.Size(220, 22);
            this.txtkqua.TabIndex = 7;
            // 
            // txtsoa
            // 
            this.txtsoa.Location = new System.Drawing.Point(412, 98);
            this.txtsoa.Name = "txtsoa";
            this.txtsoa.Size = new System.Drawing.Size(100, 22);
            this.txtsoa.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(282, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 36);
            this.button1.TabIndex = 9;
            this.button1.Text = "Thực hiện";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.bntThuchien_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(412, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 36);
            this.button2.TabIndex = 10;
            this.button2.Text = "Đóng";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.bntDong_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdpt2);
            this.groupBox1.Controls.Add(this.rdpt1);
            this.groupBox1.Location = new System.Drawing.Point(77, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 95);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn phương trình";
            // 
            // rdpt1
            // 
            this.rdpt1.AutoSize = true;
            this.rdpt1.Location = new System.Drawing.Point(6, 36);
            this.rdpt1.Name = "rdpt1";
            this.rdpt1.Size = new System.Drawing.Size(91, 21);
            this.rdpt1.TabIndex = 12;
            this.rdpt1.TabStop = true;
            this.rdpt1.Text = "ax + b = 0";
            this.rdpt1.UseVisualStyleBackColor = true;
            this.rdpt1.CheckedChanged += new System.EventHandler(this.rdpt1_CheckedChanged);
            // 
            // rdpt2
            // 
            this.rdpt2.AutoSize = true;
            this.rdpt2.Location = new System.Drawing.Point(6, 63);
            this.rdpt2.Name = "rdpt2";
            this.rdpt2.Size = new System.Drawing.Size(135, 21);
            this.rdpt2.TabIndex = 13;
            this.rdpt2.TabStop = true;
            this.rdpt2.Text = "ax^2 + bx + c = 0";
            this.rdpt2.UseVisualStyleBackColor = true;
            this.rdpt2.CheckedChanged += new System.EventHandler(this.rdpt2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtsoa);
            this.Controls.Add(this.txtkqua);
            this.Controls.Add(this.txtsoc);
            this.Controls.Add(this.txtsob);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsob;
        private System.Windows.Forms.TextBox txtsoc;
        private System.Windows.Forms.TextBox txtkqua;
        private System.Windows.Forms.TextBox txtsoa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdpt1;
        private System.Windows.Forms.RadioButton rdpt2;
    }
}

