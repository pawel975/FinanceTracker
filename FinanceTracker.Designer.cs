using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace FinanceTracker
{
    partial class FinanceTracker
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
            this.buttonOpenExcelFile = new System.Windows.Forms.Button();
            this.buttonGeneratePDFReport = new System.Windows.Forms.Button();
            this.openFileDialogExcelSheet = new System.Windows.Forms.OpenFileDialog();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonOpenExcelFile
            // 
            this.buttonOpenExcelFile.Location = new System.Drawing.Point(28, 30);
            this.buttonOpenExcelFile.Name = "buttonOpenExcelFile";
            this.buttonOpenExcelFile.Size = new System.Drawing.Size(148, 41);
            this.buttonOpenExcelFile.TabIndex = 0;
            this.buttonOpenExcelFile.Text = "Open Excel File";
            this.buttonOpenExcelFile.UseVisualStyleBackColor = true;
            this.buttonOpenExcelFile.Click += new System.EventHandler(this.buttonOpenExcelFileClick);
            // 
            // buttonGeneratePDFReport
            // 
            this.buttonGeneratePDFReport.Location = new System.Drawing.Point(28, 96);
            this.buttonGeneratePDFReport.Name = "buttonGeneratePDFReport";
            this.buttonGeneratePDFReport.Size = new System.Drawing.Size(148, 41);
            this.buttonGeneratePDFReport.TabIndex = 2;
            this.buttonGeneratePDFReport.Text = "Generate PDF report";
            this.buttonGeneratePDFReport.UseVisualStyleBackColor = true;
            this.buttonGeneratePDFReport.Click += new System.EventHandler(this.buttonGeneratePDFReportClick);
            // 
            // openFileDialogExcelSheet
            // 
            this.openFileDialogExcelSheet.FileName = "openFileDialog1";
            this.openFileDialogExcelSheet.Filter = "Excel Files (*.xlsx;*.xlsm)|*.xlsx;*.xlsm|All Files (*.*)|*.*";
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(207, 39);
            this.textBoxFileName.Multiline = true;
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.ReadOnly = true;
            this.textBoxFileName.Size = new System.Drawing.Size(427, 25);
            this.textBoxFileName.TabIndex = 3;
            this.textBoxFileName.Text = "No file name provided...";
            // 
            // FinanceTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 634);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.buttonGeneratePDFReport);
            this.Controls.Add(this.buttonOpenExcelFile);
            this.Name = "FinanceTracker";
            this.Text = "Finance Tracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonOpenExcelFile;
        private System.Windows.Forms.Button buttonGeneratePDFReport;
        private System.Windows.Forms.OpenFileDialog openFileDialogExcelSheet;
        private System.Windows.Forms.TextBox textBoxFileName;
    }
}

