namespace Server
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPokreniIgru = new System.Windows.Forms.Button();
            this.broj1 = new System.Windows.Forms.TextBox();
            this.broj2 = new System.Windows.Forms.TextBox();
            this.broj3 = new System.Windows.Forms.TextBox();
            this.broj4 = new System.Windows.Forms.TextBox();
            this.broj5 = new System.Windows.Forms.TextBox();
            this.broj6 = new System.Windows.Forms.TextBox();
            this.broj7 = new System.Windows.Forms.TextBox();
            this.broj8 = new System.Windows.Forms.TextBox();
            this.broj9 = new System.Windows.Forms.TextBox();
            this.txtIIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(92, 33);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(124, 22);
            this.txtEmail.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(92, 87);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(124, 22);
            this.txtPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(113, 143);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(41, 220);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 61);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(41, 334);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 54);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPokreniIgru
            // 
            this.btnPokreniIgru.Location = new System.Drawing.Point(420, 393);
            this.btnPokreniIgru.Name = "btnPokreniIgru";
            this.btnPokreniIgru.Size = new System.Drawing.Size(75, 23);
            this.btnPokreniIgru.TabIndex = 7;
            this.btnPokreniIgru.Text = "Pokreni igru";
            this.btnPokreniIgru.UseVisualStyleBackColor = true;
            this.btnPokreniIgru.Click += new System.EventHandler(this.btnPokreniIgru_Click);
            // 
            // broj1
            // 
            this.broj1.Location = new System.Drawing.Point(3, 3);
            this.broj1.MaxLength = 1;
            this.broj1.Multiline = true;
            this.broj1.Name = "broj1";
            this.broj1.Size = new System.Drawing.Size(47, 44);
            this.broj1.TabIndex = 8;
            this.broj1.Validated += new System.EventHandler(this.broj_TextChanged);
            // 
            // broj2
            // 
            this.broj2.Location = new System.Drawing.Point(79, 3);
            this.broj2.MaxLength = 1;
            this.broj2.Multiline = true;
            this.broj2.Name = "broj2";
            this.broj2.Size = new System.Drawing.Size(47, 44);
            this.broj2.TabIndex = 9;
            this.broj2.Validated += new System.EventHandler(this.broj_TextChanged);
            // 
            // broj3
            // 
            this.broj3.Location = new System.Drawing.Point(155, 3);
            this.broj3.MaxLength = 1;
            this.broj3.Multiline = true;
            this.broj3.Name = "broj3";
            this.broj3.Size = new System.Drawing.Size(47, 44);
            this.broj3.TabIndex = 10;
            this.broj3.Validated += new System.EventHandler(this.broj_TextChanged);
            // 
            // broj4
            // 
            this.broj4.Location = new System.Drawing.Point(3, 55);
            this.broj4.MaxLength = 1;
            this.broj4.Multiline = true;
            this.broj4.Name = "broj4";
            this.broj4.Size = new System.Drawing.Size(47, 44);
            this.broj4.TabIndex = 11;
            this.broj4.Validated += new System.EventHandler(this.broj_TextChanged);
            // 
            // broj5
            // 
            this.broj5.Location = new System.Drawing.Point(79, 55);
            this.broj5.MaxLength = 1;
            this.broj5.Multiline = true;
            this.broj5.Name = "broj5";
            this.broj5.Size = new System.Drawing.Size(47, 44);
            this.broj5.TabIndex = 12;
            this.broj5.Validated += new System.EventHandler(this.broj_TextChanged);
            // 
            // broj6
            // 
            this.broj6.Location = new System.Drawing.Point(155, 55);
            this.broj6.MaxLength = 1;
            this.broj6.Multiline = true;
            this.broj6.Name = "broj6";
            this.broj6.Size = new System.Drawing.Size(47, 44);
            this.broj6.TabIndex = 13;
            this.broj6.Validated += new System.EventHandler(this.broj_TextChanged);
            // 
            // broj7
            // 
            this.broj7.Location = new System.Drawing.Point(3, 107);
            this.broj7.MaxLength = 1;
            this.broj7.Multiline = true;
            this.broj7.Name = "broj7";
            this.broj7.Size = new System.Drawing.Size(47, 44);
            this.broj7.TabIndex = 14;
            this.broj7.Validated += new System.EventHandler(this.broj_TextChanged);
            // 
            // broj8
            // 
            this.broj8.Location = new System.Drawing.Point(79, 107);
            this.broj8.MaxLength = 1;
            this.broj8.Multiline = true;
            this.broj8.Name = "broj8";
            this.broj8.Size = new System.Drawing.Size(47, 44);
            this.broj8.TabIndex = 15;
            this.broj8.Validated += new System.EventHandler(this.broj_TextChanged);
            // 
            // broj9
            // 
            this.broj9.Location = new System.Drawing.Point(155, 107);
            this.broj9.MaxLength = 1;
            this.broj9.Multiline = true;
            this.broj9.Name = "broj9";
            this.broj9.Size = new System.Drawing.Size(47, 44);
            this.broj9.TabIndex = 16;
            this.broj9.Validated += new System.EventHandler(this.broj_TextChanged);
            // 
            // txtIIme
            // 
            this.txtIIme.Location = new System.Drawing.Point(389, 30);
            this.txtIIme.Name = "txtIIme";
            this.txtIIme.Size = new System.Drawing.Size(124, 22);
            this.txtIIme.TabIndex = 17;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(389, 84);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(124, 22);
            this.txtPrezime.TabIndex = 18;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel1.Controls.Add(this.broj5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.broj1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.broj2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.broj9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.broj3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.broj8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.broj4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.broj7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.broj6, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(358, 202);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(223, 156);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIIme);
            this.Controls.Add(this.btnPokreniIgru);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPokreniIgru;
        private System.Windows.Forms.TextBox broj1;
        private System.Windows.Forms.TextBox broj2;
        private System.Windows.Forms.TextBox broj3;
        private System.Windows.Forms.TextBox broj4;
        private System.Windows.Forms.TextBox broj5;
        private System.Windows.Forms.TextBox broj6;
        private System.Windows.Forms.TextBox broj7;
        private System.Windows.Forms.TextBox broj8;
        private System.Windows.Forms.TextBox broj9;
        private System.Windows.Forms.TextBox txtIIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

