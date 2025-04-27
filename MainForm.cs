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
            string filePath = openFileDialog1.FileName;
            string[] lines = File.ReadAllLines(filePath);

            // Przykład: wyświetlenie zawartości w MessageBox
            MessageBox.Show(string.Join(Environment.NewLine, lines), "Zawartość pliku CSV");

            // Możesz teraz użyć tablicy 'lines' w dalszej części programu
        }
    }
}