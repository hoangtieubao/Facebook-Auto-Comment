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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstLCOM = new System.Windows.Forms.ListBox();
            this.btnACOM = new System.Windows.Forms.Button();
            this.btnDCOM = new System.Windows.Forms.Button();
            this.lstLACC = new System.Windows.Forms.ListBox();
            this.btnAACC = new System.Windows.Forms.Button();
            this.btnDACC = new System.Windows.Forms.Button();
            this.lstLPOST = new System.Windows.Forms.ListBox();
            this.btnDPOST = new System.Windows.Forms.Button();
            this.btnAPOST = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRUN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "TÀI KHOẢN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(766, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "NỘI DUNG COMMENT";
            // 
            // lstLCOM
            // 
            this.lstLCOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLCOM.FormattingEnabled = true;
            this.lstLCOM.ItemHeight = 16;
            this.lstLCOM.Location = new System.Drawing.Point(770, 44);
            this.lstLCOM.Name = "lstLCOM";
            this.lstLCOM.Size = new System.Drawing.Size(315, 436);
            this.lstLCOM.TabIndex = 7;
            // 
            // btnACOM
            // 
            this.btnACOM.Location = new System.Drawing.Point(945, 12);
            this.btnACOM.Name = "btnACOM";
            this.btnACOM.Size = new System.Drawing.Size(67, 26);
            this.btnACOM.TabIndex = 8;
            this.btnACOM.Text = "THÊM";
            this.btnACOM.UseVisualStyleBackColor = true;
            this.btnACOM.Click += new System.EventHandler(this.btnACOM_Click);
            // 
            // btnDCOM
            // 
            this.btnDCOM.Location = new System.Drawing.Point(1018, 12);
            this.btnDCOM.Name = "btnDCOM";
            this.btnDCOM.Size = new System.Drawing.Size(67, 26);
            this.btnDCOM.TabIndex = 9;
            this.btnDCOM.Text = "XÓA";
            this.btnDCOM.UseVisualStyleBackColor = true;
            this.btnDCOM.Click += new System.EventHandler(this.btnDCOM_Click);
            // 
            // lstLACC
            // 
            this.lstLACC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLACC.FormattingEnabled = true;
            this.lstLACC.ItemHeight = 16;
            this.lstLACC.Location = new System.Drawing.Point(25, 44);
            this.lstLACC.Name = "lstLACC";
            this.lstLACC.Size = new System.Drawing.Size(306, 436);
            this.lstLACC.TabIndex = 11;
            this.lstLACC.SelectedValueChanged += new System.EventHandler(this.lstLACC_SelectedValueChanged);
            this.lstLACC.DoubleClick += new System.EventHandler(this.lstLACC_DoubleClick);
            // 
            // btnAACC
            // 
            this.btnAACC.Location = new System.Drawing.Point(191, 12);
            this.btnAACC.Name = "btnAACC";
            this.btnAACC.Size = new System.Drawing.Size(67, 26);
            this.btnAACC.TabIndex = 12;
            this.btnAACC.Text = "THÊM";
            this.btnAACC.UseVisualStyleBackColor = true;
            this.btnAACC.Click += new System.EventHandler(this.btnAACC_Click);
            // 
            // btnDACC
            // 
            this.btnDACC.Location = new System.Drawing.Point(264, 12);
            this.btnDACC.Name = "btnDACC";
            this.btnDACC.Size = new System.Drawing.Size(67, 26);
            this.btnDACC.TabIndex = 13;
            this.btnDACC.Text = "XÓA";
            this.btnDACC.UseVisualStyleBackColor = true;
            this.btnDACC.Click += new System.EventHandler(this.btnDACC_Click);
            // 
            // lstLPOST
            // 
            this.lstLPOST.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLPOST.FormattingEnabled = true;
            this.lstLPOST.ItemHeight = 16;
            this.lstLPOST.Location = new System.Drawing.Point(349, 44);
            this.lstLPOST.Name = "lstLPOST";
            this.lstLPOST.Size = new System.Drawing.Size(405, 436);
            this.lstLPOST.TabIndex = 15;
            this.lstLPOST.DoubleClick += new System.EventHandler(this.lstLPOST_DoubleClick);
            // 
            // btnDPOST
            // 
            this.btnDPOST.Location = new System.Drawing.Point(687, 12);
            this.btnDPOST.Name = "btnDPOST";
            this.btnDPOST.Size = new System.Drawing.Size(67, 26);
            this.btnDPOST.TabIndex = 17;
            this.btnDPOST.Text = "XÓA";
            this.btnDPOST.UseVisualStyleBackColor = true;
            this.btnDPOST.Click += new System.EventHandler(this.btnDPOST_Click);
            // 
            // btnAPOST
            // 
            this.btnAPOST.Location = new System.Drawing.Point(614, 12);
            this.btnAPOST.Name = "btnAPOST";
            this.btnAPOST.Size = new System.Drawing.Size(67, 26);
            this.btnAPOST.TabIndex = 16;
            this.btnAPOST.Text = "THÊM";
            this.btnAPOST.UseVisualStyleBackColor = true;
            this.btnAPOST.Click += new System.EventHandler(this.btnAPOST_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "BÀI VIẾT";
            // 
            // btnRUN
            // 
            this.btnRUN.Location = new System.Drawing.Point(25, 494);
            this.btnRUN.Name = "btnRUN";
            this.btnRUN.Size = new System.Drawing.Size(1060, 34);
            this.btnRUN.TabIndex = 19;
            this.btnRUN.Text = "RUN AUTO COMMENT";
            this.btnRUN.UseVisualStyleBackColor = true;
            this.btnRUN.Click += new System.EventHandler(this.btnRUN_Click);
            // 
            // frmMAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 548);
            this.Controls.Add(this.btnRUN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDPOST);
            this.Controls.Add(this.btnAPOST);
            this.Controls.Add(this.lstLPOST);
            this.Controls.Add(this.btnDACC);
            this.Controls.Add(this.btnAACC);
            this.Controls.Add(this.lstLACC);
            this.Controls.Add(this.btnDCOM);
            this.Controls.Add(this.btnACOM);
            this.Controls.Add(this.lstLCOM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmMAIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AUTO COMMENT FACEBOOK - HOÀNG SOLUTIONS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMAIN_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMAIN_FormClosed);
            this.Load += new System.EventHandler(this.frmMAIN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstLCOM;
        private System.Windows.Forms.Button btnACOM;
        private System.Windows.Forms.Button btnDCOM;
        private System.Windows.Forms.ListBox lstLACC;
        private System.Windows.Forms.Button btnAACC;
        private System.Windows.Forms.Button btnDACC;
        private System.Windows.Forms.ListBox lstLPOST;
        private System.Windows.Forms.Button btnDPOST;
        private System.Windows.Forms.Button btnAPOST;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRUN;
    }
}

