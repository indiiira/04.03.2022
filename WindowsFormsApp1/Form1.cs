using DocumentFormat.OpenXml.EMMA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public void Function()
        {
            DataSet ds = new DataSet();
            //создаем временную таблицу
            ds.Tables.Add("Temp");

            //путь к текстовому файлу
            string path = @"group.txt";
            StreamReader sr = new StreamReader(path);

            /*создаем колонки в таблице и заполняем их названиями*/
            //считываем первую строку из файла, в ней названия столбцов
            string firstLine = sr.ReadLine();
           
            //массив имен колонок из файла
            string[] arraNameColumn = System.Text.RegularExpressions.Regex.Split(firstLine, " ");
            
            for (int i = 0; i < arraNameColumn.Length; i++)
            {
                ds.Tables[0].Columns.Add(arraNameColumn[i]);
              
            }

            /*заполняем строки в таблице*/
            string Line = sr.ReadLine();
            while (Line != null)
            {
                string[] arraCell = System.Text.RegularExpressions.Regex.Split(Line, " ");
                ds.Tables[0].Rows.Add(arraCell);
                Line = sr.ReadLine();
            }

            //привязываем dataGridView к таблице
            Info.DataSource = ds.Tables[0];
        }

        public  Form1()
        {
            InitializeComponent();

            this.Tab1.TabPages[this.Tab1.TabCount - 1].Text = "";
            this.Tab1.Padding = new Point(12, 4);
            this.Tab1.DrawMode = TabDrawMode.OwnerDrawFixed;

            this.Tab1.DrawItem += Tab1_DrawItem;
            this.Tab1.MouseDown += Tab1_MouseDown;
            this.Tab1.Selecting += Tab1_Selecting;
            this.Tab1.HandleCreated += Tab1_HandleCreated;
            Function();
        }




        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/indiiira");

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Setting s = new Setting();
            s.Show();
        }

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);
        private const int TCM_SETMINTABWIDTH = 0x1300 + 49;
        private void Tab1_HandleCreated(object sender, EventArgs e)
        {
            SendMessage(Tab1.Handle, TCM_SETMINTABWIDTH, IntPtr.Zero, (IntPtr)16);
        }
        private void Tab1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPageIndex == this.Tab1.TabCount - 1)
                e.Cancel = true;
        }
        private void Tab1_MouseDown(object sender, MouseEventArgs e)
        {
            var lastIndex = this.Tab1.TabCount - 1;
            if (this.Tab1.GetTabRect(lastIndex).Contains(e.Location))
            {
                this.Tab1.TabPages.Insert(lastIndex, "Новая вкладка");
                this.Tab1.SelectedIndex = lastIndex;
                this.Tab1.TabPages[lastIndex].UseVisualStyleBackColor = true;
            }
            else
            {
                for (var i = 0; i < this.Tab1.TabPages.Count; i++)
                {
                    var tabRect = this.Tab1.GetTabRect(i);
                    tabRect.Inflate(-2, -2);
                    var closeImage = Properties.Resources.Close;
                    var imageRect = new Rectangle(
                        (tabRect.Right - closeImage.Width),
                        tabRect.Top + (tabRect.Height - closeImage.Height) / 2,
                        closeImage.Width,
                        closeImage.Height);
                    if (imageRect.Contains(e.Location))
                    {
                        this.Tab1.TabPages.RemoveAt(i);
                        break;
                    }
                }
            }
        }
        private void Tab1_DrawItem(object sender, DrawItemEventArgs e)
        {
            var tabPage = this.Tab1.TabPages[e.Index];
            var tabRect = this.Tab1.GetTabRect(e.Index);
            tabRect.Inflate(-2, -2);
            if (e.Index == this.Tab1.TabCount - 1)
            {
                var addImage = Properties.Resources.Add;
                e.Graphics.DrawImage(addImage,
                    tabRect.Left + (tabRect.Width - addImage.Width) / 2,
                    tabRect.Top + (tabRect.Height - addImage.Height) / 2);
            }
            else
            {
                var closeImage = Properties.Resources.Close;
                e.Graphics.DrawImage(closeImage,
                    (tabRect.Right - closeImage.Width),
                    tabRect.Top + (tabRect.Height - closeImage.Height) / 2);
                TextRenderer.DrawText(e.Graphics, tabPage.Text, tabPage.Font,
                    tabRect, tabPage.ForeColor, TextFormatFlags.Left);
            }
        }

        private void Info_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            //создаем временную таблицу
            ds.Tables.Add("Temp");

            //путь к текстовому файлу
            string path = @"group.txt";
            StreamReader sr = new StreamReader(path);

            /*создаем колонки в таблице и заполняем их названиями*/
            //считываем первую строку из файла, в ней названия столбцов
            string firstLine = sr.ReadLine();

            //массив имен колонок из файла
            string[] arraNameColumn = System.Text.RegularExpressions.Regex.Split(firstLine, " ");

            for (int i = 0; i < arraNameColumn.Length; i++)
            {
                ds.Tables[0].Columns.Add(arraNameColumn[i]);

            }

            /*заполняем строки в таблице*/
            string Line = sr.ReadLine();
            while (Line != null)
            {
                string[] arraCell = System.Text.RegularExpressions.Regex.Split(Line, " ");
                ds.Tables[0].Rows.Add(arraCell);
                Line = sr.ReadLine();
            }
            string[] NameList = new string[3];
                
                NameList[0] = Fam.Text;
                NameList[1] = Name.Text;
                NameList[2] = Info.Text;
                ds.Tables[0].Rows.Add(NameList);
            
            
            
            //привязываем dataGridView к таблице
            Info.DataSource = ds.Tables[0];
        }

        private void Fam_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


