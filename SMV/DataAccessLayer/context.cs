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

		#region connectionData
		public static MySqlCommand command;
		public static string promptPassword;
		public static MySqlDataReader reader;
		private static string connectionString = "server=localhost; uid=root;" + "pwd="+promptPassword+"; database=smv;";
		public static MySqlConnection connection = new MySqlConnection(connectionString);

		public static BusinessEntities.user currentSession = new BusinessEntities.user();
		
		public static List<string> userList = new List<string>();
		public static List<string>[] courseList = new List<string>[4];
		#endregion

		#region Querys
		public static void INSERTINTOuser()
		{

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
			if (userList.Count(a => a == param1)==0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		#endregion

	}
}
