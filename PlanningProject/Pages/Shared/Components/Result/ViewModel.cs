public class ResultViewModel
{
    public List<ResultItem> Result{ get; set; }
    public bool ShowOkButton { get; set; } = true;
}

public class ResultItem
{
    public string Name { get; set; }
    public double Average { get; set; }
}