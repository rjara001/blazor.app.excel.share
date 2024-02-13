
using MongoDB.Bson.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace BlazorAppExcel.Models;

public class ExcelTableModel
{
    public ExcelTableModel() {}
    
    public ExcelTableModel(IList<string> columns, RowExcel row)
    {
        this.Name = row.Name;

        var _json = new Dictionary<string, string>();

        for (int i = 0; i < row.Values.Count; i++)
        {
            _json.Add(columns[i], row.Values[i]);
        }

    }
    public string Name { get; set; }

    //public string Json { get=> JsonSerializer.Serialize(_json); }
}