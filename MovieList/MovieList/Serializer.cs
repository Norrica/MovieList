using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace MovieList
{
	class Serializer
	{
		public static void WriteFile<T>(string fileName, List<T> data)
		{
			using (var file = File.Create(fileName))
			{
				new XmlSerializer(typeof(List<T>)).Serialize(file, data);
			}
		}
		public static void ReadFile<T>(string fileName, ref List<T> data)
		{
			using (var file = File.OpenRead(fileName))
			{
				data = (List<T>)new XmlSerializer(typeof(List<T>)).Deserialize(file);
			}
		}

	}
}

	
