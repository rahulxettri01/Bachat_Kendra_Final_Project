using System;

public class tranxson
{
    public string Title { get; set; }
    public string Source { get; set; }
    public string Type { get; set; }
    public int Amount { get; set; }
    public string Tag { get; set; }
    public DateOnly Date { get; set; }
    public DateOnly DueDate { get; set; }
    public string Note { get; set; }
    public string Status { get; set; }
    public string ClearedAmount { get; set; }
    // Constructor
    public tranxson(string title, string source, string type, int amount, string tag, DateOnly date, DateOnly dueDate, string note, string status, string clearedAmount)
    {
        Title = title;
        Source = source;
        Type = type;
        Amount = amount;
        Tag = tag;
        Date = date;
        DueDate = dueDate;
        Note = note;
        Status = status;
        ClearedAmount = clearedAmount;
    }
}
