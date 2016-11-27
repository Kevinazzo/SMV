﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BusinessLogic
{
	public static class Functions
	{

		#region VariablesAndObjects

		public static bool logged;
		public static bool loggedAsTeacher;

		#endregion

		#region toDataAccessLayer

		#region connectToDB
		public static void connectToDB()
		{
			DataAccessLayer.Context.connection.Open();
		}
		#endregion
		#region DataValidation
		#region registerUser
		public static bool VerifyExistingUserToIns(string userName)
		{
			if (DataAccessLayer.Context.verifyuserToIns(userName))
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		public static bool verifyCode(string code)
		{
			if (true)
			{
				return true;
			}
		}
		#endregion
		#region logIn
		public static bool verifyUserDataTologIn(string paramUsr, string paramPsw)
		{
			if (true)
			{
				return true;
			}
			else
			{

			}
		}
		#endregion

		#endregion

		#endregion

		#region logic

		#region emptyTextfields
		public static bool logInEmptyFields(string param1, string param2)
		{
			if ((param1.Length == 0x0) || (param2.Length == 0x0))
			{
				return false;
			}
			else
			{
				return true;
			}
		}
		#endregion

		private static void createAccount(string Usr, string name, string LName, string pwd, string code)
		{
			DataAccessLayer.Context.INSERTINTOuser(Usr, name, LName, pwd, code);
		}
		private static void logIn(string usr, string psw)
		{
			if (DataAccessLayer.Context.VerifyUserToLogIn(usr))
			{

			}
		}
		#endregion
	}
}
