using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
	public class user
	{
		public user()
		{

		}
		public user(string paramUsr, string paramName, string paramLastName, string paramCode)
		{
			username = paramUsr;
			name = paramName;
			lastName = paramName;
			code = paramCode;
		}
		public string username { get; set; }
		public string name { get; set; }
		public string lastName { get; set; }
		public string code { get; }
	}
}
