using System;
using System.Linq;

public class Searching
{
    public void Search(string source)
    {
        // Check if income list is not null
        if (Management_List.incomeList != null)
        {
            var filteredIncomeList = Management_List.incomeList
                .Where(income => !string.IsNullOrEmpty(income.source) &&
                                 income.source.Contains(source, StringComparison.OrdinalIgnoreCase))
                .ToList();

            Management_List.incomeList.Clear();
            Management_List.incomeList.AddRange(filteredIncomeList);
        }

        // Check if expenditure list is not null
        if (Management_List.expenditureList != null)
        {
            var filteredExpenditureList = Management_List.expenditureList
                .Where(expenditure => !string.IsNullOrEmpty(expenditure.source) &&
                                      expenditure.source.Contains(source, StringComparison.OrdinalIgnoreCase))
                .ToList();

            Management_List.expenditureList.Clear();
            Management_List.expenditureList.AddRange(filteredExpenditureList);
        }

        // Check if debt list is not null
        if (Management_List.debtList != null)
        {
            var filteredDebtList = Management_List.debtList
                .Where(debt => !string.IsNullOrEmpty(debt.source) &&
                               debt.source.Contains(source, StringComparison.OrdinalIgnoreCase))
                .ToList();

            Management_List.debtList.Clear();
            Management_List.debtList.AddRange(filteredDebtList);
        }
    }
}
