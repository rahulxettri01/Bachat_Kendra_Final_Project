using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class debt
{

    public string type { get; set; }

    public int amount { get; set; }

    public string tag { get; set; }

    public string date { get; set; }

    public string description { get; set; }

    public string source { get; set; }

    public string status { get; set; }

    public string clearedAmount { get; set; }

    public debt(string type, int amount, string tag, string date, string description, string source, string status, string clearedAmount)
    {
        this.type = type;
        this.amount = amount;
        this.tag = tag;
        this.date = date;
        this.description = description;
        this.source = source;
        this.status = status;
        this.clearedAmount = clearedAmount;
    }

   

}

