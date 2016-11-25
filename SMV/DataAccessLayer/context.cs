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
		private static string connectionString = "server=localhost; uid=root;" + "pwd="+promptPassword+"; database=consultorio;";
		public static MySqlConnection connection = new MySqlConnection(connectionString);
		public static MySqlDataReader reader;
		#endregion


	}
}
