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
            this.openFileDialogExcelSheet = new System.Windows.Forms.OpenFileDialog();
            this.buttonOpenExcelFile = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonGeneratePDFReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialogExcelSheet
            // 
            this.openFileDialogExcelSheet.FileName = "openFileDialog1";
            this.openFileDialogExcelSheet.Filter = "Excel Files (*.xlsx;*.xlsm)|*.xlsx;*.xlsm|All Files (*.*)|*.*";
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
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(604, 484);
            this.dataGridView1.TabIndex = 1;
            // 
            // buttonGeneratePDFReport
            // 
            this.buttonGeneratePDFReport.Location = new System.Drawing.Point(206, 30);
            this.buttonGeneratePDFReport.Name = "buttonGeneratePDFReport";
            this.buttonGeneratePDFReport.Size = new System.Drawing.Size(148, 41);
            this.buttonGeneratePDFReport.TabIndex = 2;
            this.buttonGeneratePDFReport.Text = "Generate PDF report";
            this.buttonGeneratePDFReport.UseVisualStyleBackColor = true;
            this.buttonGeneratePDFReport.Click += new System.EventHandler(this.buttonGeneratePDFReportClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 634);
            this.Controls.Add(this.buttonGeneratePDFReport);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonOpenExcelFile);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialogExcelSheet;
        private System.Windows.Forms.Button buttonOpenExcelFile;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonGeneratePDFReport;
    }
}

