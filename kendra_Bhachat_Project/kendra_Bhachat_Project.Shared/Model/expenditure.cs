using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class expenditure
{
    public int amount { get; set; }

    public string tag { get; set; }

    public string date { get; set; }

    public string description { get; set; }

    public string source { get; set; }

    public expenditure(int amount, string tag, string date, string description, string source)
    {


        this.amount = amount;

        this.tag = tag;

        this.date = date;

        this.description = description;

        this.source = source;


    }

}

