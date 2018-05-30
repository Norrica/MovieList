using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieList
{
	public partial class Form1 : Form
	{
		new int count = 0;
		public void ButtonEnabler()
		{
			if (count==0)
			{
				delete.Enabled = false;
				save.Enabled = false;
				deleteAll.Enabled = false;
			}
			else if(count>0)
			{
				delete.Enabled = true;
				save.Enabled = true;
				deleteAll.Enabled = true;
			}
		}
		public class AspectsViewer
		{
			public TextBox Name = new TextBox();
			public ComboBox Category = new ComboBox
			{
				SelectedText = "Выберите категорию",
				Items =  {
					(Aspects.Categories.Animation).ToString(),
					(Aspects.Categories.Comix).ToString(),
					(Aspects.Categories.Film).ToString(),
					(Aspects.Categories.Serial).ToString(),
				},
				SelectedIndex = 0,
				DropDownStyle = ComboBoxStyle.DropDownList,
			};

			public ComboBox ScoreViewer = new ComboBox
			{
				SelectedText = "Оцените",
				Items =  {
					1.ToString(),
					2.ToString(),
					3.ToString(),
					4.ToString(),
					5.ToString(),
				},
				SelectedIndex = 4,
				DropDownStyle = ComboBoxStyle.DropDownList,
			};
			public CheckBox IsWatched = new CheckBox();
		}
		static List<Aspects> ConverterToFile(List<AspectsViewer> list)	
			{
				List<Aspects> file = new List<Aspects>();
				for (int i = 0; i < list.Count; i++)
				{
					file.Add(new Aspects());
					file[i].name = list[i].Name.Text;
					file[i].Score = (int)list[i].ScoreViewer.SelectedIndex+1;
					file[i].category = (Aspects.Categories)list[i].Category.SelectedIndex;
					file[i].isWatched = list[i].IsWatched.Checked;
				}
				return file;
			}
		static List<AspectsViewer> ConverterFromFile(List<Aspects> fromFile)
			{
				List<AspectsViewer> toTable = new List<AspectsViewer>();
				for (int i = 0; i < fromFile.Count; i++)
				{
					toTable.Add(new AspectsViewer());
					toTable.ElementAt(i).Name.Text = fromFile.ElementAt(i).name;
					toTable.ElementAt(i).ScoreViewer.SelectedIndex = fromFile.ElementAt(i).Score - 1 ;
					toTable.ElementAt(i).Category.Text = fromFile.ElementAt(i).category.ToString();
					toTable.ElementAt(i).IsWatched.Checked = fromFile.ElementAt(i).isWatched;          
				}
				return toTable;
			}

		static List<AspectsViewer> movieList = new List<AspectsViewer>();
		static List<Aspects> filmList = new List<Aspects>();		
		public Form1()
		{
			InitializeComponent();			
		}
		private void EraseRow(int amount)
		{
			for (int i = 0; i < amount; i++)
			{
				if (tableLayoutPanel1.RowCount > 2)
				{
					tableLayoutPanel1.RowCount--;
					for (int column = 0; column < 6; column++)
						tableLayoutPanel1.Controls.Remove(Formatter(movieList.Count - 1, column));
					movieList.RemoveAt(movieList.Count - 1);
					count--;
				}
			}
		}
		private void DrawRow(int amount)
		{
			tableLayoutPanel1.RowCount++;
			for (int column = 0; column < 6; column++)
			{
				tableLayoutPanel1.Controls.Add(Formatter(amount, column), column, tableLayoutPanel1.RowCount - 2);
				tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
				tableLayoutPanel1.RowStyles[1 + amount].Height = 30;
				Formatter(amount, column).Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left);
				Formatter(amount, column).Font = new System.Drawing.Font("Times New Roman", this.Height / 30);
			}
			movieList.ElementAt(amount).IsWatched.CheckAlign = ContentAlignment.MiddleCenter;
		}
		private Control Formatter(int i, int column)
		{
			switch (column)
			{
				case 0:
					return movieList.ElementAt(i).Name;
				case 1:
					return movieList.ElementAt(i).Category;
				case 2:
					return movieList.ElementAt(i).ScoreViewer;
				default:
					return movieList.ElementAt(i).IsWatched;
			}
		}
		private void button1_Click(object sender, EventArgs e)
		{
			count++;
			movieList.Add(new AspectsViewer());
			DrawRow(count - 1);
			ButtonEnabler();
		}
		private void button2_Click(object sender, EventArgs e)
		{			
			EraseRow(1);
			ButtonEnabler();

		}
		private void button3_Click(object sender, EventArgs e)
		{
			var sfd = new SaveFileDialog() { Filter = "Личный топ|*.wtchths" };
			var result = sfd.ShowDialog(this);
			if (result == DialogResult.OK)
			{
				var ctf = ConverterToFile(movieList);
				Serializer.WriteFile(sfd.FileName, ctf);
			}
			ButtonEnabler();
		}
		private void button4_Click(object sender, EventArgs e)
		{
			var ofd = new OpenFileDialog() { Filter = "Личный Топ|*.wtchths" };
			var result = ofd.ShowDialog(this);
			if (result == DialogResult.OK)
			{
				Serializer.ReadFile(ofd.FileName,ref filmList);
			}
			EraseRow(tableLayoutPanel1.RowCount - 2);
			movieList = ConverterFromFile(filmList);
			for (int i = 0; i < movieList.Count; i++)
			{
				DrawRow(i);
				count++;
			}
			ButtonEnabler();
		}
		private void button5_Click(object sender, EventArgs e)
		{
			EraseRow(tableLayoutPanel1.RowCount);
			ButtonEnabler();
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			ButtonEnabler();
		}
	}
}
