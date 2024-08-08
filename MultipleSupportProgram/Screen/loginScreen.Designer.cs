namespace MultipleSupportProgram.Screen
{
    partial class loginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblpasswordBaseNumber = new System.Windows.Forms.Label();
            this.btnKodKopyala = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(91, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lütfen uygulama giriş kodunu giriniz";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.tbPassword, 2);
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbPassword.Location = new System.Drawing.Point(91, 184);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = 'X';
            this.tbPassword.Size = new System.Drawing.Size(170, 22);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGirisYap
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnGirisYap, 2);
            this.btnGirisYap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGirisYap.Location = new System.Drawing.Point(91, 237);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(170, 72);
            this.btnGirisYap.TabIndex = 2;
            this.btnGirisYap.Text = "Giriş";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.BtnGirisYap_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbPassword, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnGirisYap, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblpasswordBaseNumber, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnKodKopyala, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(354, 312);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // lblpasswordBaseNumber
            // 
            this.lblpasswordBaseNumber.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblpasswordBaseNumber, 2);
            this.lblpasswordBaseNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblpasswordBaseNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblpasswordBaseNumber.Location = new System.Drawing.Point(91, 78);
            this.lblpasswordBaseNumber.Name = "lblpasswordBaseNumber";
            this.lblpasswordBaseNumber.Size = new System.Drawing.Size(170, 78);
            this.lblpasswordBaseNumber.TabIndex = 3;
            this.lblpasswordBaseNumber.Text = "12345";
            this.lblpasswordBaseNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnKodKopyala
            // 
            this.btnKodKopyala.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKodKopyala.Location = new System.Drawing.Point(267, 81);
            this.btnKodKopyala.Name = "btnKodKopyala";
            this.btnKodKopyala.Size = new System.Drawing.Size(84, 72);
            this.btnKodKopyala.TabIndex = 4;
            this.btnKodKopyala.Text = "Kodu Kopyala";
            this.btnKodKopyala.UseVisualStyleBackColor = true;
            this.btnKodKopyala.Click += new System.EventHandler(this.btnKodKopyala_Click);
            // 
            // loginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 312);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "loginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ESİT SPWin Teknik Servis Giriş";
            this.Load += new System.EventHandler(this.loginScreen_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblpasswordBaseNumber;
        private System.Windows.Forms.Button btnKodKopyala;
    }
}