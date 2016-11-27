using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DataAccessLayer
{
	public static class Context
	{

		#region variablesAndObjects
		public static string promptPassword;
		private static string connectionString = "server=localhost; uid=root;" + "pwd=" + promptPassword + "; database=smv;";
		public static MySqlConnection connection = new MySqlConnection(connectionString);
		public static MySqlCommand command;
		public static MySqlDataReader reader;
		
		public static BusinessEntities.user currentSession;
		public static BusinessEntities.course courseList = new BusinessEntities.course();
		public static BusinessEntities.masterList masterList = new BusinessEntities.masterList(); 

		public static List<string> userList = new List<string>();
		#endregion

		#region Querys
		#region InsertUser
		public static void INSERTINTOuser(string userName, string name, string lastName, string pwd, string code)
		{
			string query = "INSERT INTO user values('" + userName + "','" + name + "','" + lastName + "','" + pwd + "','" + code + "');";
			command = new MySqlCommand(query, connection);
			command.ExecuteNonQuery();
		}
		public static bool verifyuserToIns(string param1)
		{
			string query = "SELECT * FROM user WHERE username='" + param1 + "';";
			command = new MySqlCommand(query, connection);
			reader = command.ExecuteReader();

			while (reader.Read())
			{
				userList.Add(param1);
			}
			if (userList.Count(a => a == param1) == 0x0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		#endregion

		#region selectUser
		public static bool VerifyUserToLogIn(string param1)
		{
			string query = "SELECT * FROM user WHERE username='" + param1 + "';";
			command = new MySqlCommand(query, connection);
			reader = command.ExecuteReader();

			while (reader.Read())
			{
				userList.Add(param1);
			}
			if (userList.Count(a => a == param1) == 0x0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		#endregion

		#endregion

	}
}
