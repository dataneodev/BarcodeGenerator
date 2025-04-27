namespace BarcodeGenerator;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }


    private void openCsvFile_Click(object sender, EventArgs e)
    {
        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        {
            var csvParser = new CSVParser();

            try
            {
                var result = csvParser.Get(openFileDialog1.FileName,
                    string.IsNullOrWhiteSpace(tbCsvSeparator.Text) ? null : tbCsvSeparator.Text[0]);
                tbCSVFilePath.Text = result.FilePath;
                tbExportDirectory.Text = result.ExportDirPath;
                lbBarcodes.Items.Clear();
                lbBarcodes.Items.Add(result.Barcodes);
            }
            catch (Exception ex)
            {
                lbBarcodes.Items.Clear();
                tbCSVFilePath.Text = "";
                tbExportDirectory.Text = "";
            }
        }
    }
}