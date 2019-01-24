using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MetroFramework;
using MetroFramework.Forms;
using System.IO;
using System.Diagnostics;

namespace Гостиница
{
    public partial class Form1 : MetroForm


    {
        //Добавьте сюда свою строку подключения
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\zlode\Google Диск\Backup std;\Гостиница\Гостиница\Курсач.mdf';Integrated Security=True;");
        public Form1()
        {
            InitializeComponent();
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "курсачDataSet.Обслуживание". При необходимости она может быть перемещена или удалена.
            this.обслуживаниеTableAdapter.Fill(this.курсачDataSet.Обслуживание);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "курсачDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.курсачDataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "курсачDataSet.Номера_гостиницы". При необходимости она может быть перемещена или удалена.
            this.номера_гостиницыTableAdapter.Fill(this.курсачDataSet.Номера_гостиницы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "курсачDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.курсачDataSet.Клиенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "курсачDataSet.Гостиница". При необходимости она может быть перемещена или удалена.
            this.гостиницаTableAdapter.Fill(this.курсачDataSet.Гостиница);
            refresh();
            Form2 frm2 = new Form2();
            activeTxtBox(textBox9, false);
            activeTxtBox(textBox10, false);
            activeTxtBox(textBox11, false);
            activeTxtBox(textBox12, false);
            activeTxtBox(textBox13, false);
            activeTxtBox(textBox14, false);
            activeTxtBox(textBox15, false);
           
            metroLabel2.Visible = false;
            metroLabel3.Visible = false;
            metroLabel4.Visible = false;
            metroLabel5.Visible = false;
            metroLabel6.Visible = false;
            metroLabel7.Visible = false;
            metroLabel8.Visible = false;
            chooseFindBox.Items.AddRange(new string[] { "ID", "Клиент", "Номер комнаты", "ID Обслуживания", "Сотрудник", "Срок проживания", "Общая стоимость" });
            if (frm2.admin == false)
            {
                tabAdd.PageEnabled = false;
                tabDelete.PageEnabled = false;
                tabEdit.PageEnabled = false;
               
            }
            if(frm2.admin == true)
            {
                tabAdd.PageEnabled = true;
                tabDelete.PageEnabled = true;
                tabEdit.PageEnabled = true;
            }
            
        }



        void clearAllTextBoxes()
        {

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
           
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
           
        }
        void clearcombo()
        {
            comboBox1.DataSource = null;
            comboBox1.DisplayMember = null;
            comboBox2.DataSource = null;
            comboBox2.DisplayMember = null;
            comboBox3.DataSource = null;
            comboBox3.DisplayMember = null;
            comboBox4.DataSource = null;
            comboBox4.DisplayMember = null;
            comboBox5.DataSource = null;
            comboBox5.DisplayMember = null;
            comboBox6.DataSource = null;
            comboBox6.DisplayMember = null;
            comboBox7.DataSource = null;
            comboBox7.DisplayMember = null;
            comboBox8.DataSource = null;
            comboBox8.DisplayMember = null;
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();
            comboBox5.Items.Clear();
            comboBox6.Items.Clear();
            comboBox7.Items.Clear();
            comboBox8.Items.Clear();
            activeTxtBox(textBox1, false);
            activeTxtBox(textBox2, false);
            activeTxtBox(textBox3, false);
            activeTxtBox(textBox4, false);
            activeTxtBox(textBox5, false);
            activeTxtBox(textBox6, false);
            activeTxtBox(textBox7, false);
           
            activeTxtBox(textBox9, false);
            activeTxtBox(textBox10, false);
            activeTxtBox(textBox11, false);
            activeTxtBox(textBox12, false);
            activeTxtBox(textBox13, false);
            activeTxtBox(textBox14, false);
            activeTxtBox(textBox15, false);
            
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            comboBox3.Visible = false;
            comboBox4.Visible = false;
            comboBox5.Visible = false;
            comboBox6.Visible = false;
            comboBox7.Visible = false;
            comboBox8.Visible = false;
            dateBox2.Visible = false;
            dateBox.Visible = false;
            chooseFindBox.Items.Clear();
           
        }
        void activeTxtBox(MetroFramework.Controls.MetroTextBox txt,bool active)
        {
            if(active == false)
            {
                txt.Enabled = false;
                txt.BackColor = Color.LightGray;
            }
            if(active == true)
            {
                txt.Enabled = true;
                txt.BackColor = Color.White;
            }
        }
        private void tableChanged(object sender, EventArgs e)
        {
           
            clearAllTextBoxes();
            clearcombo();
            metroLabel2.Visible = false;
            metroLabel3.Visible = false;
            metroLabel4.Visible = false;
            metroLabel5.Visible = false;
            metroLabel6.Visible = false;
            metroLabel7.Visible = false;
            metroLabel8.Visible = false;
            if (TabTable.SelectedIndex == 0)
            {

                refreshCombo1();
                refreshCombo2();
                refreshCombo3();
                refreshCombo4();
                chooseFindBox.Items.AddRange(new string[] { "ID", "Клиент", "Номер комнаты", "ID Обслуживания", "Сотрудник", "Дата заселения", "Срок проживания", "Общая стоимость" });
                label1.Text = "ID";
                label2.Text = "Клиент";
                label3.Text = "Номер комнаты";
                label4.Text = "ID Обслуживание";
                label5.Text = "Сотрудник";
                label6.Text = "Дата заселения";
                label7.Text = "Срок проживания";
               
                comboBox1.Visible = true;
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                comboBox4.Visible = true;
               
                dateBox.Visible = true;
                activeTxtBox(textBox6, true);
                activeTxtBox(textBox7, true);
               
                activeTxtBox(textBox1, false);
            }
            if (TabTable.SelectedIndex == 1)
            {
                chooseFindBox.Items.AddRange(new string[] { "Фамилия", "Имя", "Отчество", "Город", "Серия паспорта", "Номер паспорта", "Номер телефона"});
                label1.Text = "Фамилия";
                label2.Text = "Имя";
                label3.Text = "Отчество";
                label4.Text = "Город";
                label5.Text = "Серия паспорта";
                label6.Text = "Номер паспорта";
                label7.Text = "Номер телефона";
                
                activeTxtBox(textBox1, true);
                activeTxtBox(textBox2, true);
                activeTxtBox(textBox3, true);
                activeTxtBox(textBox4, true);
                activeTxtBox(textBox5, true);
                activeTxtBox(textBox6, true);
                activeTxtBox(textBox7, true);
                
            }
            if (TabTable.SelectedIndex == 2)
            {
                chooseFindBox.Items.AddRange(new string[] { "Номер комнаты", "Тип номера", "Занятость", "Стоимость"});
                label5.Text = "";
                label1.Text = "Номер комнаты";
                label2.Text = "Тип комнаты";
                label3.Text = "Занятость";
                label4.Text = "Стоимость";
                label6.Text = "";
                label7.Text = "";
                comboBox1.Visible = true;
                comboBox2.Visible = true;
                comboBox1.Items.AddRange(new string[] { "С балконом", "Делюкс", "Дуплекс", "Стандарт", "Семейный" });
                comboBox2.Items.AddRange(new string[] { "Занят", "Свободен" });
                activeTxtBox(textBox1, true);
                activeTxtBox(textBox4, true);
            }
            if (TabTable.SelectedIndex == 3)
            {
                chooseFindBox.Items.AddRange(new string[] { "Фамилия", "Имя", "Отчество", "Образование", "Должность", "Номер телефона"});
                label1.Text = "Фамилия";
                label2.Text = "Имя";
                label3.Text = "Отчество";
                label4.Text = "Образование";
                label5.Text = "Должность";
                label6.Text = "Номер телефона";
                label7.Text = "";
                comboBox3.Visible = true;
                comboBox4.Visible = true;
                comboBox3.Items.AddRange(new string[] { "Базовое", "Среднее", "Высшее" });
                comboBox4.Items.AddRange(new string[] { "Менеджер", "Официант", "Уборщик", "Обслуж. помещения" });
                activeTxtBox(textBox1, true);
                activeTxtBox(textBox2, true);
                activeTxtBox(textBox3, true);
                activeTxtBox(textBox6, true);
            }
            if (TabTable.SelectedIndex == 4)
            {
                chooseFindBox.Items.AddRange(new string[] { "ID", "Уборка помещения", "Доставка еды", "Экскурсии", "Спорт помещения"});
                label1.Text = "ID";
                label2.Text = "Уборка помещения";
                label3.Text = "Доставка еды";
                label4.Text = "Экскурсии";
                label5.Text = "Спорт помещения";
                label6.Text = "";
                label7.Text = "";
                comboBox1.Visible = true;
                comboBox1.Items.AddRange(new string[] { "Включено", "Не включено" });
                comboBox2.Items.AddRange(new string[] { "Включено", "Не включено" });
                comboBox3.Items.AddRange(new string[] { "Включено", "Не включено" });
                comboBox4.Items.AddRange(new string[] { "Включено", "Не включено" });
                comboBox2.Visible = true;
                comboBox3.Visible = true;
                comboBox4.Visible = true;
            }
           
        }
        
       
        void refresh()
        {
            String refresh = "";
            DataGridView table = new DataGridView();
            con.Open();
            if (TabTable.SelectedIndex == 0)
            {
                refresh = "SELECT * FROM [Гостиница]";
                table = dataGridHotel;
               
            }
            if (TabTable.SelectedIndex == 1)
            {
                refresh = "SELECT * FROM [Клиенты]";
                table = dataGridClients;
            }
            if (TabTable.SelectedIndex == 2)
            {
                refresh = "SELECT * FROM [Номера гостиницы]";
                table = dataGridRooms;
            }
            if (TabTable.SelectedIndex == 3)
            {
                refresh = "SELECT * FROM [Сотрудники]";
                table = dataGridWorkers;
            }
            if (TabTable.SelectedIndex == 4)
            {
                refresh = "SELECT * FROM [Обслуживание]";
                table = dataGridService;
            }
            SqlCommand cmd = new SqlCommand(refresh, con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            table.DataSource = dt;
            con.Close();
        }

        void refreshCombo1()
        {
            con.Open();
            String box1 = @"SELECT *from [Клиенты] ";
            SqlCommand sqlCommand = new SqlCommand(box1, con);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataReader);

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                comboBox1.Items.Add(dataTable.Rows[i][0].ToString());
                comboBox5.Items.Add(dataTable.Rows[i][0].ToString());
            }
            comboBox1.Text = comboBox1.Items[0].ToString();
            comboBox5.Text = comboBox5.Items[0].ToString();
            con.Close();
        }
        void refreshCombo2()
        {
            con.Open();
            String box1 = @"SELECT *from [Номера гостиницы] ";
            SqlCommand sqlCommand = new SqlCommand(box1, con);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataReader);

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                comboBox2.Items.Add(dataTable.Rows[i][0].ToString());
                comboBox6.Items.Add(dataTable.Rows[i][0].ToString());
            }
            comboBox2.Text = comboBox2.Items[0].ToString();
            comboBox6.Text = comboBox6.Items[0].ToString();
            con.Close();
        }
        void refreshCombo3()
        {
            con.Open();
            String box1 = @"SELECT *from [Обслуживание] ";
            SqlCommand sqlCommand = new SqlCommand(box1, con);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataReader);

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                comboBox7.Items.Add(dataTable.Rows[i][0].ToString());
                comboBox3.Items.Add(dataTable.Rows[i][0].ToString());
            }
            comboBox3.Text = comboBox3.Items[0].ToString();
            comboBox7.Text = comboBox7.Items[0].ToString();
            con.Close();
        }
        void refreshCombo4()
        {
            con.Open();
            String box1 = @"SELECT *from [Сотрудники] ";
            SqlCommand sqlCommand = new SqlCommand(box1, con);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(sqlDataReader);

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                comboBox4.Items.Add(dataTable.Rows[i][0].ToString());
                comboBox8.Items.Add(dataTable.Rows[i][0].ToString());
            }
            comboBox3.Text = comboBox3.Items[0].ToString();
            comboBox8.Text = comboBox8.Items[0].ToString();
            con.Close();
        }
        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            
            String insert = "";
            bool empty = false;
            con.Open();
            try
            {
                if (TabTable.SelectedIndex == 0)
                {
                    if (comboBox1.Text != "" && comboBox2.Text != "" && comboBox3.Text != "" && comboBox4.Text != "" && textBox7.Text != "" )
                    {

                        insert = "INSERT INTO [Гостиница] (Клиент , [Номер комнаты] , [ID Обслуживания] , Сотрудник , [Дата заселения] , [Срок проживания] ) VALUES ('" + comboBox1.Text + "'," + Convert.ToInt32(comboBox2.Text) + " , " + Convert.ToInt32(comboBox3.Text) + " , '" + comboBox4.Text + "' , '" + dateBox.Text + " '," + Convert.ToInt32(textBox7.Text) + ")";

                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Не все поля заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        empty = true;
                    }
                }
                if (TabTable.SelectedIndex == 1)
                {
                    if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "")
                    {
                        insert = "INSERT INTO [Клиенты] (Фамилия , Имя , Отчество , Город , [Серия паспорта] , [Номер паспорта] , [Номер телефона]) VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "','" + textBox3.Text + "','" + 
                        textBox4.Text + "','" + textBox5.Text + "'," + Convert.ToInt32(textBox6.Text) + "," + Convert.ToInt32(textBox7.Text) + ")";
                       
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Не все поля заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        empty = true;
                    }
                }
                if (TabTable.SelectedIndex == 2)
                {
                    if (textBox1.Text != "" && comboBox1.Text != "" && comboBox2.Text != "" && textBox4.Text != "")
                    {
                        insert = "INSERT INTO [Номера гостиницы] ([Номер комнаты] , [Тип номера] , Занятость , Стоимость) VALUES (" + Convert.ToInt32(textBox1.Text) + ", '" + comboBox1.Text + "','" + comboBox2.Text + "','" + Convert.ToString(textBox4.Text) + "')";
                      
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Не все поля заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        empty = true;
                       
                    }
                }
                if (TabTable.SelectedIndex == 3)
                {
                    if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && comboBox3.Text != "" && comboBox4.Text != "" && textBox6.Text != "")
                    {
                        insert = "INSERT INTO [Сотрудники] (Фамилия , Имя , Отчество , Образование , Должность, [Номер телефона]) VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox3.Text + "','" + comboBox4.Text + "'," + Convert.ToString(textBox6.Text) + ")";
                       
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Не все поля заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        empty = true;
                    }
                }
                if (TabTable.SelectedIndex == 4)
                {
                    if (comboBox1.Text != "" && comboBox2.Text != "" && comboBox3.Text != "" && comboBox4.Text != "")
                    {

                        insert = "INSERT INTO [Обслуживание] ([Уборка помещения] , [Доставка еды] , Экскурсии , [Спорт помещения]) VALUES ('" + comboBox1.Text + "', '" + comboBox2.Text + "','" + comboBox3.Text + "','" + comboBox4.Text + "')";
                       
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Не все поля заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        empty = true;
                    }

                }
                if (empty == false)
                {
                    SqlCommand cmd = new SqlCommand(insert, con);
                    cmd.ExecuteNonQuery();
                    MetroFramework.MetroMessageBox.Show(this,"Данные успешно внесены в базу. ", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Проверьте правильность введенных данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
            refresh();
            clearAllTextBoxes();
        }
       

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            String delete = "";
             bool empty = false;
            StreamWriter streamWriter = new StreamWriter("deleted.txt",true,System.Text.Encoding.Default);

            con.Open();
            
            try
            {
                if (TabTable.SelectedIndex == 0)
                {
                    for (int i = 0; i < dataGridHotel.CurrentRow.Cells.Count; i++)
                    {
                        streamWriter.Write(dataGridHotel.CurrentRow.Cells[i].Value + "     ");
                    }
                    streamWriter.WriteLine();
                    if (dataGridHotel.CurrentRow != null)
                    {
                        delete = "DELETE FROM [Гостиница] where [ID]='" + Convert.ToString(dataGridHotel.CurrentRow.Cells[0].Value) + "'";
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Строка не выбрана", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        empty = true;
                    }
                    streamWriter.Close();

                }
                if (TabTable.SelectedIndex == 1)
                {
                    if (dataGridClients.CurrentRow != null)
                    {
                     
                        delete = "DELETE FROM [Клиенты] where [Фамилия]='" + Convert.ToString(dataGridClients.CurrentRow.Cells[1].Value) + "'";
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Строка не выбрана", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        empty = true;
                    }
                    }
                if (TabTable.SelectedIndex == 2)
                {
                    if (dataGridRooms.CurrentRow != null)
                    {
                        
                        delete = "DELETE FROM [Номера гостиницы] where [Номер комнаты]='" + Convert.ToString(dataGridRooms.CurrentRow.Cells[0].Value) + "'";
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Строка не выбрана", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        empty = true;
                    }
                    }
                if (TabTable.SelectedIndex == 3)
                {
                    if (dataGridWorkers.CurrentRow != null)
                    {
                        delete = "DELETE FROM [Сотрудники] where [Фамилия]='" + Convert.ToString(dataGridWorkers.CurrentRow.Cells[1].Value) + "'";
                      
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Строка не выбрана", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        empty = true;
                    }
                    }
                if (TabTable.SelectedIndex == 4)
                {
                    if (dataGridService.CurrentRow != null)
                    {
                        delete = "DELETE FROM [Обслуживание] where [[ID Обслуживания]='" + Convert.ToString(dataGridService.CurrentRow.Cells[0].Value) + "'";
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Строка не выбрана", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        empty = true;
                    }
                    }

                if (empty == false)
                {
                    SqlCommand cmd = new SqlCommand(delete, con);
                    cmd.ExecuteNonQuery();
                    MetroFramework.MetroMessageBox.Show(this,"Данные успешно удалены из базы.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            } catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Не удалось удалить данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
             con.Close();
            streamWriter.Close();
            refresh();
        }



        string id;
        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            clearcombo();
            refreshCombo1();
            refreshCombo2();
            refreshCombo3();
            refreshCombo4();
            metroLabel2.Visible = true;
            metroLabel3.Visible = true;
            metroLabel4.Visible = true;
            metroLabel5.Visible = true;
            metroLabel6.Visible = true;
            metroLabel7.Visible = true;
            metroLabel8.Visible = true;
            if (TabTable.SelectedIndex == 0)
            {
                metroLabel7.Text = "ID";
                metroLabel8.Text = "Клиент";
                metroLabel6.Text = "Номер комнаты";
                metroLabel5.Text = "Сотрудник";
                metroLabel4.Text = "ID Обслуживания";
                metroLabel3.Text = "Дата заселения";
                metroLabel2.Text = "Срок проживания";
                textBox9.Text = Convert.ToString(dataGridHotel.CurrentRow.Cells[0].Value);
                comboBox5.Visible = true;
                comboBox5.Text = Convert.ToString(dataGridHotel.CurrentRow.Cells[1].Value);
                comboBox6.Visible = true;
                comboBox6.Text = Convert.ToString(dataGridHotel.CurrentRow.Cells[2].Value);
                comboBox7.Visible = true;
                comboBox7.Text = Convert.ToString(dataGridHotel.CurrentRow.Cells[3].Value);
                comboBox8.Visible = true;
                comboBox8.Text = Convert.ToString(dataGridHotel.CurrentRow.Cells[4].Value);
                dateBox2.Visible = true;
                dateBox2.Text = Convert.ToString(dataGridHotel.CurrentRow.Cells[5].Value);
                activeTxtBox(textBox15, true);
                textBox15.Text = Convert.ToString(dataGridHotel.CurrentRow.Cells[6].Value);
                }
            if (TabTable.SelectedIndex == 1)
            {
                metroLabel7.Text = "Фамилия";
                metroLabel8.Text = "Имя";
                metroLabel6.Text = "Отчество";
                metroLabel5.Text = "Город";
                metroLabel4.Text = "Серия паспорта";
                metroLabel3.Text = "Номер паспорта";
                metroLabel2.Text = "Номер телефона";
                activeTxtBox(textBox9, true);
                textBox9.Text = Convert.ToString(dataGridClients.CurrentRow.Cells[1].Value);
                activeTxtBox(textBox10, true);
                textBox10.Text = Convert.ToString(dataGridClients.CurrentRow.Cells[2].Value);
                activeTxtBox(textBox11, true);
                textBox11.Text = Convert.ToString(dataGridClients.CurrentRow.Cells[3].Value);
                activeTxtBox(textBox12, true);
                textBox12.Text = Convert.ToString(dataGridClients.CurrentRow.Cells[4].Value);
                activeTxtBox(textBox13, true);
                textBox13.Text = Convert.ToString(dataGridClients.CurrentRow.Cells[5].Value);
                activeTxtBox(textBox14, true);
                textBox14.Text = Convert.ToString(dataGridClients.CurrentRow.Cells[6].Value);
                activeTxtBox(textBox15, true);
                textBox15.Text = Convert.ToString(dataGridClients.CurrentRow.Cells[7].Value);
            }
            if (TabTable.SelectedIndex == 2)
            {
                metroLabel7.Text = "Номер комнаты";
                metroLabel8.Text = "Тип";
                metroLabel6.Text = "Занятость";
                metroLabel5.Text = "Стоимость";
                metroLabel4.Visible = false;
                metroLabel3.Visible = false;
                metroLabel2.Visible = false;
                comboBox5.Visible = true;
                comboBox5.Items.AddRange(new string[] { "С балконом", "Делюкс", "Дуплекс", "Стандарт", "Семейный" });
                comboBox6.Items.AddRange(new string[] { "Занят", "Свободен" });
                comboBox6.Visible = true;
                activeTxtBox(textBox9, true);
                textBox9.Text = Convert.ToString(dataGridRooms.CurrentRow.Cells[0].Value);
                comboBox5.Text = Convert.ToString(dataGridRooms.CurrentRow.Cells[1].Value);
                comboBox6.Text = Convert.ToString(dataGridRooms.CurrentRow.Cells[2].Value);
                activeTxtBox(textBox12, true);
                textBox12.Text = Convert.ToString(dataGridRooms.CurrentRow.Cells[3].Value);
            }
            if(TabTable.SelectedIndex == 3)
            {
                metroLabel7.Text = "Фамилия";
                metroLabel8.Text = "Имя";
                metroLabel6.Text = "Отчество";
                metroLabel5.Text = "Образование";
                metroLabel4.Text = "Должность";
                metroLabel3.Text = "Номер телефона";
                metroLabel2.Visible = false;
            
                activeTxtBox(textBox9, true);
                activeTxtBox(textBox10, true);
                activeTxtBox(textBox11, true);
                activeTxtBox(textBox14, true);
                comboBox7.Visible = true;
                comboBox8.Visible = true;
                comboBox7.Items.AddRange(new string[] { "Базовое", "Среднее", "Высшее" });
                comboBox8.Items.AddRange(new string[] { "Менеджер", "Официант", "Уборщик", "Обслуж. помещения" });
                textBox9.Text = Convert.ToString(dataGridWorkers.CurrentRow.Cells[1].Value);
                textBox10.Text = Convert.ToString(dataGridWorkers.CurrentRow.Cells[2].Value);
                textBox11.Text = Convert.ToString(dataGridWorkers.CurrentRow.Cells[3].Value);
                comboBox7.Text = Convert.ToString(dataGridWorkers.CurrentRow.Cells[4].Value);
                comboBox8.Text = Convert.ToString(dataGridWorkers.CurrentRow.Cells[5].Value);
                textBox14.Text = Convert.ToString(dataGridWorkers.CurrentRow.Cells[6].Value);
            }
            if(TabTable.SelectedIndex == 4)
            {
                metroLabel7.Text = "ID";
                metroLabel8.Text = "Уборка помещения";
                metroLabel6.Text = "Доставка еды";
                metroLabel5.Text = "Экскурсии";
                metroLabel4.Text = "Спорт помещения";
                metroLabel3.Visible = false;
                metroLabel2.Visible = false;
            
                comboBox5.Visible = true;
                comboBox6.Visible = true;
                comboBox7.Visible = true;
                comboBox8.Visible = true;
                comboBox5.Items.AddRange(new string[] { "Включено", "Не включено" });
                comboBox6.Items.AddRange(new string[] { "Включено", "Не включено" });
                comboBox7.Items.AddRange(new string[] { "Включено", "Не включено" });
                comboBox8.Items.AddRange(new string[] { "Включено", "Не включено" });
                textBox9.Text = Convert.ToString(dataGridService.CurrentRow.Cells[0].Value);
                comboBox5.Text = Convert.ToString(dataGridService.CurrentRow.Cells[1].Value);
                comboBox6.Text = Convert.ToString(dataGridService.CurrentRow.Cells[2].Value);
                comboBox7.Text = Convert.ToString(dataGridService.CurrentRow.Cells[3].Value);
                comboBox8.Text = Convert.ToString(dataGridService.CurrentRow.Cells[4].Value);
            }
            id = textBox9.Text;
            materialRaisedButton4.Visible = true;
        }

        SqlCommand cmd = new SqlCommand();
        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            
            metroLabel2.Visible = false;
            metroLabel3.Visible = false;
            metroLabel4.Visible = false;
            metroLabel5.Visible = false;
            metroLabel6.Visible = false;
            metroLabel7.Visible = false;
            metroLabel8.Visible = false;
           
            con.Open();
           
                if (TabTable.SelectedIndex == 0)
                {
                    cmd = new SqlCommand("update Гостиница set Клиент=@2,[Номер комнаты]=@3,Сотрудник=@4,[ID Обслуживания]=@5, [Дата заселения]=@6,[Срок проживания]=@7 where ID=@id", con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@2", comboBox5.Text);
                    cmd.Parameters.AddWithValue("@3", comboBox6.Text);
                    cmd.Parameters.AddWithValue("@4", comboBox8.Text);
                    cmd.Parameters.AddWithValue("@5", comboBox7.Text);
                    cmd.Parameters.AddWithValue("@6", dateBox2.Text);
                    cmd.Parameters.AddWithValue("@7", Convert.ToInt32(textBox15.Text));
                    
                }
                if (TabTable.SelectedIndex == 1)
                {
                    cmd = new SqlCommand("update Клиенты set Фамилия=@fam, Имя=@name,Отчество=@otch,Город=@city,[Серия паспорта]=@serial, [Номер паспорта]=@passp,[Номер телефона]=@tel where Фамилия=@id", con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@fam", textBox9.Text);
                    cmd.Parameters.AddWithValue("@name", textBox10.Text);
                    cmd.Parameters.AddWithValue("@otch", textBox11.Text);
                    cmd.Parameters.AddWithValue("@city", textBox12.Text);
                    cmd.Parameters.AddWithValue("@serial", textBox13.Text);
                    cmd.Parameters.AddWithValue("@passp", Convert.ToInt32(textBox14.Text));
                    cmd.Parameters.AddWithValue("@tel", Convert.ToInt32(textBox15.Text));
                   
                }
                if(TabTable.SelectedIndex == 2)
                {
                    cmd = new SqlCommand("update [Номера гостиницы] set [Номер комнаты]=@1, [Тип номера]=@2,[Занятость]=@3,Стоимость=@4 where [Номер комнаты]=@id", con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@1", textBox9.Text);
                    cmd.Parameters.AddWithValue("@2", comboBox5.Text);
                    cmd.Parameters.AddWithValue("@3", comboBox6.Text);
                    cmd.Parameters.AddWithValue("@4", Convert.ToInt32(textBox12.Text));
                    
                }
                if(TabTable.SelectedIndex == 3)
                {
                    cmd = new SqlCommand("update Сотрудники set Фамилия=@1, Имя=@2,Отчество=@3,Образование=@4,Должность=@5, [Номер телефона]=@6 where Фамилия=@id", con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@1", textBox9.Text);
                    cmd.Parameters.AddWithValue("@2", textBox10.Text);
                    cmd.Parameters.AddWithValue("@3", textBox11.Text);
                    cmd.Parameters.AddWithValue("@4", comboBox7.Text);
                    cmd.Parameters.AddWithValue("@5", comboBox8.Text);
                    cmd.Parameters.AddWithValue("@6", Convert.ToInt32(textBox14.Text));
                    
                }
                if(TabTable.SelectedIndex == 4)
                {
                    cmd = new SqlCommand("update Обслуживание set [Уборка помещения]=@2,[Доставка еды]=@3,Экскурсии=@4,[Спорт помещения]=@5 where [[ID Обслуживания]=@id", con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@2", comboBox5.Text);
                    cmd.Parameters.AddWithValue("@3", comboBox6.Text);
                    cmd.Parameters.AddWithValue("@4", comboBox7.Text);
                    cmd.Parameters.AddWithValue("@5", comboBox8.Text);
                    
                }
                
                MetroFramework.MetroMessageBox.Show(this, "Данные успешно изменены в базе.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                cmd.ExecuteNonQuery();
                materialRaisedButton4.Visible = false;
                clearcombo();
                clearAllTextBoxes();
            try
            {
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this,"Есть пустые поля или они не правильно заполнены. Предупреждение: нельзя изменять поля, которые внесены в главную таблицу", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            con.Close();
            refresh();
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            report rep = new report();
            rep.ShowDialog();
        }

        private void findText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (findText.Text == "")
                {
                    refresh();
                }
                else
                {
                    
                    con.Open();
                    String find = "";
                    DataGridView data = new DataGridView();
                    if (TabTable.SelectedIndex == 0)
                    {
                        
                        if (chooseFindBox.Text == "ID") find = "SELECT * FROM [Гостиница] where [ID] = '" + findText.Text + "'";
                        if (chooseFindBox.Text == "Клиент") find = "SELECT * FROM [Гостиница] where [Клиент] = '" + findText.Text + "'";
                        if(chooseFindBox.Text == "Номер комнаты") find = "SELECT * FROM [Гостиница] where [Номер комнаты] = '" + findText.Text + "'";
                        if (chooseFindBox.Text == "ID Обслуживания") find = "SELECT * FROM [Гостиница] where [ID Обслуживания] = '" + findText.Text + "'";
                        if (chooseFindBox.Text == "Сотрудник") find = "SELECT * FROM [Гостиница] where [Сотрудник] = '" + findText.Text + "'";
                        if (chooseFindBox.Text == "Срок проживания") find = "SELECT * FROM [Гостиница] where [Срок проживания] = '" + findText.Text + "'";
                        if (chooseFindBox.Text == "Общая стоимость") find = "SELECT * FROM [Гостиница] where [Общая стоимость] = '" + findText.Text + "'";
                        data = dataGridHotel;
                    }
                    if (TabTable.SelectedIndex == 1)
                    {
                        if (chooseFindBox.Text == "Фамилия") find = "SELECT * FROM [Клиенты] where [Фамилия] = '" + findText.Text + "'";
                        if (chooseFindBox.Text == "Имя") find = "SELECT * FROM [Клиенты] where [Имя] = '" + findText.Text + "'";
                        if (chooseFindBox.Text == "Отчество") find = "SELECT * FROM [Клиенты] where [Отчество] = '" + findText.Text + "'";
                        if (chooseFindBox.Text == "Город") find = "SELECT * FROM [Клиенты] where [Город] = '" + findText.Text + "'";
                        if (chooseFindBox.Text == "Серия паспорта") find = "SELECT * FROM [Клиенты] where [Серия паспорта] = '" + findText.Text + "'";
                        if (chooseFindBox.Text == "Номер паспорта") find = "SELECT * FROM [Клиенты] where [Номер паспорта] = '" + findText.Text + "'";
                        if (chooseFindBox.Text == "Номер телефона") find = "SELECT * FROM [Клиенты] where [Номер телефона] = '" + findText.Text + "'";
                        data = dataGridClients;
                    }
                    if(TabTable.SelectedIndex == 2)
                    {
                        if (chooseFindBox.Text == "Номер комнаты") find = "SELECT * FROM [Номера гостиницы] where [Номер комнаты] = '" + findText.Text + "'";
                        if (chooseFindBox.Text == "Тип номера") find = "SELECT * FROM [Номера гостиницы] where [Тип номера] = '" + findText.Text + "'";
                        if (chooseFindBox.Text == "Занятость") find = "SELECT * FROM [Номера гостиницы] where [Занятость] = '" + findText.Text + "'";
                        if (chooseFindBox.Text == "Стоимость") find = "SELECT * FROM [Номера гостиницы] where [Стоимость] = '" + findText.Text + "'";
                        data = dataGridRooms;
                    }
                    if(TabTable.SelectedIndex == 3)
                    {
                        if (chooseFindBox.Text == "Фамилия") find = "SELECT * FROM [Сотрудники] where [Фамилия] = '" + findText.Text + "'";
                        if (chooseFindBox.Text == "Имя") find = "SELECT * FROM [Сотрудники] where [Имя] = '" + findText.Text + "'";
                        if (chooseFindBox.Text == "Отчество") find = "SELECT * FROM [Сотрудники] where [Отчество] = '" + findText.Text + "'";
                        if (chooseFindBox.Text == "Образования") find = "SELECT * FROM [Сотрудники] where [Образование] = '" + findText.Text + "'";
                        if (chooseFindBox.Text == "Должность") find = "SELECT * FROM [Сотрудники] where [Должность] = '" + findText.Text + "'";
                        if (chooseFindBox.Text == "Номер телефона") find = "SELECT * FROM [Сотрудники] where [Номер телефона] = '" + findText.Text + "'";
                        data = dataGridWorkers;
                    }
                    if(TabTable.SelectedIndex == 4)
                    {
                        if (chooseFindBox.Text == "ID Обслуживания") find = "SELECT * FROM [Обслуживание] where [[ID Обслуживания] = '" + findText.Text + "'";
                        if (chooseFindBox.Text == "Уборка помещения") find = "SELECT * FROM [Обслуживание] where [Уборка помещения] = '" + findText.Text + "'";
                        if (chooseFindBox.Text == "Доставка еды") find = "SELECT * FROM [Обслуживание] where [Доставка еды] = '" + findText.Text + "'";
                        if (chooseFindBox.Text == "Экскурсии") find = "SELECT * FROM [Обслуживание] where [Экскурсии] = '" + findText.Text + "'";
                        if (chooseFindBox.Text == "Спорт помещения") find = "SELECT * FROM [Обслуживание] where [Спорт помещения] = '" + findText.Text + "'";
                        data = dataGridService;
                    }
                    SqlCommand cmd = new SqlCommand(find, con);
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    data.DataSource = dt;
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            try
            {
                string path = "Deleted.txt";
                Process.Start(path);
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Данных о выселившихся не найдено, возможно они были удалены", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

       

        private void materialRaisedButton5_Click(object sender, EventArgs e)
        {
            File.Delete("Deleted.txt");
            MetroFramework.MetroMessageBox.Show(this, "Данные о выселившихся успешно удалены", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
