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
	public partial class Form1 : System.Windows.Forms.Form
	{
		new int count = 0;
		public class AspectsViewer
		{
			public TextBox NameViewer = new TextBox();
			public ComboBox CategoryViewer = new ComboBox
			{
				SelectedText = "Выберите категорию",
				Items =  {
					(Aspects.Categories.Animation).ToString(),
					(Aspects.Categories.Comix).ToString(),
					(Aspects.Categories.Movie).ToString(),
					(Aspects.Categories.Videogame).ToString(),
					(Aspects.Categories.Book).ToString(),
					(Aspects.Categories.Album).ToString(),
				},
				SelectedIndex = 0,
				DropDownStyle = ComboBoxStyle.DropDownList,
			};
			public ComboBox GenreViewer = new ComboBox
			{
				SelectedText = "Жанр",
				DropDownStyle = ComboBoxStyle.DropDown,
			};
			public ComboBox ScoreViewer = new ComboBox
			{
				Text = "Оцените",
				Items =  {
					1.ToString(),
					2.ToString(),
					3.ToString(),
					4.ToString(),
					5.ToString(),
				},
				DropDownStyle = ComboBoxStyle.DropDownList,
			};
			public CheckBox IsWatchedViewer = new CheckBox()
			{
				CheckAlign = ContentAlignment.MiddleCenter
			};			
		}
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
		static List<Aspects> ConverterToFile(List<AspectsViewer> list)
		{
			List<Aspects> file = new List<Aspects>();
			for (int i = 0; i < list.Count; i++)
			{
				file.Add(new Aspects());
				file[i].Name = list[i].NameViewer.Text;
				file[i].Score = list[i].ScoreViewer.SelectedIndex + 1;
				file[i].Category = (Aspects.Categories)list[i].CategoryViewer.SelectedIndex;
				file[i].Genres = new List<string>();
				for (int j = 0; j < list[i].GenreViewer.Items.Count; j++)
				{
					file[i].Genres.Add(list[i].GenreViewer.Items[j].ToString());
				}
				file[i].IsWatched = list[i].IsWatchedViewer.Checked;
			}
			return file;
		}
		static List<AspectsViewer> ConverterFromFile(List<Aspects> fromFile)
			{
				List<AspectsViewer> toTable = new List<AspectsViewer>();
				for (int i = 0; i < fromFile.Count; i++)
				{
					toTable.Add(new AspectsViewer());
					toTable.ElementAt(i).NameViewer.Text = fromFile.ElementAt(i).Name;
					toTable.ElementAt(i).ScoreViewer.SelectedIndex = fromFile.ElementAt(i).Score-1 ;
					toTable.ElementAt(i).CategoryViewer.Text = fromFile.ElementAt(i).Category.ToString();
					for (int j = 0; j < fromFile[i].Genres.Count; j++)
					{
					toTable.ElementAt(i).GenreViewer.Items.Add(fromFile.ElementAt(i).Genres[j]);
					}
					toTable.ElementAt(i).IsWatchedViewer.Checked = fromFile.ElementAt(i).IsWatched;          
				}
				return toTable;
			}

		static List<AspectsViewer> rowList = new List<AspectsViewer>();
		static List<Aspects> filmList = new List<Aspects>();		
		public Form1()
		{
			InitializeComponent();			
		}
		private void EraseRow(int amount)
		{
			//rowList.ElementAt(count).GenreViewer.PreviewKeyDown -= GenreViewer_PreviewKeyDown;

			for (int i = 0; i < amount; i++)
			{
				if (tableLayoutPanel1.RowCount > 2)
				{
					tableLayoutPanel1.RowCount--;
					for (int column = 0; column < 6; column++)
						tableLayoutPanel1.Controls.Remove(Formatter(rowList.Count - 1, column));
					rowList.RemoveAt(rowList.Count - 1);
					count--;
				}
			}
		}
		private void DrawRow(int amount)
		{
			tableLayoutPanel1.RowCount++;
			rowList.ElementAt(count-1).GenreViewer.PreviewKeyDown += GenreViewer_PreviewKeyDown;			
			for (int column = 0; column < 5; column++)
			{
				tableLayoutPanel1.Controls.Add(Formatter(amount, column), column, tableLayoutPanel1.RowCount - 2);
				tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
				tableLayoutPanel1.RowStyles[1 + amount].Height = 40;
				Formatter(amount, column).Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left);
				Formatter(amount, column).Font = new Font("Times New Roman", 14);
			}
		}
		private Control Formatter(int i, int column)
		{
			switch (column)
			{
				case 0:
					return rowList.ElementAt(i).NameViewer;
				case 1:
					return rowList.ElementAt(i).CategoryViewer;
				case 2:
					return rowList.ElementAt(i).GenreViewer;
				case 3:
					return rowList.ElementAt(i).ScoreViewer;
				default:
					return rowList.ElementAt(i).IsWatchedViewer;
			}
		}

		private void GenreViewer_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			ComboBox comboBox = (ComboBox)sender;
			if (e.KeyCode==Keys.Right && !comboBox.Items.Contains(comboBox.Text)&& comboBox.Text!="")
			{
				comboBox.Items.Add(comboBox.Text);
				comboBox.Text = "";
				comboBox.SelectedText = comboBox.Text;
			}
			if (e.KeyCode == Keys.Left && comboBox.Items.Contains(comboBox.Text))
			{
				comboBox.Items.Remove(comboBox.Text);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			count++;
			rowList.Add(new AspectsViewer());
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
				var ctf = ConverterToFile(rowList);
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
			rowList = ConverterFromFile(filmList);
			for (int i = 0; i < rowList.Count; i++)
			{
				count++;
				DrawRow(i);				
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
