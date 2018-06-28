namespace ShopByEntity
{
    partial class report
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
            this.SMSDataSet = new ShopByEntity.SMSDataSet();
            this.CustomerDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CustomerDetailsTableAdapter = new ShopByEntity.SMSDataSetTableAdapters.CustomerDetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.CustomerDetailsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ShopByEntity.CustomerReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(984, 274);
            this.reportViewer1.TabIndex = 0;
            // 
            // SMSDataSet
            // 
            this.SMSDataSet.DataSetName = "SMSDataSet";
            this.SMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CustomerDetailsBindingSource
            // 
            this.CustomerDetailsBindingSource.DataMember = "CustomerDetails";
            this.CustomerDetailsBindingSource.DataSource = this.SMSDataSet;
            // 
            // CustomerDetailsTableAdapter
            // 
            this.CustomerDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 274);
            this.Controls.Add(this.reportViewer1);
            this.Name = "report";
            this.Text = "report";
            this.Load += new System.EventHandler(this.report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CustomerDetailsBindingSource;
        private SMSDataSet SMSDataSet;
        private SMSDataSetTableAdapters.CustomerDetailsTableAdapter CustomerDetailsTableAdapter;
    }
}