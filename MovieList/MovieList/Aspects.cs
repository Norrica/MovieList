using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieList
{
	public class Aspects
	{
		public string Name { get; set; }
		public int Score { get; set; }
		public Categories Category { get; set; }
		public enum Categories { Movie, Serial, Animation, Comix, Videogame, Book, Album }
		public /*static*/ List<string> Genres { get; set; }				
		public bool IsWatched { get; set; }
	}
}
