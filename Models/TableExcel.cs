using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace BlazorAppExcel.Models;
public class TableExcel : EntityBase
{
    private string _tableName;
    public string Name {
        get
        {
            return _tableName;
        }
        set {
            this._tableName = value;
            this.CodeName = generateCodeName(value);
        } }

    public string CodeName { get; set; }
    public IList<RowExcel> Rows {get;set;} = new List<RowExcel>();
    public IDictionary<string,string> Columns {get;set;} = new Dictionary<string,string>();

    public string getColumn(string name) {
        try
        {
            if (this.Columns.ContainsKey(name))
                return this.Columns[name];
            return String.Empty;
        }
        catch (System.Exception)
        {          
            throw;
        }
    }
    public void setColumns(string column, int index)
    {
        this.Columns.Add($"Column{index + 1}", column);
    }

    private string generateCodeName(string value)
    {
        // Convert name to lowercase and remove extra spaces
        var name = value.ToLower().Trim();
        // Replace non-alphanumeric characters with space
        name = Regex.Replace(name, @"[^a-zA-Z0-9\s]", "");
        // Replace consecutive spaces with a single space
        name = Regex.Replace(name, @"\s+", " ");
        // Replace spaces with hyphens
        name = name.Replace(" ", "-");
        // Truncate the name to 15 characters
        name = name.Substring(0, Math.Min(name.Length, 15));
        // Remove trailing hyphens
        name = name.TrimEnd('-');
        return name;
    }
}
