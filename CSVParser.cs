namespace BarcodeGenerator;

public sealed class CSVParser
{
    public sealed record CSVParserResult(string FilePath, string ExportDirPath, string[] Barcodes);


    public CSVParserResult Get(string filePath, char? separator)
    {
        if (!File.Exists(filePath))
            throw new Exception("Plik csv nie istnieje!");

        var rows = File.ReadAllLines(filePath);

        var barcodes = rows.SelectMany(s => s.Split(separator ?? ',').Where(w => !string.IsNullOrWhiteSpace(w)))
            .ToArray();
        var dir = Path.Combine(Path.GetDirectoryName(filePath), "barcodes");

        return new CSVParserResult(
            filePath, dir, barcodes);
    }
}