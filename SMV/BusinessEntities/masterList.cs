using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
	public class masterList
	{
		public masterList() { }
		public List<string> userName = new List<string>();
		public List<int> ID = new List<int>();
		public List<float>[] cals = new List<float>[6];

	}
}
