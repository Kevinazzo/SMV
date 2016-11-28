using System;
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

		public static bool connectedToDB = false;
		public static bool logged;
		public static bool loggedAsTeacher;
		public static BusinessEntities.user BLLCurrentSesion;

		#endregion

		#region toDataAccessLayer


		#region Startup
		public static void startupConnectToServer(string param1)
		{
			DataAccessLayer.Context.Password = param1;
			DataAccessLayer.Context.connection.Open();
		}
		public static void startupSETPassword(string param1)
		{
			DataAccessLayer.Context.Password = param1;
			DataAccessLayer.Context.connection.ConnectionString = "server=localhost; uid=root; pwd=" + param1 + ";";
		}
		public static void BLLstartupVerifyDB()
		{
			DataAccessLayer.Context.verifyDataBase();
		}
		public static void connectToDB()
		{
			DataAccessLayer.Context.connection.Open();
		}
		public static void startupCreateDatabase()
		{
			DataAccessLayer.Context.CREATEDATABASE();
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
		public static void registerNewUser(string Usr,string name,string Ln,string psw, string code)
		{
			DataAccessLayer.Context.INSERTINTOuser(Usr, name, Ln, psw, code);
		}
		#endregion
		#region logIn
		public static bool verifyUserDataTologIn(string paramUsr, string paramPsw)
		{
			DataAccessLayer.Context.Select(paramUsr,paramPsw);
			if (DataAccessLayer.Context.VerifyUserToLogIn(paramUsr,paramPsw))
			{
				DataAccessLayer.Context.accountsList[0].Clear();
				DataAccessLayer.Context.accountsList[1].Clear();
				DataAccessLayer.Context.accountsList[2].Clear();
				DataAccessLayer.Context.accountsList[3].Clear();
				DataAccessLayer.Context.accountsList[5].Clear();
				return true;
			}
			else
			{
				return false;
			}
		}
		public static void loadCurrentSesion()
		{
			BLLCurrentSesion = DataAccessLayer.Context.currentSession;
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
			if (DataAccessLayer.Context.VerifyUserToLogIn(usr,psw))
			{

			}
		}
		public static void closeConnection()
		{
			DataAccessLayer.Context.connection.Close();
		}
		#endregion
	}
}
