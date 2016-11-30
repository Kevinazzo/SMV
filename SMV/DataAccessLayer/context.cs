﻿using System;
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

		#region MySqlConnection
		public static string Password = "";
		public static string connectionString;
		public static MySqlConnection connection = new MySqlConnection();
		public static MySqlCommand command;
		public static MySqlDataReader reader;
		#endregion
		#region AccountInfo
		public static BusinessEntities.course courseList = new BusinessEntities.course();
		public static BusinessEntities.masterList masterList = new BusinessEntities.masterList();

		public static List<string> userList = new List<string>();
		public static List<string>[] accountsList = { new List<string>(), new List<string>(), new List<string>(), new List<string>(), new List<string>() };
		public static string[] currentSesionInfo = new string[4];
		#endregion
		#region Notes(calificaciones)

		public static List<float>[] calificaciones = new List<float>[6];

		#endregion

		#endregion

		#region Querys

		#region Startup
		public static void CREATEDATABASE()
		{
			string querySMV =
				"DROP DATABASE IF EXISTS smv;" +
				"CREATE DATABASE smv;use smv;" +

			"CREATE TABLE IF NOT EXISTS user(ID INT AUTO_INCREMENT PRIMARY KEY," +
				"userName VARCHAR(25) NOT NULL UNIQUE," +
				"`name` VARCHAR(50) NOT NULL," +
				"lastName VARCHAR(50) NOT NULL," +
				"pwd VARCHAR(32) NOT NULL," +
				"cCode VARCHAR(10)," +
				"FOREIGN KEY (cCode) REFERENCES codes(cCode)ENGINE=INNODB);" + Environment.NewLine +

			"CREATE TABLE IF NOT EXISTS course(`name` VARCHAR(50) NOT NULL," +
				"admin_ID INT NOT NULL," +
				"grade CHAR(1) NOT NULL," +
				"`group` CHAR(1) NOT NULL," +
				"ID INT AUTO_INCREMENT NOT NULL PRIMARY KEY," +
				"FOREIGN KEY(admin_ID)REFERENCES user(ID))ENGINE = INNODB;" + Environment.NewLine +

			"CREATE TABLE IF NOT EXISTS masterList(userName VARCHAR(25) NOT NULL," +
				"ID INT NOT NULL," +
				"un1 FLOAT,un2 FLOAT,un3 FLOAT,un4 FLOAT,un5 FLOAT,un6 FLOAT," +
				"FOREIGN KEY(userName)REFERENCES user(userName)," +
				"FOREIGN KEY(ID)REFERENCES course(ID)," +
				"UNIQUE keypair(userName, ID))ENGINE = INNODB;" +

			"CREATE TABLE IF NOT EXISTS codes(cCode VARCHAR(10) NOT NULL PRIMARY KEY);";
			command = new MySqlCommand(querySMV, connection);
			command.ExecuteNonQuery();
		}
		public static void verifyDataBase()
		{
			string query = "USE smv;";
			command = new MySqlCommand(query, connection);
			command.ExecuteNonQuery();
		}
		#endregion

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
			reader.Close();
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
		public static bool VerifyUserToLogIn(string param1, string param2)
		{
			var user = accountsList[0].Find(a => a == param1);
			var psw = accountsList[1].Find(a => a == param2);

			if ((user == param1) && (psw == param2))
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		public static List<string>[] getAccountCredentials(string param1, string param2)
		{
			string query = "SELECT userName,pwd,cCode FROM user WHERE username='" + param1 + "' AND pwd='" + param2 + "';";
			command = new MySqlCommand(query, connection);
			reader = command.ExecuteReader();

			while (reader.Read())
			{
				accountsList[0].Add(reader["userName"] + "");
				accountsList[1].Add(reader["pwd"] + "");
				accountsList[2].Add(reader["cCode"] + "");
			}
			reader.Close();
			return accountsList;
		}
		public static void getCurrentSessionData()
		{
			var userAA = accountsList[0].Find(item => item == accountsList[0].ElementAt(0).ToString());
			string query = "SELECT * FROM user WHERE username='" + userAA + "';";
			command = new MySqlCommand(query, connection);
			reader = command.ExecuteReader();
			while (reader.Read())
			{
				currentSesionInfo[0] = (reader["userName"] + "");
				currentSesionInfo[1] = (reader["name"] + "");
				currentSesionInfo[2] = (reader["lastName"] + "");
				currentSesionInfo[3] = (reader["cCode"] + "");
			}
			reader.Close();
		}
		#endregion

		#endregion

	}
}
