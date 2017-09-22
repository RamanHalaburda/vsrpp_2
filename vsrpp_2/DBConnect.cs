using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace vsrpp_2
{
    class DBConnect
    {
        private static SqlDataAdapter dataAdapter;
        private static String connectionString = 
            "Initial Catalog = GoodsRental_vsrpp_2; Data Source = ROMANPC\\SQLEXPRESS ; Integrated Security=True";

        public static void GetData(string _query, DataGridView _dgv)
        {
            try
            {
                dataAdapter = new SqlDataAdapter(_query, connectionString);                
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);                
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                _dgv.DataSource = table;
                _dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (SqlException)
            {
                MessageBox.Show("SQL error!");
            }
        }

        // method for UPDATE, INSERT and DELETE
        public static void DoUpdate(string _query)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(_query, con))
                    {
                        cmd.Connection.Open();
                        cmd.ExecuteNonQuery();
                        cmd.Connection.Close();
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine("SQL error: " + ex); }
        }
    }
}
