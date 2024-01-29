using System.Net.Mail;

namespace DotNetProjectLibrary.Authentication
{
	public static class Authentication
	{
		public static bool CheckValidEmail(string email)
		{

			bool valid = true;

			try
			{
				var emailAddress = new MailAddress(email);
			}
			catch
			{
				valid = false;
			}

			return valid;
		}

		public static bool CheckValidPassword(string password)
		{
			bool valid = true;

			if (password == string.Empty)
			{
				return false;
			}

			return valid;
		}
	}
}