namespace BlazorAppExcel.Models;
public class RowExcel {

    public RowExcel() {
        this.Values = new List<string>();
    }
    public IList<string> Values { get; set; }

    public void setValue(string item)
    {
        this.Values.Add(item);
    }
}