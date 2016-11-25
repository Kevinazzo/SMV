using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
	public static class Functions
	{

		#region VariablesAndObjects

		public static bool logged;
		public static bool loggedAsTeacher;

		#endregion

		#region toDataAccessLayer

		#endregion
		
		#region frameNav



		#endregion

		#region logic

		#region emptyTextfields
		public static bool loginEmptyFields(string param1, string param2)
		{
			if (true)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		#endregion
		public static void connectToDB()
		{
			DataAccessLayer.Context.connection.Open();
		}


		#endregion
	}
}
