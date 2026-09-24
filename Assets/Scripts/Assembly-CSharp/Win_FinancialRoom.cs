public class Win_FinancialRoom : global::Common.WindowBase
{
    [global::UnityEngine.SerializeField]
    private GUIMasterLeagueTopBar topBar;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text total;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform incomeList;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.Transform expenseList;
    [global::UnityEngine.SerializeField]
    private global::UnityEngine.UI.Text crisisTips;
    [global::UnityEngine.SerializeField]
    private MLCoinVideoBtn coinBtn;
    private FinancialManager financialManager;
    private global::System.Collections.Generic.Dictionary<IncomeType, string> incomeStr;
    private int totalIncome;
    private global::System.Collections.Generic.Dictionary<ExpenseType, string> ExpenseTypeStr;
    private int totalExpense;
    private int totalExpenseWithoutPlayerSalary;
    public override void OnOpen(object parameter)
    {
    }

    private int FillIncome()
    {
        return 0;
    }

    private int FillExpense()
    {
        return 0;
    }

    public void CloseWindow()
    {
    }

    public override void OnClose()
    {
    }
}