using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Management_List
{
    public static List<tranxson> transactionList { get; set; } = new List<tranxson>();
    public static List<incomes> incomeList { get; set; } = new List<incomes>();
    public static List<expenditure> expenditureList { get; set; } = new List<expenditure>();
    public static List<debt> debtList { get; set; }= new List<debt>();
    public static List<tg> tgs { get; set; } = new List<tg>();
    public static Users User { get; set; } = new Users();
}

