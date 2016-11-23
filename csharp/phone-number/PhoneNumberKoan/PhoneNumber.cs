using System;

namespace PhoneNumberKoan
{
	public class PhoneNumber
	{
		private string phoneNumber = "";

		public PhoneNumber(string inputNumber)
		{
			foreach (char c in inputNumber)
			{
				if (Char.IsNumber(c)) phoneNumber += c;
			}
			Validate();
		}

		private void Validate()
		{
			if (phoneNumber.Length == 11 && phoneNumber.Substring(0, 1) == "1") phoneNumber = phoneNumber.Substring(1);
			else if (phoneNumber.Length != 10) phoneNumber = "0000000000";
		}

		public string Number()
		{
			return phoneNumber;
		}

		public string AreaCode()
		{
			return phoneNumber.Substring(0, 3);
		}

		public override string ToString()
		{
			return "(" + phoneNumber.Substring(0, 3) + ") "
			       + phoneNumber.Substring(3, 3) + "-"
			       + phoneNumber.Substring(6);
		}
	}
}
