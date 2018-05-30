using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MovieList
{
	[Serializable]
	public class Aspects
	{
		public String name { get; set; }
		public int Score { get; set; }
		public Categories category { get; set; }
		public enum Categories { Film,Serial,Animation,Comix}
		public bool isWatched { get; set; }
	}

}
