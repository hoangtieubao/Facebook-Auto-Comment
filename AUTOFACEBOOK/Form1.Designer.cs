namespace AUTOFACEBOOK
{
    partial class frmMAIN
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
            this.txtUSERNAME = new System.Windows.Forms.TextBox();
            this.txtPASSWORD = new System.Windows.Forms.TextBox();
            this.btnTOKEN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstLCOM = new System.Windows.Forms.ListBox();
            this.btnACOM = new System.Windows.Forms.Button();
            this.btnDCOM = new System.Windows.Forms.Button();
            this.lstLPOST = new System.Windows.Forms.ListBox();
            this.btnAPOST = new System.Windows.Forms.Button();
            this.btnDPOST = new System.Windows.Forms.Button();
            this.btnRUN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÊN TÀI KHOẢN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "MẬT KHẨU";
            // 
            // txtUSERNAME
            // 
            this.txtUSERNAME.Location = new System.Drawing.Point(204, 39);
            this.txtUSERNAME.Name = "txtUSERNAME";
            this.txtUSERNAME.Size = new System.Drawing.Size(287, 26);
            this.txtUSERNAME.TabIndex = 2;
            // 
            // txtPASSWORD
            // 
            this.txtPASSWORD.Location = new System.Drawing.Point(204, 72);
            this.txtPASSWORD.Name = "txtPASSWORD";
            this.txtPASSWORD.Size = new System.Drawing.Size(287, 26);
            this.txtPASSWORD.TabIndex = 3;
            this.txtPASSWORD.UseSystemPasswordChar = true;
            // 
            // btnTOKEN
            // 
            this.btnTOKEN.Location = new System.Drawing.Point(516, 26);
            this.btnTOKEN.Name = "btnTOKEN";
            this.btnTOKEN.Size = new System.Drawing.Size(96, 86);
            this.btnTOKEN.TabIndex = 4;
            this.btnTOKEN.Text = "ĐĂNG NHẬP";
            this.btnTOKEN.UseVisualStyleBackColor = true;
            this.btnTOKEN.Click += new System.EventHandler(this.btnTOKEN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "DANH SÁCH LINK BÀI VIẾT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(436, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "DANH SÁCH NỘI DUNG COMMENT";
            // 
            // lstLCOM
            // 
            this.lstLCOM.FormattingEnabled = true;
            this.lstLCOM.ItemHeight = 20;
            this.lstLCOM.Location = new System.Drawing.Point(440, 175);
            this.lstLCOM.Name = "lstLCOM";
            this.lstLCOM.Size = new System.Drawing.Size(341, 184);
            this.lstLCOM.TabIndex = 7;
            // 
            // btnACOM
            // 
            this.btnACOM.Enabled = false;
            this.btnACOM.Location = new System.Drawing.Point(489, 375);
            this.btnACOM.Name = "btnACOM";
            this.btnACOM.Size = new System.Drawing.Size(95, 35);
            this.btnACOM.TabIndex = 8;
            this.btnACOM.Text = "THÊM";
            this.btnACOM.UseVisualStyleBackColor = true;
            // 
            // btnDCOM
            // 
            this.btnDCOM.Enabled = false;
            this.btnDCOM.Location = new System.Drawing.Point(643, 375);
            this.btnDCOM.Name = "btnDCOM";
            this.btnDCOM.Size = new System.Drawing.Size(99, 35);
            this.btnDCOM.TabIndex = 9;
            this.btnDCOM.Text = "XÓA";
            this.btnDCOM.UseVisualStyleBackColor = true;
            // 
            // lstLPOST
            // 
            this.lstLPOST.FormattingEnabled = true;
            this.lstLPOST.ItemHeight = 20;
            this.lstLPOST.Location = new System.Drawing.Point(41, 175);
            this.lstLPOST.Name = "lstLPOST";
            this.lstLPOST.Size = new System.Drawing.Size(344, 184);
            this.lstLPOST.TabIndex = 11;
            // 
            // btnAPOST
            // 
            this.btnAPOST.Enabled = false;
            this.btnAPOST.Location = new System.Drawing.Point(81, 375);
            this.btnAPOST.Name = "btnAPOST";
            this.btnAPOST.Size = new System.Drawing.Size(102, 35);
            this.btnAPOST.TabIndex = 12;
            this.btnAPOST.Text = "THÊM";
            this.btnAPOST.UseVisualStyleBackColor = true;
            // 
            // btnDPOST
            // 
            this.btnDPOST.Enabled = false;
            this.btnDPOST.Location = new System.Drawing.Point(240, 375);
            this.btnDPOST.Name = "btnDPOST";
            this.btnDPOST.Size = new System.Drawing.Size(102, 35);
            this.btnDPOST.TabIndex = 13;
            this.btnDPOST.Text = "XÓA";
            this.btnDPOST.UseVisualStyleBackColor = true;
            // 
            // btnRUN
            // 
            this.btnRUN.Enabled = false;
            this.btnRUN.Location = new System.Drawing.Point(643, 26);
            this.btnRUN.Name = "btnRUN";
            this.btnRUN.Size = new System.Drawing.Size(99, 86);
            this.btnRUN.TabIndex = 14;
            this.btnRUN.Text = "BẮT ĐẦU COMMENT";
            this.btnRUN.UseVisualStyleBackColor = true;
            // 
            // frmMAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 441);
            this.Controls.Add(this.btnRUN);
            this.Controls.Add(this.btnDPOST);
            this.Controls.Add(this.btnAPOST);
            this.Controls.Add(this.lstLPOST);
            this.Controls.Add(this.btnDCOM);
            this.Controls.Add(this.btnACOM);
            this.Controls.Add(this.lstLCOM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTOKEN);
            this.Controls.Add(this.txtPASSWORD);
            this.Controls.Add(this.txtUSERNAME);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmMAIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AUTO COMMENT FACEBOOK - HOÀNG SOLUTIONS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUSERNAME;
        private System.Windows.Forms.TextBox txtPASSWORD;
        private System.Windows.Forms.Button btnTOKEN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstLCOM;
        private System.Windows.Forms.Button btnACOM;
        private System.Windows.Forms.Button btnDCOM;
        private System.Windows.Forms.ListBox lstLPOST;
        private System.Windows.Forms.Button btnAPOST;
        private System.Windows.Forms.Button btnDPOST;
        private System.Windows.Forms.Button btnRUN;
    }
}

