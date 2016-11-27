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
		public user(string username, string name, string lastName, string code)
		{
			username = this.username;
			name = this.name;
			lastName = this.lastName;
			code = this.lastName;

		}
		private string username { get; set; }
		private string name { get; set; }
		private string lastName { get; set; }
		private string code { get; }
	}
}
