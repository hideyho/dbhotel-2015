namespace Гостиница
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.номераГостиницыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.курсачDataSet = new Гостиница.КурсачDataSet();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.обслуживаниеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.гостиницаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.клиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.гостиницаTableAdapter = new Гостиница.КурсачDataSetTableAdapters.ГостиницаTableAdapter();
            this.клиентыTableAdapter = new Гостиница.КурсачDataSetTableAdapters.КлиентыTableAdapter();
            this.номера_гостиницыTableAdapter = new Гостиница.КурсачDataSetTableAdapters.Номера_гостиницыTableAdapter();
            this.сотрудникиTableAdapter = new Гостиница.КурсачDataSetTableAdapters.СотрудникиTableAdapter();
            this.обслуживаниеTableAdapter = new Гостиница.КурсачDataSetTableAdapters.ОбслуживаниеTableAdapter();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textBox7 = new MetroFramework.Controls.MetroTextBox();
            this.textBox6 = new MetroFramework.Controls.MetroTextBox();
            this.textBox5 = new MetroFramework.Controls.MetroTextBox();
            this.textBox4 = new MetroFramework.Controls.MetroTextBox();
            this.textBox3 = new MetroFramework.Controls.MetroTextBox();
            this.textBox2 = new MetroFramework.Controls.MetroTextBox();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.tableAdapterManager1 = new Гостиница.КурсачDataSetTableAdapters.TableAdapterManager();
            this.dataGridService = new System.Windows.Forms.DataGridView();
            this.iDОбслуживанияDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.уборкаПомещенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.доставкаЕдыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.экскурсииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.спортПомещенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridWorkers = new System.Windows.Forms.DataGridView();
            this.iDСотрудникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.образованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.должностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерТелефонаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridRooms = new System.Windows.Forms.DataGridView();
            this.номерКомнатыDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типНомераDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.занятостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.стоимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridClients = new System.Windows.Forms.DataGridView();
            this.iDКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.городDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.серияПаспортаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерПаспортаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерТелефонаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabService = new System.Windows.Forms.TabPage();
            this.tabWorkers = new System.Windows.Forms.TabPage();
            this.tabRooms = new System.Windows.Forms.TabPage();
            this.tabClients = new System.Windows.Forms.TabPage();
            this.tabHotel = new System.Windows.Forms.TabPage();
            this.dataGridHotel = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.клиентDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерКомнатыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDОбслуживанияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сотрудникDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаЗаселенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.срокПроживанияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabTable = new MaterialSkin.Controls.MaterialTabControl();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabActions = new DevExpress.XtraTab.XtraTabControl();
            this.tabAdd = new DevExpress.XtraTab.XtraTabPage();
            this.dateBox = new MetroFramework.Controls.MetroDateTime();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.label7 = new MetroFramework.Controls.MetroLabel();
            this.label6 = new MetroFramework.Controls.MetroLabel();
            this.label5 = new MetroFramework.Controls.MetroLabel();
            this.label4 = new MetroFramework.Controls.MetroLabel();
            this.label3 = new MetroFramework.Controls.MetroLabel();
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.label2 = new MetroFramework.Controls.MetroLabel();
            this.comboBox4 = new MetroFramework.Controls.MetroComboBox();
            this.comboBox3 = new MetroFramework.Controls.MetroComboBox();
            this.comboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.comboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.tabDelete = new DevExpress.XtraTab.XtraTabPage();
            this.materialRaisedButton5 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tabEdit = new DevExpress.XtraTab.XtraTabPage();
            this.dateBox2 = new MetroFramework.Controls.MetroDateTime();
            this.materialRaisedButton4 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.comboBox8 = new MetroFramework.Controls.MetroComboBox();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.comboBox7 = new MetroFramework.Controls.MetroComboBox();
            this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.comboBox6 = new MetroFramework.Controls.MetroComboBox();
            this.comboBox5 = new MetroFramework.Controls.MetroComboBox();
            this.textBox9 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.textBox10 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.textBox15 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.textBox11 = new MetroFramework.Controls.MetroTextBox();
            this.textBox12 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.textBox13 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.textBox14 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.materialDivider5 = new MaterialSkin.Controls.MaterialDivider();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.chooseFindBox = new MetroFramework.Controls.MetroComboBox();
            this.findText = new MetroFramework.Controls.MetroTextBox();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialDivider3 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider4 = new MaterialSkin.Controls.MaterialDivider();
            this.materialFlatButton3 = new MaterialSkin.Controls.MaterialFlatButton();
            this.fKГостиницаКлиентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.номераГостиницыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.курсачDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.обслуживаниеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.гостиницаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWorkers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClients)).BeginInit();
            this.tabService.SuspendLayout();
            this.tabWorkers.SuspendLayout();
            this.tabRooms.SuspendLayout();
            this.tabClients.SuspendLayout();
            this.tabHotel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHotel)).BeginInit();
            this.TabTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabActions)).BeginInit();
            this.tabActions.SuspendLayout();
            this.tabAdd.SuspendLayout();
            this.tabDelete.SuspendLayout();
            this.tabEdit.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKГостиницаКлиентыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // номераГостиницыBindingSource
            // 
            this.номераГостиницыBindingSource.DataMember = "Номера гостиницы";
            this.номераГостиницыBindingSource.DataSource = this.курсачDataSet;
            // 
            // курсачDataSet
            // 
            this.курсачDataSet.DataSetName = "КурсачDataSet";
            this.курсачDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this.курсачDataSet;
            // 
            // обслуживаниеBindingSource
            // 
            this.обслуживаниеBindingSource.DataMember = "Обслуживание";
            this.обслуживаниеBindingSource.DataSource = this.курсачDataSet;
            // 
            // гостиницаBindingSource
            // 
            this.гостиницаBindingSource.DataMember = "Гостиница";
            this.гостиницаBindingSource.DataSource = this.курсачDataSet;
            // 
            // клиентыBindingSource
            // 
            this.клиентыBindingSource.DataMember = "Клиенты";
            this.клиентыBindingSource.DataSource = this.курсачDataSet;
            // 
            // гостиницаTableAdapter
            // 
            this.гостиницаTableAdapter.ClearBeforeFill = true;
            // 
            // клиентыTableAdapter
            // 
            this.клиентыTableAdapter.ClearBeforeFill = true;
            // 
            // номера_гостиницыTableAdapter
            // 
            this.номера_гостиницыTableAdapter.ClearBeforeFill = true;
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // обслуживаниеTableAdapter
            // 
            this.обслуживаниеTableAdapter.ClearBeforeFill = true;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(161, 266);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(173, 46);
            this.materialRaisedButton1.TabIndex = 24;
            this.materialRaisedButton1.Text = "Добавить";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            // 
            // 
            // 
            this.textBox7.CustomButton.Image = null;
            this.textBox7.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.textBox7.CustomButton.Name = "";
            this.textBox7.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.textBox7.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox7.CustomButton.TabIndex = 1;
            this.textBox7.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox7.CustomButton.UseSelectable = true;
            this.textBox7.CustomButton.Visible = false;
            this.textBox7.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.textBox7.Icon = ((System.Drawing.Image)(resources.GetObject("textBox7.Icon")));
            this.textBox7.IconRight = true;
            this.textBox7.Lines = new string[0];
            this.textBox7.Location = new System.Drawing.Point(161, 231);
            this.textBox7.MaxLength = 32767;
            this.textBox7.Name = "textBox7";
            this.textBox7.PasswordChar = '\0';
            this.textBox7.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox7.SelectedText = "";
            this.textBox7.SelectionLength = 0;
            this.textBox7.SelectionStart = 0;
            this.textBox7.ShortcutsEnabled = true;
            this.textBox7.ShowClearButton = true;
            this.textBox7.Size = new System.Drawing.Size(173, 29);
            this.textBox7.Style = MetroFramework.MetroColorStyle.Brown;
            this.textBox7.TabIndex = 9;
            this.textBox7.UseCustomBackColor = true;
            this.textBox7.UseSelectable = true;
            this.textBox7.WaterMarkColor = System.Drawing.Color.White;
            this.textBox7.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textBox6
            // 
            // 
            // 
            // 
            this.textBox6.CustomButton.Image = null;
            this.textBox6.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.textBox6.CustomButton.Name = "";
            this.textBox6.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.textBox6.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox6.CustomButton.TabIndex = 1;
            this.textBox6.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox6.CustomButton.UseSelectable = true;
            this.textBox6.CustomButton.Visible = false;
            this.textBox6.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.textBox6.Lines = new string[0];
            this.textBox6.Location = new System.Drawing.Point(161, 196);
            this.textBox6.MaxLength = 32767;
            this.textBox6.Name = "textBox6";
            this.textBox6.PasswordChar = '\0';
            this.textBox6.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox6.SelectedText = "";
            this.textBox6.SelectionLength = 0;
            this.textBox6.SelectionStart = 0;
            this.textBox6.ShortcutsEnabled = true;
            this.textBox6.ShowClearButton = true;
            this.textBox6.Size = new System.Drawing.Size(173, 29);
            this.textBox6.TabIndex = 8;
            this.textBox6.UseCustomBackColor = true;
            this.textBox6.UseSelectable = true;
            this.textBox6.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox6.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textBox5
            // 
            // 
            // 
            // 
            this.textBox5.CustomButton.Image = null;
            this.textBox5.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.textBox5.CustomButton.Name = "";
            this.textBox5.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.textBox5.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox5.CustomButton.TabIndex = 1;
            this.textBox5.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox5.CustomButton.UseSelectable = true;
            this.textBox5.CustomButton.Visible = false;
            this.textBox5.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.textBox5.Lines = new string[0];
            this.textBox5.Location = new System.Drawing.Point(161, 161);
            this.textBox5.MaxLength = 32767;
            this.textBox5.Name = "textBox5";
            this.textBox5.PasswordChar = '\0';
            this.textBox5.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox5.SelectedText = "";
            this.textBox5.SelectionLength = 0;
            this.textBox5.SelectionStart = 0;
            this.textBox5.ShortcutsEnabled = true;
            this.textBox5.ShowClearButton = true;
            this.textBox5.Size = new System.Drawing.Size(173, 29);
            this.textBox5.TabIndex = 7;
            this.textBox5.UseCustomBackColor = true;
            this.textBox5.UseSelectable = true;
            this.textBox5.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox5.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textBox4
            // 
            // 
            // 
            // 
            this.textBox4.CustomButton.Image = null;
            this.textBox4.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.textBox4.CustomButton.Name = "";
            this.textBox4.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.textBox4.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox4.CustomButton.TabIndex = 1;
            this.textBox4.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox4.CustomButton.UseSelectable = true;
            this.textBox4.CustomButton.Visible = false;
            this.textBox4.Enabled = false;
            this.textBox4.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.textBox4.Lines = new string[0];
            this.textBox4.Location = new System.Drawing.Point(161, 126);
            this.textBox4.MaxLength = 32767;
            this.textBox4.Name = "textBox4";
            this.textBox4.PasswordChar = '\0';
            this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox4.SelectedText = "";
            this.textBox4.SelectionLength = 0;
            this.textBox4.SelectionStart = 0;
            this.textBox4.ShortcutsEnabled = true;
            this.textBox4.ShowClearButton = true;
            this.textBox4.Size = new System.Drawing.Size(173, 29);
            this.textBox4.Style = MetroFramework.MetroColorStyle.Brown;
            this.textBox4.TabIndex = 6;
            this.textBox4.UseSelectable = true;
            this.textBox4.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox4.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textBox3
            // 
            // 
            // 
            // 
            this.textBox3.CustomButton.Image = null;
            this.textBox3.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.textBox3.CustomButton.Name = "";
            this.textBox3.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.textBox3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox3.CustomButton.TabIndex = 1;
            this.textBox3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox3.CustomButton.UseSelectable = true;
            this.textBox3.CustomButton.Visible = false;
            this.textBox3.Enabled = false;
            this.textBox3.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.textBox3.Lines = new string[0];
            this.textBox3.Location = new System.Drawing.Point(161, 91);
            this.textBox3.MaxLength = 32767;
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '\0';
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox3.SelectedText = "";
            this.textBox3.SelectionLength = 0;
            this.textBox3.SelectionStart = 0;
            this.textBox3.ShortcutsEnabled = true;
            this.textBox3.ShowClearButton = true;
            this.textBox3.Size = new System.Drawing.Size(173, 29);
            this.textBox3.Style = MetroFramework.MetroColorStyle.Brown;
            this.textBox3.TabIndex = 5;
            this.textBox3.UseSelectable = true;
            this.textBox3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textBox2
            // 
            // 
            // 
            // 
            this.textBox2.CustomButton.Image = null;
            this.textBox2.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.textBox2.CustomButton.Name = "";
            this.textBox2.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.textBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox2.CustomButton.TabIndex = 1;
            this.textBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox2.CustomButton.UseSelectable = true;
            this.textBox2.CustomButton.Visible = false;
            this.textBox2.Enabled = false;
            this.textBox2.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.textBox2.Lines = new string[0];
            this.textBox2.Location = new System.Drawing.Point(161, 56);
            this.textBox2.MaxLength = 32767;
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '\0';
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox2.SelectedText = "";
            this.textBox2.SelectionLength = 0;
            this.textBox2.SelectionStart = 0;
            this.textBox2.ShortcutsEnabled = true;
            this.textBox2.ShowClearButton = true;
            this.textBox2.Size = new System.Drawing.Size(173, 29);
            this.textBox2.Style = MetroFramework.MetroColorStyle.Brown;
            this.textBox2.TabIndex = 4;
            this.textBox2.UseSelectable = true;
            this.textBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Metropolis";
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.UpdateOrder = Гостиница.КурсачDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.ГостиницаTableAdapter = this.гостиницаTableAdapter;
            this.tableAdapterManager1.КлиентыTableAdapter = this.клиентыTableAdapter;
            this.tableAdapterManager1.Номера_гостиницыTableAdapter = this.номера_гостиницыTableAdapter;
            this.tableAdapterManager1.ОбслуживаниеTableAdapter = this.обслуживаниеTableAdapter;
            this.tableAdapterManager1.СотрудникиTableAdapter = this.сотрудникиTableAdapter;
            // 
            // dataGridService
            // 
            this.dataGridService.AutoGenerateColumns = false;
            this.dataGridService.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridService.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.dataGridService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridService.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDОбслуживанияDataGridViewTextBoxColumn1,
            this.уборкаПомещенияDataGridViewTextBoxColumn,
            this.доставкаЕдыDataGridViewTextBoxColumn,
            this.экскурсииDataGridViewTextBoxColumn,
            this.спортПомещенияDataGridViewTextBoxColumn});
            this.dataGridService.DataSource = this.обслуживаниеBindingSource;
            this.dataGridService.GridColor = System.Drawing.Color.Black;
            this.dataGridService.Location = new System.Drawing.Point(6, 0);
            this.dataGridService.MultiSelect = false;
            this.dataGridService.Name = "dataGridService";
            this.dataGridService.ReadOnly = true;
            this.dataGridService.Size = new System.Drawing.Size(844, 539);
            this.dataGridService.TabIndex = 0;
            // 
            // iDОбслуживанияDataGridViewTextBoxColumn1
            // 
            this.iDОбслуживанияDataGridViewTextBoxColumn1.DataPropertyName = "[ID Обслуживания";
            this.iDОбслуживанияDataGridViewTextBoxColumn1.HeaderText = "ID Обслуживания";
            this.iDОбслуживанияDataGridViewTextBoxColumn1.Name = "iDОбслуживанияDataGridViewTextBoxColumn1";
            this.iDОбслуживанияDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // уборкаПомещенияDataGridViewTextBoxColumn
            // 
            this.уборкаПомещенияDataGridViewTextBoxColumn.DataPropertyName = "Уборка помещения";
            this.уборкаПомещенияDataGridViewTextBoxColumn.HeaderText = "Уборка помещения";
            this.уборкаПомещенияDataGridViewTextBoxColumn.Name = "уборкаПомещенияDataGridViewTextBoxColumn";
            this.уборкаПомещенияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // доставкаЕдыDataGridViewTextBoxColumn
            // 
            this.доставкаЕдыDataGridViewTextBoxColumn.DataPropertyName = "Доставка еды";
            this.доставкаЕдыDataGridViewTextBoxColumn.HeaderText = "Доставка еды";
            this.доставкаЕдыDataGridViewTextBoxColumn.Name = "доставкаЕдыDataGridViewTextBoxColumn";
            this.доставкаЕдыDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // экскурсииDataGridViewTextBoxColumn
            // 
            this.экскурсииDataGridViewTextBoxColumn.DataPropertyName = "Экскурсии";
            this.экскурсииDataGridViewTextBoxColumn.HeaderText = "Экскурсии";
            this.экскурсииDataGridViewTextBoxColumn.Name = "экскурсииDataGridViewTextBoxColumn";
            this.экскурсииDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // спортПомещенияDataGridViewTextBoxColumn
            // 
            this.спортПомещенияDataGridViewTextBoxColumn.DataPropertyName = "Спорт помещения";
            this.спортПомещенияDataGridViewTextBoxColumn.HeaderText = "Спорт помещения";
            this.спортПомещенияDataGridViewTextBoxColumn.Name = "спортПомещенияDataGridViewTextBoxColumn";
            this.спортПомещенияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridWorkers
            // 
            this.dataGridWorkers.AutoGenerateColumns = false;
            this.dataGridWorkers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridWorkers.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.dataGridWorkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridWorkers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDСотрудникаDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn1,
            this.имяDataGridViewTextBoxColumn1,
            this.отчествоDataGridViewTextBoxColumn1,
            this.образованиеDataGridViewTextBoxColumn,
            this.должностьDataGridViewTextBoxColumn,
            this.номерТелефонаDataGridViewTextBoxColumn1});
            this.dataGridWorkers.DataSource = this.сотрудникиBindingSource;
            this.dataGridWorkers.GridColor = System.Drawing.Color.Black;
            this.dataGridWorkers.Location = new System.Drawing.Point(6, 0);
            this.dataGridWorkers.MultiSelect = false;
            this.dataGridWorkers.Name = "dataGridWorkers";
            this.dataGridWorkers.ReadOnly = true;
            this.dataGridWorkers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridWorkers.Size = new System.Drawing.Size(844, 539);
            this.dataGridWorkers.TabIndex = 0;
            // 
            // iDСотрудникаDataGridViewTextBoxColumn
            // 
            this.iDСотрудникаDataGridViewTextBoxColumn.DataPropertyName = "ID Сотрудника";
            this.iDСотрудникаDataGridViewTextBoxColumn.HeaderText = "ID Сотрудника";
            this.iDСотрудникаDataGridViewTextBoxColumn.Name = "iDСотрудникаDataGridViewTextBoxColumn";
            this.iDСотрудникаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // фамилияDataGridViewTextBoxColumn1
            // 
            this.фамилияDataGridViewTextBoxColumn1.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn1.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn1.Name = "фамилияDataGridViewTextBoxColumn1";
            this.фамилияDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // имяDataGridViewTextBoxColumn1
            // 
            this.имяDataGridViewTextBoxColumn1.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn1.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn1.Name = "имяDataGridViewTextBoxColumn1";
            this.имяDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // отчествоDataGridViewTextBoxColumn1
            // 
            this.отчествоDataGridViewTextBoxColumn1.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn1.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn1.Name = "отчествоDataGridViewTextBoxColumn1";
            this.отчествоDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // образованиеDataGridViewTextBoxColumn
            // 
            this.образованиеDataGridViewTextBoxColumn.DataPropertyName = "Образование";
            this.образованиеDataGridViewTextBoxColumn.HeaderText = "Образование";
            this.образованиеDataGridViewTextBoxColumn.Name = "образованиеDataGridViewTextBoxColumn";
            this.образованиеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // должностьDataGridViewTextBoxColumn
            // 
            this.должностьDataGridViewTextBoxColumn.DataPropertyName = "Должность";
            this.должностьDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.должностьDataGridViewTextBoxColumn.Name = "должностьDataGridViewTextBoxColumn";
            this.должностьDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // номерТелефонаDataGridViewTextBoxColumn1
            // 
            this.номерТелефонаDataGridViewTextBoxColumn1.DataPropertyName = "Номер телефона";
            this.номерТелефонаDataGridViewTextBoxColumn1.HeaderText = "Номер телефона";
            this.номерТелефонаDataGridViewTextBoxColumn1.Name = "номерТелефонаDataGridViewTextBoxColumn1";
            this.номерТелефонаDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridRooms
            // 
            this.dataGridRooms.AutoGenerateColumns = false;
            this.dataGridRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridRooms.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.dataGridRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерКомнатыDataGridViewTextBoxColumn1,
            this.типНомераDataGridViewTextBoxColumn,
            this.занятостьDataGridViewTextBoxColumn,
            this.стоимостьDataGridViewTextBoxColumn});
            this.dataGridRooms.DataSource = this.номераГостиницыBindingSource;
            this.dataGridRooms.GridColor = System.Drawing.Color.Black;
            this.dataGridRooms.Location = new System.Drawing.Point(6, 0);
            this.dataGridRooms.MultiSelect = false;
            this.dataGridRooms.Name = "dataGridRooms";
            this.dataGridRooms.ReadOnly = true;
            this.dataGridRooms.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridRooms.Size = new System.Drawing.Size(844, 539);
            this.dataGridRooms.TabIndex = 0;
            // 
            // номерКомнатыDataGridViewTextBoxColumn1
            // 
            this.номерКомнатыDataGridViewTextBoxColumn1.DataPropertyName = "Номер комнаты";
            this.номерКомнатыDataGridViewTextBoxColumn1.HeaderText = "Номер комнаты";
            this.номерКомнатыDataGridViewTextBoxColumn1.Name = "номерКомнатыDataGridViewTextBoxColumn1";
            this.номерКомнатыDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // типНомераDataGridViewTextBoxColumn
            // 
            this.типНомераDataGridViewTextBoxColumn.DataPropertyName = "Тип номера";
            this.типНомераDataGridViewTextBoxColumn.HeaderText = "Тип номера";
            this.типНомераDataGridViewTextBoxColumn.Name = "типНомераDataGridViewTextBoxColumn";
            this.типНомераDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // занятостьDataGridViewTextBoxColumn
            // 
            this.занятостьDataGridViewTextBoxColumn.DataPropertyName = "Занятость";
            this.занятостьDataGridViewTextBoxColumn.HeaderText = "Занятость";
            this.занятостьDataGridViewTextBoxColumn.Name = "занятостьDataGridViewTextBoxColumn";
            this.занятостьDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // стоимостьDataGridViewTextBoxColumn
            // 
            this.стоимостьDataGridViewTextBoxColumn.DataPropertyName = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.стоимостьDataGridViewTextBoxColumn.Name = "стоимостьDataGridViewTextBoxColumn";
            this.стоимостьDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridClients
            // 
            this.dataGridClients.AutoGenerateColumns = false;
            this.dataGridClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridClients.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.dataGridClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDКлиентаDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.городDataGridViewTextBoxColumn,
            this.серияПаспортаDataGridViewTextBoxColumn,
            this.номерПаспортаDataGridViewTextBoxColumn,
            this.номерТелефонаDataGridViewTextBoxColumn});
            this.dataGridClients.DataSource = this.клиентыBindingSource;
            this.dataGridClients.GridColor = System.Drawing.Color.Black;
            this.dataGridClients.Location = new System.Drawing.Point(6, 0);
            this.dataGridClients.MultiSelect = false;
            this.dataGridClients.Name = "dataGridClients";
            this.dataGridClients.ReadOnly = true;
            this.dataGridClients.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridClients.Size = new System.Drawing.Size(846, 539);
            this.dataGridClients.TabIndex = 0;
            // 
            // iDКлиентаDataGridViewTextBoxColumn
            // 
            this.iDКлиентаDataGridViewTextBoxColumn.DataPropertyName = "ID Клиента";
            this.iDКлиентаDataGridViewTextBoxColumn.HeaderText = "ID Клиента";
            this.iDКлиентаDataGridViewTextBoxColumn.Name = "iDКлиентаDataGridViewTextBoxColumn";
            this.iDКлиентаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            this.фамилияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            this.имяDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            this.отчествоDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // городDataGridViewTextBoxColumn
            // 
            this.городDataGridViewTextBoxColumn.DataPropertyName = "Город";
            this.городDataGridViewTextBoxColumn.HeaderText = "Город";
            this.городDataGridViewTextBoxColumn.Name = "городDataGridViewTextBoxColumn";
            this.городDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // серияПаспортаDataGridViewTextBoxColumn
            // 
            this.серияПаспортаDataGridViewTextBoxColumn.DataPropertyName = "Серия паспорта";
            this.серияПаспортаDataGridViewTextBoxColumn.HeaderText = "Серия паспорта";
            this.серияПаспортаDataGridViewTextBoxColumn.Name = "серияПаспортаDataGridViewTextBoxColumn";
            this.серияПаспортаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // номерПаспортаDataGridViewTextBoxColumn
            // 
            this.номерПаспортаDataGridViewTextBoxColumn.DataPropertyName = "Номер паспорта";
            this.номерПаспортаDataGridViewTextBoxColumn.HeaderText = "Номер паспорта";
            this.номерПаспортаDataGridViewTextBoxColumn.Name = "номерПаспортаDataGridViewTextBoxColumn";
            this.номерПаспортаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // номерТелефонаDataGridViewTextBoxColumn
            // 
            this.номерТелефонаDataGridViewTextBoxColumn.DataPropertyName = "Номер телефона";
            this.номерТелефонаDataGridViewTextBoxColumn.HeaderText = "Номер телефона";
            this.номерТелефонаDataGridViewTextBoxColumn.Name = "номерТелефонаDataGridViewTextBoxColumn";
            this.номерТелефонаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tabService
            // 
            this.tabService.Controls.Add(this.dataGridService);
            this.tabService.Location = new System.Drawing.Point(4, 22);
            this.tabService.Name = "tabService";
            this.tabService.Padding = new System.Windows.Forms.Padding(3);
            this.tabService.Size = new System.Drawing.Size(852, 515);
            this.tabService.TabIndex = 4;
            this.tabService.Text = "Обслуживание";
            this.tabService.UseVisualStyleBackColor = true;
            // 
            // tabWorkers
            // 
            this.tabWorkers.Controls.Add(this.dataGridWorkers);
            this.tabWorkers.Location = new System.Drawing.Point(4, 22);
            this.tabWorkers.Name = "tabWorkers";
            this.tabWorkers.Padding = new System.Windows.Forms.Padding(3);
            this.tabWorkers.Size = new System.Drawing.Size(852, 515);
            this.tabWorkers.TabIndex = 3;
            this.tabWorkers.Text = "Сотрудники";
            this.tabWorkers.UseVisualStyleBackColor = true;
            // 
            // tabRooms
            // 
            this.tabRooms.Controls.Add(this.dataGridRooms);
            this.tabRooms.Location = new System.Drawing.Point(4, 22);
            this.tabRooms.Name = "tabRooms";
            this.tabRooms.Padding = new System.Windows.Forms.Padding(3);
            this.tabRooms.Size = new System.Drawing.Size(852, 515);
            this.tabRooms.TabIndex = 2;
            this.tabRooms.Text = "Номера";
            this.tabRooms.UseVisualStyleBackColor = true;
            // 
            // tabClients
            // 
            this.tabClients.Controls.Add(this.dataGridClients);
            this.tabClients.Location = new System.Drawing.Point(4, 22);
            this.tabClients.Name = "tabClients";
            this.tabClients.Padding = new System.Windows.Forms.Padding(3);
            this.tabClients.Size = new System.Drawing.Size(852, 515);
            this.tabClients.TabIndex = 1;
            this.tabClients.Text = "Клиенты";
            this.tabClients.UseVisualStyleBackColor = true;
            // 
            // tabHotel
            // 
            this.tabHotel.Controls.Add(this.dataGridHotel);
            this.tabHotel.Location = new System.Drawing.Point(4, 22);
            this.tabHotel.Name = "tabHotel";
            this.tabHotel.Padding = new System.Windows.Forms.Padding(3);
            this.tabHotel.Size = new System.Drawing.Size(852, 515);
            this.tabHotel.TabIndex = 0;
            this.tabHotel.Text = "Гостиница";
            this.tabHotel.UseVisualStyleBackColor = true;
            // 
            // dataGridHotel
            // 
            this.dataGridHotel.AutoGenerateColumns = false;
            this.dataGridHotel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridHotel.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.dataGridHotel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHotel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.клиентDataGridViewTextBoxColumn,
            this.номерКомнатыDataGridViewTextBoxColumn,
            this.iDОбслуживанияDataGridViewTextBoxColumn,
            this.сотрудникDataGridViewTextBoxColumn,
            this.датаЗаселенияDataGridViewTextBoxColumn,
            this.срокПроживанияDataGridViewTextBoxColumn});
            this.dataGridHotel.DataSource = this.гостиницаBindingSource;
            this.dataGridHotel.GridColor = System.Drawing.Color.Black;
            this.dataGridHotel.Location = new System.Drawing.Point(6, 0);
            this.dataGridHotel.MultiSelect = false;
            this.dataGridHotel.Name = "dataGridHotel";
            this.dataGridHotel.ReadOnly = true;
            this.dataGridHotel.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridHotel.Size = new System.Drawing.Size(844, 539);
            this.dataGridHotel.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // клиентDataGridViewTextBoxColumn
            // 
            this.клиентDataGridViewTextBoxColumn.DataPropertyName = "Клиент";
            this.клиентDataGridViewTextBoxColumn.HeaderText = "Клиент";
            this.клиентDataGridViewTextBoxColumn.Name = "клиентDataGridViewTextBoxColumn";
            this.клиентDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // номерКомнатыDataGridViewTextBoxColumn
            // 
            this.номерКомнатыDataGridViewTextBoxColumn.DataPropertyName = "Номер комнаты";
            this.номерКомнатыDataGridViewTextBoxColumn.HeaderText = "Номер комнаты";
            this.номерКомнатыDataGridViewTextBoxColumn.Name = "номерКомнатыDataGridViewTextBoxColumn";
            this.номерКомнатыDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDОбслуживанияDataGridViewTextBoxColumn
            // 
            this.iDОбслуживанияDataGridViewTextBoxColumn.DataPropertyName = "ID Обслуживания";
            this.iDОбслуживанияDataGridViewTextBoxColumn.HeaderText = "ID Обслуживания";
            this.iDОбслуживанияDataGridViewTextBoxColumn.Name = "iDОбслуживанияDataGridViewTextBoxColumn";
            this.iDОбслуживанияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // сотрудникDataGridViewTextBoxColumn
            // 
            this.сотрудникDataGridViewTextBoxColumn.DataPropertyName = "Сотрудник";
            this.сотрудникDataGridViewTextBoxColumn.HeaderText = "Сотрудник";
            this.сотрудникDataGridViewTextBoxColumn.Name = "сотрудникDataGridViewTextBoxColumn";
            this.сотрудникDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // датаЗаселенияDataGridViewTextBoxColumn
            // 
            this.датаЗаселенияDataGridViewTextBoxColumn.DataPropertyName = "Дата заселения";
            this.датаЗаселенияDataGridViewTextBoxColumn.HeaderText = "Дата заселения";
            this.датаЗаселенияDataGridViewTextBoxColumn.Name = "датаЗаселенияDataGridViewTextBoxColumn";
            this.датаЗаселенияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // срокПроживанияDataGridViewTextBoxColumn
            // 
            this.срокПроживанияDataGridViewTextBoxColumn.DataPropertyName = "Срок проживания";
            this.срокПроживанияDataGridViewTextBoxColumn.HeaderText = "Срок проживания (месяцы)";
            this.срокПроживанияDataGridViewTextBoxColumn.Name = "срокПроживанияDataGridViewTextBoxColumn";
            this.срокПроживанияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TabTable
            // 
            this.TabTable.Controls.Add(this.tabHotel);
            this.TabTable.Controls.Add(this.tabClients);
            this.TabTable.Controls.Add(this.tabRooms);
            this.TabTable.Controls.Add(this.tabWorkers);
            this.TabTable.Controls.Add(this.tabService);
            this.TabTable.Depth = 0;
            this.TabTable.Location = new System.Drawing.Point(-5, 101);
            this.TabTable.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabTable.Name = "TabTable";
            this.TabTable.SelectedIndex = 0;
            this.TabTable.Size = new System.Drawing.Size(860, 541);
            this.TabTable.TabIndex = 4;
            this.TabTable.SelectedIndexChanged += new System.EventHandler(this.tableChanged);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.TabTable;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(-5, 76);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1256, 25);
            this.materialTabSelector1.TabIndex = 5;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // tabActions
            // 
            this.tabActions.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Right;
            this.tabActions.Location = new System.Drawing.Point(857, 101);
            this.tabActions.LookAndFeel.SkinName = "Metropolis";
            this.tabActions.Name = "tabActions";
            this.tabActions.SelectedTabPage = this.tabAdd;
            this.tabActions.Size = new System.Drawing.Size(380, 542);
            this.tabActions.TabIndex = 6;
            this.tabActions.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabAdd,
            this.tabDelete,
            this.tabEdit,
            this.xtraTabPage1});
            // 
            // tabAdd
            // 
            this.tabAdd.Controls.Add(this.textBox1);
            this.tabAdd.Controls.Add(this.dateBox);
            this.tabAdd.Controls.Add(this.materialDivider1);
            this.tabAdd.Controls.Add(this.label7);
            this.tabAdd.Controls.Add(this.label6);
            this.tabAdd.Controls.Add(this.label5);
            this.tabAdd.Controls.Add(this.label4);
            this.tabAdd.Controls.Add(this.label3);
            this.tabAdd.Controls.Add(this.label1);
            this.tabAdd.Controls.Add(this.label2);
            this.tabAdd.Controls.Add(this.comboBox4);
            this.tabAdd.Controls.Add(this.comboBox3);
            this.tabAdd.Controls.Add(this.comboBox2);
            this.tabAdd.Controls.Add(this.comboBox1);
            this.tabAdd.Controls.Add(this.materialRaisedButton1);
            this.tabAdd.Controls.Add(this.textBox2);
            this.tabAdd.Controls.Add(this.textBox7);
            this.tabAdd.Controls.Add(this.textBox3);
            this.tabAdd.Controls.Add(this.textBox4);
            this.tabAdd.Controls.Add(this.textBox5);
            this.tabAdd.Controls.Add(this.textBox6);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Size = new System.Drawing.Size(354, 540);
            this.tabAdd.Text = "Добавление";
            // 
            // dateBox
            // 
            this.dateBox.CustomFormat = "yyyy-MM-dd";
            this.dateBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateBox.Location = new System.Drawing.Point(161, 196);
            this.dateBox.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(173, 29);
            this.dateBox.TabIndex = 42;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(145, 21);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(2, 239);
            this.materialDivider1.TabIndex = 41;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 19);
            this.label7.TabIndex = 39;
            this.label7.Text = "Срок проживание";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 19);
            this.label6.TabIndex = 38;
            this.label6.Text = "Дата заселения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 19);
            this.label5.TabIndex = 37;
            this.label5.Text = "Сотрудник";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 19);
            this.label4.TabIndex = 36;
            this.label4.Text = "ID Обслуживания";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 19);
            this.label3.TabIndex = 35;
            this.label3.Text = "Номер комнаты";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 19);
            this.label1.TabIndex = 34;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 33;
            this.label2.Text = "Клиент";
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.сотрудникиBindingSource;
            this.comboBox4.DisplayMember = "Фамилия";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.ItemHeight = 23;
            this.comboBox4.Location = new System.Drawing.Point(161, 161);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(173, 29);
            this.comboBox4.TabIndex = 29;
            this.comboBox4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.comboBox4.UseSelectable = true;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.обслуживаниеBindingSource;
            this.comboBox3.DisplayMember = "[ID Обслуживания";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.ItemHeight = 23;
            this.comboBox3.Location = new System.Drawing.Point(161, 126);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(173, 29);
            this.comboBox3.TabIndex = 28;
            this.comboBox3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.comboBox3.UseSelectable = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.номераГостиницыBindingSource;
            this.comboBox2.DisplayMember = "Номер комнаты";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.ItemHeight = 23;
            this.comboBox2.Location = new System.Drawing.Point(161, 91);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(173, 29);
            this.comboBox2.TabIndex = 27;
            this.comboBox2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.comboBox2.UseSelectable = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.клиентыBindingSource;
            this.comboBox1.DisplayMember = "Фамилия";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 23;
            this.comboBox1.Location = new System.Drawing.Point(161, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 29);
            this.comboBox1.TabIndex = 26;
            this.comboBox1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.comboBox1.UseSelectable = true;
            // 
            // tabDelete
            // 
            this.tabDelete.Controls.Add(this.materialRaisedButton5);
            this.tabDelete.Controls.Add(this.materialRaisedButton2);
            this.tabDelete.Name = "tabDelete";
            this.tabDelete.Size = new System.Drawing.Size(354, 540);
            this.tabDelete.Text = "Удаление";
            // 
            // materialRaisedButton5
            // 
            this.materialRaisedButton5.Depth = 0;
            this.materialRaisedButton5.Location = new System.Drawing.Point(98, 78);
            this.materialRaisedButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton5.Name = "materialRaisedButton5";
            this.materialRaisedButton5.Primary = true;
            this.materialRaisedButton5.Size = new System.Drawing.Size(176, 52);
            this.materialRaisedButton5.TabIndex = 7;
            this.materialRaisedButton5.Text = "Удалить выселившихся";
            this.materialRaisedButton5.UseVisualStyleBackColor = true;
            this.materialRaisedButton5.Click += new System.EventHandler(this.materialRaisedButton5_Click);
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(98, 21);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(176, 51);
            this.materialRaisedButton2.TabIndex = 6;
            this.materialRaisedButton2.Text = "Удалить";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // tabEdit
            // 
            this.tabEdit.Controls.Add(this.dateBox2);
            this.tabEdit.Controls.Add(this.materialRaisedButton4);
            this.tabEdit.Controls.Add(this.comboBox8);
            this.tabEdit.Controls.Add(this.materialDivider2);
            this.tabEdit.Controls.Add(this.comboBox7);
            this.tabEdit.Controls.Add(this.materialRaisedButton3);
            this.tabEdit.Controls.Add(this.comboBox6);
            this.tabEdit.Controls.Add(this.comboBox5);
            this.tabEdit.Controls.Add(this.textBox9);
            this.tabEdit.Controls.Add(this.metroLabel2);
            this.tabEdit.Controls.Add(this.textBox10);
            this.tabEdit.Controls.Add(this.metroLabel3);
            this.tabEdit.Controls.Add(this.textBox15);
            this.tabEdit.Controls.Add(this.metroLabel4);
            this.tabEdit.Controls.Add(this.textBox11);
            this.tabEdit.Controls.Add(this.textBox12);
            this.tabEdit.Controls.Add(this.metroLabel5);
            this.tabEdit.Controls.Add(this.textBox13);
            this.tabEdit.Controls.Add(this.metroLabel6);
            this.tabEdit.Controls.Add(this.textBox14);
            this.tabEdit.Controls.Add(this.metroLabel7);
            this.tabEdit.Controls.Add(this.metroLabel8);
            this.tabEdit.Name = "tabEdit";
            this.tabEdit.Size = new System.Drawing.Size(354, 540);
            this.tabEdit.Text = "Редактирование";
            // 
            // dateBox2
            // 
            this.dateBox2.CustomFormat = "yyyy-MM-dd";
            this.dateBox2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateBox2.Location = new System.Drawing.Point(162, 238);
            this.dateBox2.MinimumSize = new System.Drawing.Size(4, 29);
            this.dateBox2.Name = "dateBox2";
            this.dateBox2.Size = new System.Drawing.Size(173, 29);
            this.dateBox2.TabIndex = 64;
            this.dateBox2.Visible = false;
            // 
            // materialRaisedButton4
            // 
            this.materialRaisedButton4.Depth = 0;
            this.materialRaisedButton4.Location = new System.Drawing.Point(162, 308);
            this.materialRaisedButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton4.Name = "materialRaisedButton4";
            this.materialRaisedButton4.Primary = true;
            this.materialRaisedButton4.Size = new System.Drawing.Size(173, 38);
            this.materialRaisedButton4.TabIndex = 24;
            this.materialRaisedButton4.Text = "Применить изменения";
            this.materialRaisedButton4.UseVisualStyleBackColor = true;
            this.materialRaisedButton4.Visible = false;
            this.materialRaisedButton4.Click += new System.EventHandler(this.materialRaisedButton4_Click);
            // 
            // comboBox8
            // 
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.ItemHeight = 23;
            this.comboBox8.Location = new System.Drawing.Point(162, 203);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(173, 29);
            this.comboBox8.TabIndex = 54;
            this.comboBox8.Theme = MetroFramework.MetroThemeStyle.Light;
            this.comboBox8.UseSelectable = true;
            this.comboBox8.Visible = false;
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(147, 62);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(2, 239);
            this.materialDivider2.TabIndex = 63;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.ItemHeight = 23;
            this.comboBox7.Location = new System.Drawing.Point(162, 168);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(173, 29);
            this.comboBox7.TabIndex = 53;
            this.comboBox7.Theme = MetroFramework.MetroThemeStyle.Light;
            this.comboBox7.UseSelectable = true;
            this.comboBox7.Visible = false;
            // 
            // materialRaisedButton3
            // 
            this.materialRaisedButton3.Depth = 0;
            this.materialRaisedButton3.Location = new System.Drawing.Point(162, 21);
            this.materialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton3.Name = "materialRaisedButton3";
            this.materialRaisedButton3.Primary = true;
            this.materialRaisedButton3.Size = new System.Drawing.Size(173, 35);
            this.materialRaisedButton3.TabIndex = 23;
            this.materialRaisedButton3.Text = "Внести";
            this.materialRaisedButton3.UseVisualStyleBackColor = true;
            this.materialRaisedButton3.Click += new System.EventHandler(this.materialRaisedButton3_Click);
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.ItemHeight = 23;
            this.comboBox6.Location = new System.Drawing.Point(162, 133);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(173, 29);
            this.comboBox6.TabIndex = 52;
            this.comboBox6.Theme = MetroFramework.MetroThemeStyle.Light;
            this.comboBox6.UseSelectable = true;
            this.comboBox6.Visible = false;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.ItemHeight = 23;
            this.comboBox5.Location = new System.Drawing.Point(162, 98);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(173, 29);
            this.comboBox5.TabIndex = 51;
            this.comboBox5.Theme = MetroFramework.MetroThemeStyle.Light;
            this.comboBox5.UseSelectable = true;
            this.comboBox5.Visible = false;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            this.textBox9.CustomButton.Image = null;
            this.textBox9.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.textBox9.CustomButton.Name = "";
            this.textBox9.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.textBox9.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox9.CustomButton.TabIndex = 1;
            this.textBox9.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox9.CustomButton.UseSelectable = true;
            this.textBox9.CustomButton.Visible = false;
            this.textBox9.Enabled = false;
            this.textBox9.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.textBox9.ForeColor = System.Drawing.Color.Transparent;
            this.textBox9.Icon = ((System.Drawing.Image)(resources.GetObject("textBox9.Icon")));
            this.textBox9.IconRight = true;
            this.textBox9.Lines = new string[0];
            this.textBox9.Location = new System.Drawing.Point(162, 62);
            this.textBox9.MaxLength = 32767;
            this.textBox9.Name = "textBox9";
            this.textBox9.PasswordChar = '\0';
            this.textBox9.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox9.SelectedText = "";
            this.textBox9.SelectionLength = 0;
            this.textBox9.SelectionStart = 0;
            this.textBox9.ShortcutsEnabled = true;
            this.textBox9.ShowClearButton = true;
            this.textBox9.Size = new System.Drawing.Size(173, 29);
            this.textBox9.Style = MetroFramework.MetroColorStyle.Brown;
            this.textBox9.TabIndex = 43;
            this.textBox9.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox9.UseCustomBackColor = true;
            this.textBox9.UseSelectable = true;
            this.textBox9.WaterMarkColor = System.Drawing.Color.Maroon;
            this.textBox9.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(15, 277);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(122, 19);
            this.metroLabel2.TabIndex = 61;
            this.metroLabel2.Text = "Срок проживание";
            // 
            // textBox10
            // 
            // 
            // 
            // 
            this.textBox10.CustomButton.Image = null;
            this.textBox10.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.textBox10.CustomButton.Name = "";
            this.textBox10.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.textBox10.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox10.CustomButton.TabIndex = 1;
            this.textBox10.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox10.CustomButton.UseSelectable = true;
            this.textBox10.CustomButton.Visible = false;
            this.textBox10.Enabled = false;
            this.textBox10.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.textBox10.Lines = new string[0];
            this.textBox10.Location = new System.Drawing.Point(162, 98);
            this.textBox10.MaxLength = 32767;
            this.textBox10.Name = "textBox10";
            this.textBox10.PasswordChar = '\0';
            this.textBox10.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox10.SelectedText = "";
            this.textBox10.SelectionLength = 0;
            this.textBox10.SelectionStart = 0;
            this.textBox10.ShortcutsEnabled = true;
            this.textBox10.ShowClearButton = true;
            this.textBox10.Size = new System.Drawing.Size(173, 29);
            this.textBox10.Style = MetroFramework.MetroColorStyle.Brown;
            this.textBox10.TabIndex = 44;
            this.textBox10.UseCustomBackColor = true;
            this.textBox10.UseSelectable = true;
            this.textBox10.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox10.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(15, 243);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(104, 19);
            this.metroLabel3.TabIndex = 60;
            this.metroLabel3.Text = "Дата заселения";
            // 
            // textBox15
            // 
            this.textBox15.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            // 
            // 
            // 
            this.textBox15.CustomButton.Image = null;
            this.textBox15.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.textBox15.CustomButton.Name = "";
            this.textBox15.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.textBox15.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox15.CustomButton.TabIndex = 1;
            this.textBox15.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox15.CustomButton.UseSelectable = true;
            this.textBox15.CustomButton.Visible = false;
            this.textBox15.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.textBox15.Icon = ((System.Drawing.Image)(resources.GetObject("textBox15.Icon")));
            this.textBox15.IconRight = true;
            this.textBox15.Lines = new string[0];
            this.textBox15.Location = new System.Drawing.Point(162, 273);
            this.textBox15.MaxLength = 32767;
            this.textBox15.Name = "textBox15";
            this.textBox15.PasswordChar = '\0';
            this.textBox15.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox15.SelectedText = "";
            this.textBox15.SelectionLength = 0;
            this.textBox15.SelectionStart = 0;
            this.textBox15.ShortcutsEnabled = true;
            this.textBox15.ShowClearButton = true;
            this.textBox15.Size = new System.Drawing.Size(173, 29);
            this.textBox15.Style = MetroFramework.MetroColorStyle.Brown;
            this.textBox15.TabIndex = 49;
            this.textBox15.UseCustomBackColor = true;
            this.textBox15.UseSelectable = true;
            this.textBox15.WaterMarkColor = System.Drawing.Color.White;
            this.textBox15.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(16, 207);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(73, 19);
            this.metroLabel4.TabIndex = 59;
            this.metroLabel4.Text = "Сотрудник";
            // 
            // textBox11
            // 
            // 
            // 
            // 
            this.textBox11.CustomButton.Image = null;
            this.textBox11.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.textBox11.CustomButton.Name = "";
            this.textBox11.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.textBox11.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox11.CustomButton.TabIndex = 1;
            this.textBox11.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox11.CustomButton.UseSelectable = true;
            this.textBox11.CustomButton.Visible = false;
            this.textBox11.Enabled = false;
            this.textBox11.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.textBox11.Lines = new string[0];
            this.textBox11.Location = new System.Drawing.Point(162, 133);
            this.textBox11.MaxLength = 32767;
            this.textBox11.Name = "textBox11";
            this.textBox11.PasswordChar = '\0';
            this.textBox11.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox11.SelectedText = "";
            this.textBox11.SelectionLength = 0;
            this.textBox11.SelectionStart = 0;
            this.textBox11.ShortcutsEnabled = true;
            this.textBox11.ShowClearButton = true;
            this.textBox11.Size = new System.Drawing.Size(173, 29);
            this.textBox11.Style = MetroFramework.MetroColorStyle.Brown;
            this.textBox11.TabIndex = 45;
            this.textBox11.UseCustomBackColor = true;
            this.textBox11.UseSelectable = true;
            this.textBox11.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox11.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textBox12
            // 
            // 
            // 
            // 
            this.textBox12.CustomButton.Image = null;
            this.textBox12.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.textBox12.CustomButton.Name = "";
            this.textBox12.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.textBox12.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox12.CustomButton.TabIndex = 1;
            this.textBox12.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox12.CustomButton.UseSelectable = true;
            this.textBox12.CustomButton.Visible = false;
            this.textBox12.Enabled = false;
            this.textBox12.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.textBox12.Lines = new string[0];
            this.textBox12.Location = new System.Drawing.Point(162, 168);
            this.textBox12.MaxLength = 32767;
            this.textBox12.Name = "textBox12";
            this.textBox12.PasswordChar = '\0';
            this.textBox12.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox12.SelectedText = "";
            this.textBox12.SelectionLength = 0;
            this.textBox12.SelectionStart = 0;
            this.textBox12.ShortcutsEnabled = true;
            this.textBox12.ShowClearButton = true;
            this.textBox12.Size = new System.Drawing.Size(173, 29);
            this.textBox12.Style = MetroFramework.MetroColorStyle.Brown;
            this.textBox12.TabIndex = 46;
            this.textBox12.UseCustomBackColor = true;
            this.textBox12.UseSelectable = true;
            this.textBox12.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox12.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(15, 172);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(117, 19);
            this.metroLabel5.TabIndex = 58;
            this.metroLabel5.Text = "ID Обслуживания";
            // 
            // textBox13
            // 
            // 
            // 
            // 
            this.textBox13.CustomButton.Image = null;
            this.textBox13.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.textBox13.CustomButton.Name = "";
            this.textBox13.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.textBox13.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox13.CustomButton.TabIndex = 1;
            this.textBox13.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox13.CustomButton.UseSelectable = true;
            this.textBox13.CustomButton.Visible = false;
            this.textBox13.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.textBox13.Lines = new string[0];
            this.textBox13.Location = new System.Drawing.Point(162, 203);
            this.textBox13.MaxLength = 32767;
            this.textBox13.Name = "textBox13";
            this.textBox13.PasswordChar = '\0';
            this.textBox13.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox13.SelectedText = "";
            this.textBox13.SelectionLength = 0;
            this.textBox13.SelectionStart = 0;
            this.textBox13.ShortcutsEnabled = true;
            this.textBox13.ShowClearButton = true;
            this.textBox13.Size = new System.Drawing.Size(173, 29);
            this.textBox13.Style = MetroFramework.MetroColorStyle.Brown;
            this.textBox13.TabIndex = 47;
            this.textBox13.UseCustomBackColor = true;
            this.textBox13.UseSelectable = true;
            this.textBox13.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox13.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(16, 136);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(106, 19);
            this.metroLabel6.TabIndex = 57;
            this.metroLabel6.Text = "Номер комнаты";
            // 
            // textBox14
            // 
            // 
            // 
            // 
            this.textBox14.CustomButton.Image = null;
            this.textBox14.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.textBox14.CustomButton.Name = "";
            this.textBox14.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.textBox14.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox14.CustomButton.TabIndex = 1;
            this.textBox14.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox14.CustomButton.UseSelectable = true;
            this.textBox14.CustomButton.Visible = false;
            this.textBox14.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.textBox14.Lines = new string[0];
            this.textBox14.Location = new System.Drawing.Point(162, 238);
            this.textBox14.MaxLength = 32767;
            this.textBox14.Name = "textBox14";
            this.textBox14.PasswordChar = '\0';
            this.textBox14.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox14.SelectedText = "";
            this.textBox14.SelectionLength = 0;
            this.textBox14.SelectionStart = 0;
            this.textBox14.ShortcutsEnabled = true;
            this.textBox14.ShowClearButton = true;
            this.textBox14.Size = new System.Drawing.Size(173, 29);
            this.textBox14.Style = MetroFramework.MetroColorStyle.Brown;
            this.textBox14.TabIndex = 48;
            this.textBox14.UseCustomBackColor = true;
            this.textBox14.UseSelectable = true;
            this.textBox14.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox14.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(16, 69);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(21, 19);
            this.metroLabel7.TabIndex = 56;
            this.metroLabel7.Text = "ID";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(16, 101);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(51, 19);
            this.metroLabel8.TabIndex = 55;
            this.metroLabel8.Text = "Клиент";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.materialDivider5);
            this.xtraTabPage1.Controls.Add(this.metroLabel10);
            this.xtraTabPage1.Controls.Add(this.metroLabel9);
            this.xtraTabPage1.Controls.Add(this.chooseFindBox);
            this.xtraTabPage1.Controls.Add(this.findText);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(354, 540);
            this.xtraTabPage1.Text = "Поиск";
            // 
            // materialDivider5
            // 
            this.materialDivider5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider5.Depth = 0;
            this.materialDivider5.Location = new System.Drawing.Point(135, 21);
            this.materialDivider5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider5.Name = "materialDivider5";
            this.materialDivider5.Size = new System.Drawing.Size(2, 64);
            this.materialDivider5.TabIndex = 64;
            this.materialDivider5.Text = "materialDivider5";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(75, 59);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(52, 19);
            this.metroLabel10.TabIndex = 3;
            this.metroLabel10.Text = "Фильтр";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(75, 27);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(54, 19);
            this.metroLabel9.TabIndex = 2;
            this.metroLabel9.Text = "Запрос";
            // 
            // chooseFindBox
            // 
            this.chooseFindBox.FormattingEnabled = true;
            this.chooseFindBox.ItemHeight = 23;
            this.chooseFindBox.Location = new System.Drawing.Point(151, 56);
            this.chooseFindBox.Name = "chooseFindBox";
            this.chooseFindBox.Size = new System.Drawing.Size(173, 29);
            this.chooseFindBox.TabIndex = 1;
            this.chooseFindBox.UseSelectable = true;
            // 
            // findText
            // 
            // 
            // 
            // 
            this.findText.CustomButton.Image = null;
            this.findText.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.findText.CustomButton.Name = "";
            this.findText.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.findText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.findText.CustomButton.TabIndex = 1;
            this.findText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.findText.CustomButton.UseSelectable = true;
            this.findText.CustomButton.Visible = false;
            this.findText.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.findText.Lines = new string[0];
            this.findText.Location = new System.Drawing.Point(151, 21);
            this.findText.MaxLength = 32767;
            this.findText.Name = "findText";
            this.findText.PasswordChar = '\0';
            this.findText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.findText.SelectedText = "";
            this.findText.SelectionLength = 0;
            this.findText.SelectionStart = 0;
            this.findText.ShortcutsEnabled = true;
            this.findText.Size = new System.Drawing.Size(173, 29);
            this.findText.TabIndex = 0;
            this.findText.UseSelectable = true;
            this.findText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.findText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.findText.TextChanged += new System.EventHandler(this.findText_TextChanged);
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Location = new System.Drawing.Point(857, 31);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(122, 36);
            this.materialFlatButton2.TabIndex = 8;
            this.materialFlatButton2.Text = "Создать отчет";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            this.materialFlatButton2.Click += new System.EventHandler(this.materialFlatButton2_Click);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(994, 31);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(188, 36);
            this.materialFlatButton1.TabIndex = 9;
            this.materialFlatButton1.Text = "Сменить пользователя";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // materialDivider3
            // 
            this.materialDivider3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider3.Depth = 0;
            this.materialDivider3.Location = new System.Drawing.Point(985, 37);
            this.materialDivider3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider3.Name = "materialDivider3";
            this.materialDivider3.Size = new System.Drawing.Size(2, 25);
            this.materialDivider3.TabIndex = 10;
            this.materialDivider3.Text = "materialDivider3";
            // 
            // materialDivider4
            // 
            this.materialDivider4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider4.Depth = 0;
            this.materialDivider4.Location = new System.Drawing.Point(849, 37);
            this.materialDivider4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider4.Name = "materialDivider4";
            this.materialDivider4.Size = new System.Drawing.Size(2, 25);
            this.materialDivider4.TabIndex = 11;
            this.materialDivider4.Text = "materialDivider4";
            // 
            // materialFlatButton3
            // 
            this.materialFlatButton3.AutoSize = true;
            this.materialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton3.Depth = 0;
            this.materialFlatButton3.Location = new System.Drawing.Point(612, 31);
            this.materialFlatButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton3.Name = "materialFlatButton3";
            this.materialFlatButton3.Primary = false;
            this.materialFlatButton3.Size = new System.Drawing.Size(230, 36);
            this.materialFlatButton3.TabIndex = 12;
            this.materialFlatButton3.Text = "Просмотреть выселившихся";
            this.materialFlatButton3.UseVisualStyleBackColor = false;
            this.materialFlatButton3.Click += new System.EventHandler(this.materialFlatButton3_Click);
            // 
            // fKГостиницаКлиентыBindingSource
            // 
            this.fKГостиницаКлиентыBindingSource.DataMember = "FK_Гостиница_Клиенты";
            this.fKГостиницаКлиентыBindingSource.DataSource = this.клиентыBindingSource;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightGray;
            // 
            // 
            // 
            this.textBox1.CustomButton.Image = null;
            this.textBox1.CustomButton.Location = new System.Drawing.Point(151, 1);
            this.textBox1.CustomButton.Name = "";
            this.textBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox1.CustomButton.TabIndex = 1;
            this.textBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox1.CustomButton.UseSelectable = true;
            this.textBox1.CustomButton.Visible = false;
            this.textBox1.Enabled = false;
            this.textBox1.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.textBox1.Lines = new string[0];
            this.textBox1.Location = new System.Drawing.Point(161, 21);
            this.textBox1.MaxLength = 32767;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '\0';
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox1.SelectedText = "";
            this.textBox1.SelectionLength = 0;
            this.textBox1.SelectionStart = 0;
            this.textBox1.ShortcutsEnabled = true;
            this.textBox1.Size = new System.Drawing.Size(173, 29);
            this.textBox1.TabIndex = 43;
            this.textBox1.UseCustomBackColor = true;
            this.textBox1.UseSelectable = true;
            this.textBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Form1
            // 
            this.ApplyImageInvert = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 641);
            this.Controls.Add(this.materialFlatButton3);
            this.Controls.Add(this.materialDivider4);
            this.Controls.Add(this.materialDivider3);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.materialFlatButton2);
            this.Controls.Add(this.tabActions);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.TabTable);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Text = "Гостиница";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.номераГостиницыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.курсачDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.обслуживаниеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.гостиницаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWorkers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClients)).EndInit();
            this.tabService.ResumeLayout(false);
            this.tabWorkers.ResumeLayout(false);
            this.tabRooms.ResumeLayout(false);
            this.tabClients.ResumeLayout(false);
            this.tabHotel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHotel)).EndInit();
            this.TabTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabActions)).EndInit();
            this.tabActions.ResumeLayout(false);
            this.tabAdd.ResumeLayout(false);
            this.tabAdd.PerformLayout();
            this.tabDelete.ResumeLayout(false);
            this.tabEdit.ResumeLayout(false);
            this.tabEdit.PerformLayout();
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKГостиницаКлиентыBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private КурсачDataSet курсачDataSet;
        private System.Windows.Forms.BindingSource гостиницаBindingSource;
        private КурсачDataSetTableAdapters.ГостиницаTableAdapter гостиницаTableAdapter;
        private System.Windows.Forms.BindingSource клиентыBindingSource;
        private КурсачDataSetTableAdapters.КлиентыTableAdapter клиентыTableAdapter;
        private System.Windows.Forms.BindingSource номераГостиницыBindingSource;
        private КурсачDataSetTableAdapters.Номера_гостиницыTableAdapter номера_гостиницыTableAdapter;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private КурсачDataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private System.Windows.Forms.BindingSource обслуживаниеBindingSource;
        private КурсачDataSetTableAdapters.ОбслуживаниеTableAdapter обслуживаниеTableAdapter;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private MetroFramework.Controls.MetroTextBox textBox7;
        private MetroFramework.Controls.MetroTextBox textBox6;
        private MetroFramework.Controls.MetroTextBox textBox5;
        private MetroFramework.Controls.MetroTextBox textBox4;
        private MetroFramework.Controls.MetroTextBox textBox3;
        private MetroFramework.Controls.MetroTextBox textBox2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private КурсачDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView dataGridService;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDОбслуживанияDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn уборкаПомещенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn доставкаЕдыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn экскурсииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn спортПомещенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridWorkers;
        private System.Windows.Forms.DataGridView dataGridRooms;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерКомнатыDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn типНомераDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn занятостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn стоимостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridClients;
        private System.Windows.Forms.TabPage tabService;
        private System.Windows.Forms.TabPage tabWorkers;
        private System.Windows.Forms.TabPage tabRooms;
        private System.Windows.Forms.TabPage tabClients;
        private System.Windows.Forms.TabPage tabHotel;
        private System.Windows.Forms.DataGridView dataGridHotel;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn клиентDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерКомнатыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDОбслуживанияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn сотрудникDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаЗаселенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn срокПроживанияDataGridViewTextBoxColumn;
        private MaterialSkin.Controls.MaterialTabControl TabTable;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private DevExpress.XtraTab.XtraTabControl tabActions;
        private DevExpress.XtraTab.XtraTabPage tabAdd;
        private DevExpress.XtraTab.XtraTabPage tabDelete;
        private DevExpress.XtraTab.XtraTabPage tabEdit;
        private MetroFramework.Controls.MetroComboBox comboBox1;
        private MetroFramework.Controls.MetroComboBox comboBox4;
        private MetroFramework.Controls.MetroComboBox comboBox3;
        private MetroFramework.Controls.MetroComboBox comboBox2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton3;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton4;
        private MetroFramework.Controls.MetroLabel label1;
        private MetroFramework.Controls.MetroLabel label2;
        private MetroFramework.Controls.MetroLabel label4;
        private MetroFramework.Controls.MetroLabel label3;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MetroFramework.Controls.MetroLabel label7;
        private MetroFramework.Controls.MetroLabel label6;
        private MetroFramework.Controls.MetroLabel label5;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private MetroFramework.Controls.MetroDateTime dateBox;
        private MetroFramework.Controls.MetroDateTime dateBox2;
        private MetroFramework.Controls.MetroComboBox comboBox8;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MetroFramework.Controls.MetroComboBox comboBox7;
        private MetroFramework.Controls.MetroComboBox comboBox6;
        private MetroFramework.Controls.MetroComboBox comboBox5;
        private MetroFramework.Controls.MetroTextBox textBox9;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox textBox10;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox textBox15;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox textBox11;
        private MetroFramework.Controls.MetroTextBox textBox12;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox textBox13;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox textBox14;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private MetroFramework.Controls.MetroComboBox chooseFindBox;
        private MetroFramework.Controls.MetroTextBox findText;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialDivider materialDivider3;
        private MaterialSkin.Controls.MaterialDivider materialDivider4;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton3;
        private MaterialSkin.Controls.MaterialDivider materialDivider5;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton5;
        private System.Windows.Forms.BindingSource fKГостиницаКлиентыBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDСотрудникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn образованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn должностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерТелефонаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDКлиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn городDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn серияПаспортаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерПаспортаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерТелефонаDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroTextBox textBox1;
    }
}

