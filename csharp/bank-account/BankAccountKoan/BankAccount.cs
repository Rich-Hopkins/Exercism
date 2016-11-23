using System;

namespace BankAccountKoan
{
    public class BankAccount
    {
		private bool accountStatus = false;
	    private int balance = 0;
		private readonly object balanceLock = new object();
			
		public void Open()
	    {
		    accountStatus = true;
	    }

	    public int GetBalance()
		{
			ValidateAccount();
			return balance;
		}

	    public void UpdateBalance(int newBalance)
	    {
			ValidateAccount();
		    lock (balanceLock)
		    {
				balance += newBalance;
			}
	    }

	    public void Close()
	    {
			ValidateAccount();
		    accountStatus = false;
	    }

	    private void ValidateAccount()
	    {
			if(!accountStatus) throw new InvalidOperationException();
	    }
    }
}
