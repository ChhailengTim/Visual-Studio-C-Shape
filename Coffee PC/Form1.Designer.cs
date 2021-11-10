
namespace Coffee_PC
{
    partial class Form1
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
            this.PCnum = new System.Windows.Forms.Label();
            this.txtPCnum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtST = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTU = new System.Windows.Forms.TextBox();
            this.btnST = new System.Windows.Forms.Button();
            this.btnSP = new System.Windows.Forms.Button();
            this.btnRP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PCnum
            // 
            this.PCnum.AutoSize = true;
            this.PCnum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PCnum.Location = new System.Drawing.Point(22, 46);
            this.PCnum.Name = "PCnum";
            this.PCnum.Size = new System.Drawing.Size(91, 21);
            this.PCnum.TabIndex = 0;
            this.PCnum.Text = "PC Number";
            this.PCnum.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPCnum
            // 
            this.txtPCnum.Location = new System.Drawing.Point(119, 48);
            this.txtPCnum.Name = "txtPCnum";
            this.txtPCnum.Size = new System.Drawing.Size(179, 23);
            this.txtPCnum.TabIndex = 1;
            this.txtPCnum.TextChanged += new System.EventHandler(this.txtPCnum_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Time Start\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtST
            // 
            this.txtST.Location = new System.Drawing.Point(119, 101);
            this.txtST.Name = "txtST";
            this.txtST.Size = new System.Drawing.Size(179, 23);
            this.txtST.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 42);
            this.label2.TabIndex = 4;
            this.label2.Text = "Time Stop\r\n\r\n";
            // 
            // txtSP
            // 
            this.txtSP.Location = new System.Drawing.Point(119, 151);
            this.txtSP.Name = "txtSP";
            this.txtSP.Size = new System.Drawing.Size(179, 23);
            this.txtSP.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(22, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Time Uses";
            // 
            // txtTU
            // 
            this.txtTU.Location = new System.Drawing.Point(119, 195);
            this.txtTU.Name = "txtTU";
            this.txtTU.Size = new System.Drawing.Size(179, 23);
            this.txtTU.TabIndex = 7;
            // 
            // btnST
            // 
            this.btnST.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnST.Location = new System.Drawing.Point(337, 47);
            this.btnST.Name = "btnST";
            this.btnST.Size = new System.Drawing.Size(75, 23);
            this.btnST.TabIndex = 8;
            this.btnST.Text = "Start";
            this.btnST.UseVisualStyleBackColor = true;
            this.btnST.Click += new System.EventHandler(this.btnST_Click);
            // 
            // btnSP
            // 
            this.btnSP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSP.Location = new System.Drawing.Point(337, 99);
            this.btnSP.Name = "btnSP";
            this.btnSP.Size = new System.Drawing.Size(75, 23);
            this.btnSP.TabIndex = 9;
            this.btnSP.Text = "Stop";
            this.btnSP.UseVisualStyleBackColor = true;
            this.btnSP.Click += new System.EventHandler(this.btnSP_Click);
            // 
            // btnRP
            // 
            this.btnRP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRP.Location = new System.Drawing.Point(337, 149);
            this.btnRP.Name = "btnRP";
            this.btnRP.Size = new System.Drawing.Size(75, 23);
            this.btnRP.TabIndex = 10;
            this.btnRP.Text = "Report";
            this.btnRP.UseVisualStyleBackColor = true;
            this.btnRP.Click += new System.EventHandler(this.btnRP_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 391);
            this.Controls.Add(this.btnRP);
            this.Controls.Add(this.btnSP);
            this.Controls.Add(this.btnST);
            this.Controls.Add(this.txtTU);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtST);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPCnum);
            this.Controls.Add(this.PCnum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PCnum;
        private System.Windows.Forms.TextBox txtPCnum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtST;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTU;
        private System.Windows.Forms.Button btnST;
        private System.Windows.Forms.Button btnSP;
        private System.Windows.Forms.Button btnRP;
    }
}

