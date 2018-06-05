namespace MovieList
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.add = new System.Windows.Forms.Button();
			this.delete = new System.Windows.Forms.Button();
			this.deleteAll = new System.Windows.Forms.Button();
			this.save = new System.Windows.Forms.Button();
			this.load = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.label6 = new System.Windows.Forms.Label();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoScroll = true;
			this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tableLayoutPanel1.ColumnCount = 5;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.1555F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.89507F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.90645F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.987358F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.18205F));
			this.tableLayoutPanel1.Controls.Add(this.label3, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.label4, 5, 0);
			this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.label5, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
			this.tableLayoutPanel1.MaximumSize = new System.Drawing.Size(792, 325);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(792, 325);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(587, 1);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Оценка";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Dock = System.Windows.Forms.DockStyle.Top;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(666, 1);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(122, 20);
			this.label4.TabIndex = 3;
			this.label4.Text = "Просмотрено";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(375, 1);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(95, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Категория";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(477, 1);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(103, 20);
			this.label5.TabIndex = 4;
			this.label5.Text = "Жанр";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(4, 1);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(364, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Название";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// add
			// 
			this.add.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.add.Location = new System.Drawing.Point(810, 12);
			this.add.Name = "add";
			this.add.Size = new System.Drawing.Size(160, 60);
			this.add.TabIndex = 1;
			this.add.Text = "Добавить";
			this.add.UseVisualStyleBackColor = true;
			this.add.Click += new System.EventHandler(this.button1_Click);
			// 
			// delete
			// 
			this.delete.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.delete.Location = new System.Drawing.Point(810, 78);
			this.delete.Name = "delete";
			this.delete.Size = new System.Drawing.Size(160, 60);
			this.delete.TabIndex = 2;
			this.delete.Text = "Удалить";
			this.delete.UseVisualStyleBackColor = true;
			this.delete.Click += new System.EventHandler(this.button2_Click);
			// 
			// deleteAll
			// 
			this.deleteAll.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.deleteAll.Location = new System.Drawing.Point(810, 144);
			this.deleteAll.Name = "deleteAll";
			this.deleteAll.Size = new System.Drawing.Size(160, 60);
			this.deleteAll.TabIndex = 5;
			this.deleteAll.Text = "Удалить все";
			this.deleteAll.UseVisualStyleBackColor = true;
			this.deleteAll.Click += new System.EventHandler(this.button5_Click);
			// 
			// save
			// 
			this.save.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.save.Location = new System.Drawing.Point(810, 210);
			this.save.Name = "save";
			this.save.Size = new System.Drawing.Size(160, 60);
			this.save.TabIndex = 3;
			this.save.Text = "Сохранить";
			this.save.UseVisualStyleBackColor = true;
			this.save.Click += new System.EventHandler(this.button3_Click);
			// 
			// load
			// 
			this.load.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.load.Location = new System.Drawing.Point(810, 276);
			this.load.Name = "load";
			this.load.Size = new System.Drawing.Size(160, 60);
			this.load.TabIndex = 4;
			this.load.Text = "Загрузить";
			this.load.UseVisualStyleBackColor = true;
			this.load.Click += new System.EventHandler(this.button4_Click);
			// 
			// label6
			// 
			this.label6.Text = "Для добавления и удаления жанров \nиспользуйте  клавиши \n\"Вправо\" и  \"Влево\" \nсоответственно.";
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(810, 343);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(0, 13);
			this.label6.TabIndex = 6;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(1004, 402);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.deleteAll);
			this.Controls.Add(this.load);
			this.Controls.Add(this.save);
			this.Controls.Add(this.delete);
			this.Controls.Add(this.add);
			this.Controls.Add(this.tableLayoutPanel1);
			this.MaximumSize = new System.Drawing.Size(1020, 1080);
			this.MinimumSize = new System.Drawing.Size(1020, 400);
			this.Name = "Form1";
			this.Text = "Личный топ фильмов";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private void ComboBox1_PreviewKeyDown(object sender, System.Windows.Forms.PreviewKeyDownEventArgs e)
		{
			throw new System.NotImplementedException();
		}

		#endregion
		private System.Windows.Forms.Button add;
		private System.Windows.Forms.Button delete;
		private System.Windows.Forms.Button save;
		private System.Windows.Forms.Button load;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.Button deleteAll;
		public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
	}
}

