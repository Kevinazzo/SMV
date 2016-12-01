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
		public static BusinessEntities.user currentSession;
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
			DataAccessLayer.Context.getAccountCredentials(paramUsr, paramPsw);
			if (DataAccessLayer.Context.VerifyUserToLogIn(paramUsr, paramPsw))
			{
				DataAccessLayer.Context.getCurrentSessionData();
				for (int x = 0x0; x < DataAccessLayer.Context.accountsList.Length; x++)
				{
					DataAccessLayer.Context.accountsList[x].Clear();
				}
				importCurrentSesion();
				logged = true;
				return true;
			}
			else
			{
				return false;
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

		public static void importCurrentSesion()
		{
			currentSession = new BusinessEntities.user(DataAccessLayer.Context.currentSesionInfo.ElementAt(0),
				DataAccessLayer.Context.currentSesionInfo.ElementAt(1),
				DataAccessLayer.Context.currentSesionInfo.ElementAt(2),
				DataAccessLayer.Context.currentSesionInfo.ElementAt(3));
		}
		public static void closeConnection()
		{
			DataAccessLayer.Context.connection.Close();
		}
		#endregion
	}
}