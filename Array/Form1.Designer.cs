
namespace Array
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
            this.label1 = new System.Windows.Forms.Label();
            this.textRoomID = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.bntSearch = new System.Windows.Forms.Button();
            this.textRoomType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.textRoomPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textStatus = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room ID";
            // 
            // textRoomID
            // 
            this.textRoomID.Location = new System.Drawing.Point(128, 50);
            this.textRoomID.Name = "textRoomID";
            this.textRoomID.Size = new System.Drawing.Size(228, 23);
            this.textRoomID.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(388, 50);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // bntSearch
            // 
            this.bntSearch.Location = new System.Drawing.Point(388, 88);
            this.bntSearch.Name = "bntSearch";
            this.bntSearch.Size = new System.Drawing.Size(75, 23);
            this.bntSearch.TabIndex = 5;
            this.bntSearch.Text = "Search";
            this.bntSearch.UseVisualStyleBackColor = true;
            this.bntSearch.Click += new System.EventHandler(this.bntSearch_Click);
            // 
            // textRoomType
            // 
            this.textRoomType.Location = new System.Drawing.Point(128, 88);
            this.textRoomType.Name = "textRoomType";
            this.textRoomType.Size = new System.Drawing.Size(228, 23);
            this.textRoomType.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Room Type";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(388, 126);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // textRoomPrice
            // 
            this.textRoomPrice.Location = new System.Drawing.Point(128, 126);
            this.textRoomPrice.Name = "textRoomPrice";
            this.textRoomPrice.Size = new System.Drawing.Size(228, 23);
            this.textRoomPrice.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Room Price";
            // 
            // textStatus
            // 
            this.textStatus.Location = new System.Drawing.Point(128, 165);
            this.textStatus.Name = "textStatus";
            this.textStatus.Size = new System.Drawing.Size(228, 23);
            this.textStatus.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 382);
            this.Controls.Add(this.textStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.textRoomPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bntSearch);
            this.Controls.Add(this.textRoomType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textRoomID);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textRoomID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button bntSearch;
        private System.Windows.Forms.TextBox textRoomType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox textRoomPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textStatus;
        private System.Windows.Forms.Label label4;
    }
}

