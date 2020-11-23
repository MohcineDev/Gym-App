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

namespace app
{
    public partial class AllMembers : Form
    {
        SqlConnection connection = new SqlConnection("server=MOH-PC\\MSSQLSERVER0; database=test; integrated security=true");
        SqlCommand command;

        public AllMembers()
        {
            InitializeComponent();
        }


        //get total member
        void getTotalMembers()
        {
            command = new SqlCommand("select count(*) from mytable", connection);
            connection.Open();

            int totalMembers = (int)command.ExecuteScalar();
            total.Text = totalMembers.ToString();

            connection.Close();
        }

        void getMembers()
        {
            command = new SqlCommand("select fullName, cin, tel, registrationDate, renewRegistration from myTable", connection);
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    //MessageBox.Show(Convert.ToString(DateTime.Parse(reader[3].ToString()).ToShortDateString()));
                     
                    dataGridView1.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(),  DateTime.Parse(reader[3].ToString()).ToShortDateString() , DateTime.Parse(reader[4].ToString()).ToShortDateString());

                }
            }
            reader.Close();
            connection.Close();

        }

        private void AllMembers_Load(object sender, EventArgs e)
        {
            //getTotalMembers();
            //getMembers();
        }
    }
}
