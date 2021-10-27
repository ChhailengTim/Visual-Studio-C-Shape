
namespace Operator
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
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textStart = new System.Windows.Forms.TextBox();
            this.textStop = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.textResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(310, 79);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Time Start";
            // 
            // textStart
            // 
            this.textStart.Location = new System.Drawing.Point(163, 84);
            this.textStart.Name = "textStart";
            this.textStart.Size = new System.Drawing.Size(100, 20);
            this.textStart.TabIndex = 2;
            // 
            // textStop
            // 
            this.textStop.Location = new System.Drawing.Point(163, 130);
            this.textStop.Name = "textStop";
            this.textStop.Size = new System.Drawing.Size(100, 20);
            this.textStop.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Time Stop";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(310, 125);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // textResult
            // 
            this.textResult.Location = new System.Drawing.Point(143, 174);
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(257, 20);
            this.textResult.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Result-Used";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 328);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textStop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.textStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textStart;
        private System.Windows.Forms.TextBox textStop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.Label label3;
    }
}

