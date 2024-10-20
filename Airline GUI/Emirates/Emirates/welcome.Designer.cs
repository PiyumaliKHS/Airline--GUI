namespace Emirates
{
    partial class welcome
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnclr = new System.Windows.Forms.Button();
            this.lblclose = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.MaskedTextBox();
            this.txtid = new System.Windows.Forms.MaskedTextBox();
            this.btnsignin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-11, -110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 593);
            this.panel1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Courier New", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(336, -84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(374, 40);
            this.label3.TabIndex = 19;
            this.label3.Text = "Emirates Airlines";
            // 
            // btnclr
            // 
            this.btnclr.FlatAppearance.BorderSize = 0;
            this.btnclr.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclr.ForeColor = System.Drawing.Color.DarkRed;
            this.btnclr.Location = new System.Drawing.Point(538, 275);
            this.btnclr.Name = "btnclr";
            this.btnclr.Size = new System.Drawing.Size(80, 34);
            this.btnclr.TabIndex = 18;
            this.btnclr.Text = "Clear";
            this.btnclr.UseVisualStyleBackColor = true;
            this.btnclr.Click += new System.EventHandler(this.btnclr_Click);
            // 
            // lblclose
            // 
            this.lblclose.AutoSize = true;
            this.lblclose.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclose.ForeColor = System.Drawing.Color.DarkRed;
            this.lblclose.Location = new System.Drawing.Point(698, -110);
            this.lblclose.Name = "lblclose";
            this.lblclose.Size = new System.Drawing.Size(27, 26);
            this.lblclose.TabIndex = 17;
            this.lblclose.Text = "X";
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(489, 201);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(162, 20);
            this.txtpass.TabIndex = 16;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(489, 125);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(162, 20);
            this.txtid.TabIndex = 15;
            // 
            // btnsignin
            // 
            this.btnsignin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnsignin.FlatAppearance.BorderSize = 0;
            this.btnsignin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsignin.ForeColor = System.Drawing.Color.DarkRed;
            this.btnsignin.Location = new System.Drawing.Point(384, 275);
            this.btnsignin.Name = "btnsignin";
            this.btnsignin.Size = new System.Drawing.Size(75, 34);
            this.btnsignin.TabIndex = 14;
            this.btnsignin.Text = "Sign In";
            this.btnsignin.UseVisualStyleBackColor = true;
            this.btnsignin.Click += new System.EventHandler(this.btnsignin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(379, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 27);
            this.label2.TabIndex = 13;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(379, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 27);
            this.label1.TabIndex = 12;
            this.label1.Text = "User Id";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Emirates.Properties.Resources._1920_em_cabin_crew_set6_depature_dual_1582copy;
            this.pictureBox1.Location = new System.Drawing.Point(23, 174);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 258);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Courier New", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(141, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(374, 40);
            this.label4.TabIndex = 20;
            this.label4.Text = "Emirates Airlines";
            // 
            // welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 373);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnclr);
            this.Controls.Add(this.lblclose);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.btnsignin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "welcome";
            this.Text = "welcome";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnclr;
        private System.Windows.Forms.Label lblclose;
        private System.Windows.Forms.MaskedTextBox txtpass;
        private System.Windows.Forms.MaskedTextBox txtid;
        private System.Windows.Forms.Button btnsignin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}