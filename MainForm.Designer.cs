namespace BarcodeGenerator;

partial class MainForm
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        openCsvFile = new System.Windows.Forms.Button();
        lbCsvSeparator = new System.Windows.Forms.Label();
        tbCSVFilePath = new System.Windows.Forms.TextBox();
        lbBarcodes = new System.Windows.Forms.ListBox();
        tbCsvSeparator = new System.Windows.Forms.TextBox();
        comboBox1 = new System.Windows.Forms.ComboBox();
        lbExport = new System.Windows.Forms.Label();
        tbExportDirectory = new System.Windows.Forms.TextBox();
        btnExportFolder = new System.Windows.Forms.Button();
        label1 = new System.Windows.Forms.Label();
        btnExport = new System.Windows.Forms.Button();
        openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
        SuspendLayout();
        // 
        // openCsvFile
        // 
        openCsvFile.Location = new System.Drawing.Point(3, 5);
        openCsvFile.Name = "openCsvFile";
        openCsvFile.Size = new System.Drawing.Size(125, 23);
        openCsvFile.TabIndex = 0;
        openCsvFile.Text = "Otwórz plik csv";
        openCsvFile.UseVisualStyleBackColor = true;
        openCsvFile.Click += openCsvFile_Click;
        // 
        // lbCsvSeparator
        // 
        lbCsvSeparator.Location = new System.Drawing.Point(3, 94);
        lbCsvSeparator.Name = "lbCsvSeparator";
        lbCsvSeparator.Size = new System.Drawing.Size(85, 23);
        lbCsvSeparator.TabIndex = 1;
        lbCsvSeparator.Text = "Separator csv:";
        lbCsvSeparator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // tbCSVFilePath
        // 
        tbCSVFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        tbCSVFilePath.Location = new System.Drawing.Point(134, 5);
        tbCSVFilePath.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
        tbCSVFilePath.Name = "tbCSVFilePath";
        tbCSVFilePath.ReadOnly = true;
        tbCSVFilePath.Size = new System.Drawing.Size(394, 23);
        tbCSVFilePath.TabIndex = 2;
        // 
        // lbBarcodes
        // 
        lbBarcodes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        lbBarcodes.FormattingEnabled = true;
        lbBarcodes.Location = new System.Drawing.Point(243, 68);
        lbBarcodes.Name = "lbBarcodes";
        lbBarcodes.Size = new System.Drawing.Size(285, 289);
        lbBarcodes.TabIndex = 3;
        // 
        // tbCsvSeparator
        // 
        tbCsvSeparator.Location = new System.Drawing.Point(134, 93);
        tbCsvSeparator.Name = "tbCsvSeparator";
        tbCsvSeparator.Size = new System.Drawing.Size(62, 23);
        tbCsvSeparator.TabIndex = 4;
        tbCsvSeparator.Text = ",";
        // 
        // comboBox1
        // 
        comboBox1.FormattingEnabled = true;
        comboBox1.Location = new System.Drawing.Point(134, 123);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new System.Drawing.Size(103, 23);
        comboBox1.TabIndex = 5;
        // 
        // lbExport
        // 
        lbExport.Location = new System.Drawing.Point(3, 123);
        lbExport.Name = "lbExport";
        lbExport.Size = new System.Drawing.Size(104, 23);
        lbExport.TabIndex = 6;
        lbExport.Text = "Format exportu:";
        lbExport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // tbExportDirectory
        // 
        tbExportDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        tbExportDirectory.Location = new System.Drawing.Point(134, 35);
        tbExportDirectory.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
        tbExportDirectory.Name = "tbExportDirectory";
        tbExportDirectory.ReadOnly = true;
        tbExportDirectory.Size = new System.Drawing.Size(394, 23);
        tbExportDirectory.TabIndex = 8;
        // 
        // btnExportFolder
        // 
        btnExportFolder.Location = new System.Drawing.Point(134, 64);
        btnExportFolder.Name = "btnExportFolder";
        btnExportFolder.Size = new System.Drawing.Size(62, 23);
        btnExportFolder.TabIndex = 7;
        btnExportFolder.Text = "Zmień";
        btnExportFolder.UseVisualStyleBackColor = true;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(3, 35);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(122, 23);
        label1.TabIndex = 9;
        label1.Text = "Folder exportu:";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // btnExport
        // 
        btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left));
        btnExport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        btnExport.Location = new System.Drawing.Point(3, 320);
        btnExport.Name = "btnExport";
        btnExport.Size = new System.Drawing.Size(234, 37);
        btnExport.TabIndex = 10;
        btnExport.Text = "Exportuj";
        btnExport.UseVisualStyleBackColor = true;
        // 
        // openFileDialog1
        // 
        openFileDialog1.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
        openFileDialog1.Title = "Wybierz plik CSV";
        // 
        // MainForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(535, 363);
        Controls.Add(btnExport);
        Controls.Add(label1);
        Controls.Add(tbExportDirectory);
        Controls.Add(btnExportFolder);
        Controls.Add(lbExport);
        Controls.Add(comboBox1);
        Controls.Add(tbCsvSeparator);
        Controls.Add(lbBarcodes);
        Controls.Add(tbCSVFilePath);
        Controls.Add(lbCsvSeparator);
        Controls.Add(openCsvFile);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "BarcodeGenerator";
        TopMost = true;
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.OpenFileDialog openFileDialog1;

    private System.Windows.Forms.Button btnExportFolder;

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.Button btnExport;
    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Label lbExport;

    private System.Windows.Forms.ComboBox comboBox1;

    private System.Windows.Forms.TextBox tbExportDirectory;

    private System.Windows.Forms.Label lbCsvSeparator;
    private System.Windows.Forms.TextBox tbCSVFilePath;
    private System.Windows.Forms.ListBox lbBarcodes;
    private System.Windows.Forms.TextBox tbCsvSeparator;

    private System.Windows.Forms.Button openCsvFile;

    #endregion
}