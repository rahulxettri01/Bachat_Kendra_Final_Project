using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Filtering
    {
    public void filter(string tag)
    {
        var filterForIncomeList = Management_List.incomeList.Where(trans => trans.tag == tag).ToList();


        Management_List.incomeList.Clear();
        Management_List.incomeList.AddRange(filterForIncomeList);

        var filterForExpenditureList = Management_List.expenditureList.Where(trans => trans.tag == tag).ToList();


        Management_List.expenditureList.Clear();
        Management_List.expenditureList.AddRange(filterForExpenditureList);

        var filterForDebtList = Management_List.debtList.Where(trans => trans.tag == tag).ToList();


        Management_List.debtList.Clear();
        Management_List.debtList.AddRange(filterForDebtList);


    }
}

