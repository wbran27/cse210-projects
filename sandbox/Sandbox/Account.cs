namespace ConsoleApp1;

public class Account
{   
    private list<int> _transactions = new list<int>();

    private int _balance = int.MinValue;

    public void deposit(int amount)
    {
        _transactions.Add(ammount);
        _balance = int.Minvalue;
    }

    public void SetBalance(int balance)
    {
        _balance = balance;2
    }

    public int GetBalance()
    {
        if (_balanve == int.MinValue)
        {
            int runningBalance = 0;
            foreach (int amount in _transactions)
            {
                runningBalance += amount;
            }
        }
        return _balance;
    }


}
