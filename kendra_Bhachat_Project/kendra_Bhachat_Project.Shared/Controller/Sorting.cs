using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Sorting
{
    public void Sort()
    {
        if (Management_List.incomeList != null && Management_List.incomeList.Count > 1)
        {
            for (int i = 0; i < Management_List.incomeList.Count - 1; i++)
            {
                for (int j = 0; j < Management_List.incomeList.Count - i - 1; j++)
                {
                    if (Management_List.incomeList[j].amount > Management_List.incomeList[j + 1].amount)
                    {
                        var temp = Management_List.incomeList[j];
                        Management_List.incomeList[j] = Management_List.incomeList[j + 1];
                        Management_List.incomeList[j + 1] = temp;
                    }
                }
            }
        }


        if (Management_List.expenditureList != null && Management_List.expenditureList.Count > 1)
        {
            for (int i = 0; i < Management_List.expenditureList.Count - 1; i++)
            {
                for (int j = 0; j < Management_List.expenditureList.Count - i - 1; j++)
                {
                    if (Management_List.expenditureList[j].amount > Management_List.expenditureList[j + 1].amount)
                    {
                        var temp = Management_List.expenditureList[j];
                        Management_List.expenditureList[j] = Management_List.expenditureList[j + 1];
                        Management_List.expenditureList[j + 1] = temp;
                    }
                }
            }
        }

        if (Management_List.debtList != null && Management_List.debtList.Count > 1)
        {
            for (int i = 0; i < Management_List.debtList.Count - 1; i++)
            {
                for (int j = 0; j < Management_List.debtList.Count - i - 1; j++)
                {
                    if (Management_List.debtList[j].amount > Management_List.debtList[j + 1].amount)
                    {
                        var temp = Management_List.debtList[j];
                        Management_List.debtList[j] = Management_List.debtList[j + 1];
                        Management_List.debtList[j + 1] = temp;
                    }
                }
            }
        }
    }
}
