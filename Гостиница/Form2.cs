using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using DevExpress.XtraBars.Docking2010;
using System.Data.SqlClient;
using System.Configuration;
using Dapper;

namespace Гостиница
{
    public partial class Form2 : MaterialForm
    {
        public Form2()
        {
            InitializeComponent();
            txtPass.PasswordChar = '*';

        }
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x00020000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        MaterialSkinManager skinManager;
        private void Form2_Load(object sender, EventArgs e)
        {
            
            skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.BlueGrey900, Primary.BlueGrey900, Accent.Amber400, TextShade.WHITE);


        }

        private void windowsUIButtonPanel1_ButtonChecked(object sender, ButtonEventArgs e)
        {

            string tag = ((WindowsUIButton)e.Button).Tag.ToString();
            switch (tag)
            {
                case "admin": {
                        txtUserName.Enabled = true;
                        txtPass.Enabled = true;
                        materialLabel1.Text = "Администратор";
                        break;
                    }
            }
        }

        private void windowsUIButtonPanel1_ButtonUnchecked(object sender, ButtonEventArgs e)
        {
            string tag = ((WindowsUIButton)e.Button).Tag.ToString();
            switch (tag)
            {
                case "admin": {
                        txtUserName.Enabled = false;
                        txtPass.Enabled = false;
                        materialLabel1.Text = "Гость";
                        break;
                    }
            }
        }
        public bool admin=whatadmin;
        static bool whatadmin;
        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            
            if(materialLabel1.Text == "Гость")
            {
                using (Form1 frm = new Form1())
                {
                    this.Hide();
                    frm.ShowDialog();
                }
                whatadmin = false;
            }
            if (materialLabel1.Text == "Администратор")
            {
                whatadmin = true;
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["Гостиница.Properties.Settings.КурсачConnectionString"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed) db.Open();
                    User obj = db.Query<User>($"select * from UserName where UserName = '{txtUserName.Text}'", commandType: CommandType.Text).SingleOrDefault();
                    if (obj != null)
                    {
                        if (obj.Password == txtPass.Text)
                        {
                            using (Form1 frm = new Form1())
                            {
                                this.Hide();
                                frm.ShowDialog();
                            }
                        }
                        else
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Логин или Пароль не введен или введен не правильно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Логин или Пароль не введен или введен не правильно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
            
    }
}
