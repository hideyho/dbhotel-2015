using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using Microsoft.SqlServer.Server;
using System.Configuration;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Excel;
using MetroFramework.Forms;

namespace Гостиница
{
    public partial class report : MetroForm
    {
        public report()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Egor\Desktop\Курсач\Гостиница\Гостиница\Курсач.mdf;Integrated Security=True;");


        private void btnLoad_Click(object sender, EventArgs e)
        {


            String rep = "";
            con.Open();
            rep = "select o.ID, (с.Фамилия+' '+с.Имя+' '+с.Отчество) as Клиент, o.[Номер комнаты],g.[Тип номера], (o.Сотрудник+' '+k.Имя+' '+k.Отчество) as Сотрудник,o.[Дата заселения],o.[Срок проживания],o.[Общая стоимость] " + "from Гостиница o inner join Клиенты с  on o.Клиент = с.Фамилия inner join Сотрудники k on o.Сотрудник = k.Фамилия inner join [Номера гостиницы] g on o.[Номер комнаты] = g.[Номер комнаты]" +
$"where o.[Дата заселения] between '{dtFromDate.Text}' and '{dtToDate.Text}' ";
            SqlCommand cmd = new SqlCommand(rep, con);
            cmd.ExecuteNonQuery();
            System.Data.DataTable dt = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            repTable.DataSource = dt;
            con.Close();
            metroPanel1.Enabled = true;
        }

        private void report_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "курсачDataSet.Гостиница". При необходимости она может быть перемещена или удалена.
            this.гостиницаTableAdapter.Fill(this.курсачDataSet.Гостиница);


        }


        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(repTable.Size.Width + 10, repTable.Size.Height + 10);
            repTable.DrawToBitmap(bmp, repTable.Bounds);
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            //Книга.
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            //Таблица.
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
            ExcelApp.Columns[1].ColumnWidth = 5;
            ExcelApp.Columns[2].ColumnWidth = 35;
            ExcelApp.Columns[3].ColumnWidth = 15;
            ExcelApp.Columns[4].ColumnWidth = 15;
            ExcelApp.Columns[5].ColumnWidth = 35;
            ExcelApp.Columns[6].ColumnWidth = 15;
            ExcelApp.Columns[7].ColumnWidth = 15;
            ExcelApp.Columns[8].ColumnWidth = 15;
            ExcelApp.Cells[1, 1] = "ID";
            ExcelApp.Cells[1, 2] = "Клиент";
            ExcelApp.Cells[1, 3] = "Номер комнаты";
            ExcelApp.Cells[1, 4] = "Тип номера";
            ExcelApp.Cells[1, 5] = "Сотрудник";
            ExcelApp.Cells[1, 6] = "Дата заселения";
            ExcelApp.Cells[1, 7] = "Срок проживания";
            ExcelApp.Cells[1, 8] = "Общая стоимость";
            for (int i = 0; i < repTable.Rows.Count; i++)
            {
                for (int j = 0; j < repTable.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 2, j + 1] = repTable.Rows[i].Cells[j].Value;
                }
            }
            //Вызываем нашу созданную эксельку.
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;

        }

    }
}
