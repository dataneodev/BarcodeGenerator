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
        textBox1 = new System.Windows.Forms.TextBox();
        listBox1 = new System.Windows.Forms.ListBox();
        textBox2 = new System.Windows.Forms.TextBox();
        comboBox1 = new System.Windows.Forms.ComboBox();
        lbExport = new System.Windows.Forms.Label();
        textBox3 = new System.Windows.Forms.TextBox();
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
        // textBox1
        // 
        textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        textBox1.Location = new System.Drawing.Point(134, 5);
        textBox1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
        textBox1.Name = "textBox1";
        textBox1.ReadOnly = true;
        textBox1.Size = new System.Drawing.Size(394, 23);
        textBox1.TabIndex = 2;
        // 
        // listBox1
        // 
        listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        listBox1.FormattingEnabled = true;
        listBox1.Location = new System.Drawing.Point(243, 68);
        listBox1.Name = "listBox1";
        listBox1.Size = new System.Drawing.Size(285, 289);
        listBox1.TabIndex = 3;
        // 
        // textBox2
        // 
        textBox2.Location = new System.Drawing.Point(134, 93);
        textBox2.Name = "textBox2";
        textBox2.Size = new System.Drawing.Size(62, 23);
        textBox2.TabIndex = 4;
        textBox2.TextChanged += textBox2_TextChanged;
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
        lbExport.Click += label1_Click_1;
        // 
        // textBox3
        // 
        textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
        textBox3.Location = new System.Drawing.Point(134, 35);
        textBox3.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
        textBox3.Name = "textBox3";
        textBox3.ReadOnly = true;
        textBox3.Size = new System.Drawing.Size(394, 23);
        textBox3.TabIndex = 8;
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
        label1.Click += label1_Click_2;
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
        openFileDialog1.FileName = "";
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
        Controls.Add(textBox3);
        Controls.Add(btnExportFolder);
        Controls.Add(lbExport);
        Controls.Add(comboBox1);
        Controls.Add(textBox2);
        Controls.Add(listBox1);
        Controls.Add(textBox1);
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

    private System.Windows.Forms.TextBox textBox3;

    private System.Windows.Forms.Label lbCsvSeparator;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.TextBox textBox2;

    private System.Windows.Forms.Button openCsvFile;

    #endregion
}