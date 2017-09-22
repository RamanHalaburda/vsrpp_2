using System;
using System.Windows.Forms;

namespace vsrpp_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    DBConnect.GetData("EXEC spGetAllGoods", dataGridView1);
                    tcChangeNew.SelectedIndex = 0;
                    break;
                case 1:
                    DBConnect.GetData("EXEC spGetAllTypes", dataGridView1);
                    tcChangeNew.SelectedIndex = 1;
                    break;
                case 2:
                    DBConnect.GetData("EXEC spGetAllClients", dataGridView1);
                    tcChangeNew.SelectedIndex = 2;
                    break;
                case 3:
                    DBConnect.GetData("EXEC spGetAllRents", dataGridView1);
                    tcChangeNew.SelectedIndex = 3;
                    break;
            }            
        }

        private void tpGoods_Leave(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = String.Empty;
        }

        private void tpType_Leave(object sender, EventArgs e)
        {
            textBox4.Text = textBox5.Text = String.Empty;
        }

        private void tpClient_Leave(object sender, EventArgs e)
        {
            textBox6.Text = textBox7.Text = textBox8.Text = textBox9.Text = String.Empty;
        }

        private void tpRent_Leave(object sender, EventArgs e)
        {
            textBox10.Text = textBox11.Text = textBox12.Text = String.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // change goods
            string query = "EXEC spUpdateGoods '" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "'";
            DBConnect.DoUpdate(query);
            textBox1.Text = textBox2.Text = textBox3.Text = String.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // add goods
            string query = "EXEC spInsertGoods '" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "'";
            DBConnect.DoUpdate(query);
            textBox1.Text = textBox2.Text = textBox3.Text = String.Empty;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // delete goods
            string query = "EXEC spDeleteGoods '" + textBox1.Text + "'";
            DBConnect.DoUpdate(query);
            textBox1.Text = textBox2.Text = textBox3.Text = String.Empty;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // search goods
            string query = "EXEC spSearchGoods '" + textBox1.Text + "'";
            DBConnect.GetData(query, dataGridView1);
            textBox1.Text = textBox2.Text = textBox3.Text = String.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // change type
            string query = "EXEC spUpdateType '" + textBox4.Text + "','" + textBox5.Text + "'";
            DBConnect.DoUpdate(query);
            textBox4.Text = textBox5.Text = String.Empty;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // add type
            string query = "EXEC spInsertType '" + textBox4.Text + "','" + textBox5.Text + "'";
            DBConnect.DoUpdate(query);
            textBox4.Text = textBox5.Text = String.Empty;
        }
        
        private void button10_Click(object sender, EventArgs e)
        {
            // delete type
            string query = "EXEC spDeleteType '" + textBox4.Text + "'";
            DBConnect.DoUpdate(query);
            textBox4.Text = textBox5.Text = String.Empty;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            // search type
            string query = "EXEC spSearchType '" + textBox4.Text + "'";
            DBConnect.GetData(query, dataGridView1);
            textBox4.Text = textBox5.Text = String.Empty;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // change client
            string query = "EXEC spUpdateClient '" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "'";
            DBConnect.DoUpdate(query);
            tpGoods_Leave(sender, e);
            textBox6.Text = textBox7.Text = textBox8.Text = textBox9.Text = String.Empty;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // add client
            string query = "EXEC spInsertClient '" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "'";
            DBConnect.DoUpdate(query);
            textBox6.Text = textBox7.Text = textBox8.Text = textBox9.Text = String.Empty;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // delete client
            string query = "EXEC spDeleteClient '" + textBox6.Text + "'";
            DBConnect.DoUpdate(query);
            textBox6.Text = textBox7.Text = textBox8.Text = textBox9.Text = String.Empty;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            // search client
            string query = "EXEC spSearchClient '" + textBox6.Text + "'";
            DBConnect.GetData(query, dataGridView1);
            textBox6.Text = textBox7.Text = textBox8.Text = textBox9.Text = String.Empty;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // change rent
            string query = "EXEC spUpdateRent '" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "'";
            DBConnect.DoUpdate(query);
            textBox10.Text = textBox11.Text = textBox12.Text = String.Empty;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // add rent
            string query = "EXEC spInsertRent '" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "'";
            DBConnect.DoUpdate(query);
            textBox10.Text = textBox11.Text = textBox12.Text = String.Empty;
        }
        
        private void button12_Click(object sender, EventArgs e)
        {
            // delete rent
            string query = "EXEC spDeleteRent '" + textBox10.Text + "'";
            DBConnect.DoUpdate(query);
            textBox10.Text = textBox11.Text = textBox12.Text = String.Empty;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            // search rent
            string query = "EXEC spSearchRent '" + textBox10.Text + "'";
            DBConnect.GetData(query, dataGridView1);
            textBox10.Text = textBox11.Text = textBox12.Text = String.Empty;
        }
    }
}
