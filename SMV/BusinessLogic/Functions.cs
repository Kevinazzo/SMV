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
		public static List<List<string>> courseList = new List<List<string>>() { new List<string>(), new List<string>(), new List<string>()};
		public static List<string> rolledStudents = new List<string>();
		public static List<List<string>> BLLmasterList = new List<List<string>>() { new List<string>(), new List<string>(), new List<string>(), new List<string>(), new List<string>(), new List<string>(), new List<string>(), new List<string>() };
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
			if (code.Length > 0x0)
			{
				DataAccessLayer.Context.getCodesList();
				var desiredCode = DataAccessLayer.Context.accountsList[4].Find(item => item == code);
				if (desiredCode == code)
				{
					DataAccessLayer.Context.dropTeacherCode(desiredCode);
					DataAccessLayer.Context.accountsList[4].Clear();
					return true;
				}
				else
				{
					return false;
				}
			}
			else
			{
				return false;
			} 
		}
		public static void registerNewUser(string Usr,string name,string Ln,string psw,string code)
		{
			DataAccessLayer.Context.INSERTINTOuser(Usr, name, Ln, psw,code);
		}
		#endregion
		#region logIn
		public static bool verifyUserDataTologIn(string paramUsr, string paramPsw)
		{
			DataAccessLayer.Context.getAccountCredentials(paramUsr, paramPsw, true);
			DataAccessLayer.Context.getAccountCredentials(paramUsr, paramPsw, false);
			if (DataAccessLayer.Context.VerifyUserToLogIn(paramUsr, paramPsw))
			{
				DataAccessLayer.Context.getCurrentSessionData();
				clearTmpList();
				importCurrentSesion();
				if (currentSession.code.Length != 0)
				{
					loggedAsTeacher = true;
					return true;
				}
				else
				{
					logged = true;
					return true;
				}
			}
			else
			{
				return false;
			}
		}
		public static void importCurrentSesion()
		{
			currentSession = new BusinessEntities.user(DataAccessLayer.Context.currentSesionInfo.ElementAt(0),
				DataAccessLayer.Context.currentSesionInfo.ElementAt(1),
				DataAccessLayer.Context.currentSesionInfo.ElementAt(2),
				DataAccessLayer.Context.currentSesionInfo.ElementAt(3));
		}

		#endregion

		#endregion
		#region Courses

		public static void createcourse(string Cname, char Cgrade, char Cgroup)
		{
			DataAccessLayer.Context.INSERTINTOcourse(Cname,Cgrade,Cgroup);
		}

		public static void importCourses()
		{
			for (int i = 0; i < DataAccessLayer.Context.LoL[0].Count; i++)
			{
				courseList[0].Add(DataAccessLayer.Context.LoL[0].ElementAt(i));
			}
			for (int i = 0; i < DataAccessLayer.Context.LoL[0].Count; i++)
			{
				courseList[1].Add(DataAccessLayer.Context.LoL[2].ElementAt(i));
			}
			for (int i = 0; i < DataAccessLayer.Context.LoL[0].Count; i++)
			{
				courseList[2].Add(DataAccessLayer.Context.LoL[3].ElementAt(i));
			}
		}
		public static void selectCourses()
		{
			DataAccessLayer.Context.SELECTFROMcourse();
		}
		public static void clearCourseList()
		{
			for (int i = 0; i < courseList.Count; i++)
			{
				courseList[i].Clear();
			}
		}
		public static void deleteCourse(string param1)
		{
			DataAccessLayer.Context.DROPcourse(param1);
		}
		#endregion
		#region EnrollStudents
		public static bool enrollStudent(string userName,int IDo)
		{
			clearTmpList();
			try
			{
				DataAccessLayer.Context.INSERTINTOmasterList(userName, IDo);
				return true;
			}
			catch (MySqlException)
			{
				return false;
			}
		}
		public static void eraseStudent(string usr, int id)
		{
			DataAccessLayer.Context.DROPFROMmasterList(usr, id);
		}
		public static void getMasterList(int ido)
		{
			DataAccessLayer.Context.SELECTFROMmasterList(ido);
		}
		public static void clearBLLMasterList()
		{
			for (int i = 0; i < BLLmasterList.Count; i++)
			{
				BLLmasterList[i].Clear();
			}
		}
		public static void importMasterList()
		{
			for (int i = 0; i < DataAccessLayer.Context.DALmasterList[0].Count; i++)
			{
				BLLmasterList[0].Add(DataAccessLayer.Context.DALmasterList[0].ElementAt(i));
			}
			for (int i = 0; i < DataAccessLayer.Context.DALmasterList[0].Count; i++)
			{
				BLLmasterList[1].Add(DataAccessLayer.Context.DALmasterList[1].ElementAt(i));
			}
			for (int i = 0; i < DataAccessLayer.Context.DALmasterList[0].Count; i++)
			{
				BLLmasterList[2].Add(DataAccessLayer.Context.DALmasterList[2].ElementAt(i));
			}
			for (int i = 0; i < DataAccessLayer.Context.DALmasterList[0].Count; i++)
			{
				BLLmasterList[3].Add(DataAccessLayer.Context.DALmasterList[3].ElementAt(i));
			}
			for (int i = 0; i < DataAccessLayer.Context.DALmasterList[0].Count; i++)
			{
				BLLmasterList[4].Add(DataAccessLayer.Context.DALmasterList[4].ElementAt(i));
			}
			for (int i = 0; i < DataAccessLayer.Context.DALmasterList[0].Count; i++)
			{
				BLLmasterList[5].Add(DataAccessLayer.Context.DALmasterList[5].ElementAt(i));
			}
			for (int i = 0; i < DataAccessLayer.Context.DALmasterList[0].Count; i++)
			{
				BLLmasterList[6].Add(DataAccessLayer.Context.DALmasterList[6].ElementAt(i));
			}
			for (int i = 0; i < DataAccessLayer.Context.DALmasterList[0].Count; i++)
			{
				BLLmasterList[7].Add(DataAccessLayer.Context.DALmasterList[7].ElementAt(i));
			}
		}
		#endregion

		#region upgrade
		public static void updateCals (string URS,string asa,string bs,string cs,string ds,string es, string fs)
		{
			DataAccessLayer.Context.upgradeCALS(URS, asa, bs, cs, ds, es, fs);
		}
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
		public static int getCourseID (string Name)
		{
			return DataAccessLayer.Context.getCourseId(Name);
		}
		public static void clearTmpList()
		{
			for (int x = 0x0; x < DataAccessLayer.Context.Col3tmpStringList[0].Count; x++)
			{
				DataAccessLayer.Context.Col3tmpStringList[x].Clear();
			}
		}
		public static void closeConnection()
		{
			DataAccessLayer.Context.connection.Close();
		}
		#endregion
	}
}