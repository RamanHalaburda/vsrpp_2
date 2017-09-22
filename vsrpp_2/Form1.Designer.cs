namespace vsrpp_2
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
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tcChangeNew = new System.Windows.Forms.TabControl();
            this.tpGoods = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tpType = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tpClient = new System.Windows.Forms.TabPage();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tpRent = new System.Windows.Forms.TabPage();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.goodsRental_vsrpp_2DataSet1 = new vsrpp_2.GoodsRental_vsrpp_2DataSet1();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.tcMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tcChangeNew.SuspendLayout();
            this.tpGoods.SuspendLayout();
            this.tpType.SuspendLayout();
            this.tpClient.SuspendLayout();
            this.tpRent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsRental_vsrpp_2DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tabPage1);
            this.tcMain.Controls.Add(this.tabPage4);
            this.tcMain.Controls.Add(this.tabPage5);
            this.tcMain.Location = new System.Drawing.Point(12, 12);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(832, 367);
            this.tcMain.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tcChangeNew);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(824, 341);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Select (Change, Add new)";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tcChangeNew
            // 
            this.tcChangeNew.Controls.Add(this.tpGoods);
            this.tcChangeNew.Controls.Add(this.tpType);
            this.tcChangeNew.Controls.Add(this.tpClient);
            this.tcChangeNew.Controls.Add(this.tpRent);
            this.tcChangeNew.Location = new System.Drawing.Point(547, 6);
            this.tcChangeNew.Name = "tcChangeNew";
            this.tcChangeNew.SelectedIndex = 0;
            this.tcChangeNew.Size = new System.Drawing.Size(271, 331);
            this.tcChangeNew.TabIndex = 2;
            // 
            // tpGoods
            // 
            this.tpGoods.Controls.Add(this.button13);
            this.tpGoods.Controls.Add(this.button9);
            this.tpGoods.Controls.Add(this.button2);
            this.tpGoods.Controls.Add(this.button1);
            this.tpGoods.Controls.Add(this.textBox3);
            this.tpGoods.Controls.Add(this.label3);
            this.tpGoods.Controls.Add(this.textBox2);
            this.tpGoods.Controls.Add(this.label2);
            this.tpGoods.Controls.Add(this.textBox1);
            this.tpGoods.Controls.Add(this.label1);
            this.tpGoods.Location = new System.Drawing.Point(4, 22);
            this.tpGoods.Name = "tpGoods";
            this.tpGoods.Padding = new System.Windows.Forms.Padding(3);
            this.tpGoods.Size = new System.Drawing.Size(263, 305);
            this.tpGoods.TabIndex = 0;
            this.tpGoods.Text = "Goods";
            this.tpGoods.UseVisualStyleBackColor = true;
            this.tpGoods.Leave += new System.EventHandler(this.tpGoods_Leave);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(85, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Add new";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save changes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(85, 58);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(172, 20);
            this.textBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "type_id";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(85, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(172, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "id";
            // 
            // tpType
            // 
            this.tpType.Controls.Add(this.button14);
            this.tpType.Controls.Add(this.button10);
            this.tpType.Controls.Add(this.button4);
            this.tpType.Controls.Add(this.button3);
            this.tpType.Controls.Add(this.textBox5);
            this.tpType.Controls.Add(this.label5);
            this.tpType.Controls.Add(this.textBox4);
            this.tpType.Controls.Add(this.label6);
            this.tpType.Location = new System.Drawing.Point(4, 22);
            this.tpType.Name = "tpType";
            this.tpType.Padding = new System.Windows.Forms.Padding(3);
            this.tpType.Size = new System.Drawing.Size(263, 305);
            this.tpType.TabIndex = 1;
            this.tpType.Text = "Type";
            this.tpType.UseVisualStyleBackColor = true;
            this.tpType.Leave += new System.EventHandler(this.tpType_Leave);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(85, 87);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(172, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "Add new";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(85, 58);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(172, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Save changes";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(85, 32);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(172, 20);
            this.textBox5.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "name";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(85, 6);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(172, 20);
            this.textBox4.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "id";
            // 
            // tpClient
            // 
            this.tpClient.Controls.Add(this.button15);
            this.tpClient.Controls.Add(this.button11);
            this.tpClient.Controls.Add(this.textBox9);
            this.tpClient.Controls.Add(this.label10);
            this.tpClient.Controls.Add(this.textBox8);
            this.tpClient.Controls.Add(this.label11);
            this.tpClient.Controls.Add(this.button6);
            this.tpClient.Controls.Add(this.button5);
            this.tpClient.Controls.Add(this.textBox6);
            this.tpClient.Controls.Add(this.label4);
            this.tpClient.Controls.Add(this.textBox7);
            this.tpClient.Controls.Add(this.label7);
            this.tpClient.Location = new System.Drawing.Point(4, 22);
            this.tpClient.Name = "tpClient";
            this.tpClient.Size = new System.Drawing.Size(263, 305);
            this.tpClient.TabIndex = 2;
            this.tpClient.Text = "Client";
            this.tpClient.UseVisualStyleBackColor = true;
            this.tpClient.Leave += new System.EventHandler(this.tpClient_Leave);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(85, 84);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(172, 20);
            this.textBox9.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "phone";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(85, 58);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(172, 20);
            this.textBox8.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "email";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(85, 139);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(172, 23);
            this.button6.TabIndex = 21;
            this.button6.Text = "Add new";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(85, 110);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(172, 23);
            this.button5.TabIndex = 20;
            this.button5.Text = "Save changes";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(85, 6);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(172, 20);
            this.textBox6.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "fio";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(85, 32);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(172, 20);
            this.textBox7.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "id";
            // 
            // tpRent
            // 
            this.tpRent.AllowDrop = true;
            this.tpRent.Controls.Add(this.button16);
            this.tpRent.Controls.Add(this.button12);
            this.tpRent.Controls.Add(this.textBox12);
            this.tpRent.Controls.Add(this.label12);
            this.tpRent.Controls.Add(this.button8);
            this.tpRent.Controls.Add(this.button7);
            this.tpRent.Controls.Add(this.textBox11);
            this.tpRent.Controls.Add(this.label8);
            this.tpRent.Controls.Add(this.textBox10);
            this.tpRent.Controls.Add(this.label9);
            this.tpRent.Location = new System.Drawing.Point(4, 22);
            this.tpRent.Name = "tpRent";
            this.tpRent.Size = new System.Drawing.Size(263, 305);
            this.tpRent.TabIndex = 3;
            this.tpRent.Text = "Rent";
            this.tpRent.UseVisualStyleBackColor = true;
            this.tpRent.Leave += new System.EventHandler(this.tpRent_Leave);
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(85, 58);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(172, 20);
            this.textBox12.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "goods id";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(85, 113);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(172, 23);
            this.button8.TabIndex = 21;
            this.button8.Text = "Add new";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(85, 84);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(172, 23);
            this.button7.TabIndex = 20;
            this.button7.Text = "Save changes";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(85, 32);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(172, 20);
            this.textBox11.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "client id";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(85, 6);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(172, 20);
            this.textBox10.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "rent id";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(535, 304);
            this.dataGridView1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Goods",
            "Type",
            "Client",
            "Rent"});
            this.comboBox1.Location = new System.Drawing.Point(6, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(824, 392);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Search";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(824, 392);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Sort";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.goodsRental_vsrpp_2DataSet1;
            this.bindingSource1.Position = 0;
            // 
            // goodsRental_vsrpp_2DataSet1
            // 
            this.goodsRental_vsrpp_2DataSet1.DataSetName = "GoodsRental_vsrpp_2DataSet1";
            this.goodsRental_vsrpp_2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(85, 142);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(172, 23);
            this.button9.TabIndex = 8;
            this.button9.Text = "Delete";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(85, 116);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(172, 23);
            this.button10.TabIndex = 16;
            this.button10.Text = "Delete";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(85, 168);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(172, 23);
            this.button11.TabIndex = 26;
            this.button11.Text = "Delete";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(85, 142);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(172, 23);
            this.button12.TabIndex = 24;
            this.button12.Text = "Delete";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(85, 171);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(172, 23);
            this.button13.TabIndex = 9;
            this.button13.Text = "Search";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(85, 145);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(172, 23);
            this.button14.TabIndex = 17;
            this.button14.Text = "Search";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(85, 197);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(172, 23);
            this.button15.TabIndex = 27;
            this.button15.Text = "Search";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(85, 171);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(172, 23);
            this.button16.TabIndex = 25;
            this.button16.Text = "Search";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 383);
            this.Controls.Add(this.tcMain);
            this.Name = "Form1";
            this.Text = "GoodsRental";
            this.tcMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tcChangeNew.ResumeLayout(false);
            this.tpGoods.ResumeLayout(false);
            this.tpGoods.PerformLayout();
            this.tpType.ResumeLayout(false);
            this.tpType.PerformLayout();
            this.tpClient.ResumeLayout(false);
            this.tpClient.PerformLayout();
            this.tpRent.ResumeLayout(false);
            this.tpRent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsRental_vsrpp_2DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private GoodsRental_vsrpp_2DataSet1 goodsRental_vsrpp_2DataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tcChangeNew;
        private System.Windows.Forms.TabPage tpGoods;
        private System.Windows.Forms.TabPage tpType;
        private System.Windows.Forms.TabPage tpClient;
        private System.Windows.Forms.TabPage tpRent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
    }
}

