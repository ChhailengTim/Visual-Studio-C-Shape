﻿namespace show25
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.LibraryDataSet = new show25.LibraryDataSet();
            this.TblStaffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TblStaffTableAdapter = new show25.LibraryDataSetTableAdapters.TblStaffTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.LibraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblStaffBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TblStaffBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "show25.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(810, 615);
            this.reportViewer1.TabIndex = 0;
            // 
            // LibraryDataSet
            // 
            this.LibraryDataSet.DataSetName = "LibraryDataSet";
            this.LibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TblStaffBindingSource
            // 
            this.TblStaffBindingSource.DataMember = "TblStaff";
            this.TblStaffBindingSource.DataSource = this.LibraryDataSet;
            // 
            // TblStaffTableAdapter
            // 
            this.TblStaffTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 615);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LibraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TblStaffBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TblStaffBindingSource;
        private LibraryDataSet LibraryDataSet;
        private LibraryDataSetTableAdapters.TblStaffTableAdapter TblStaffTableAdapter;
    }
}