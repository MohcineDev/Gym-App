using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    public partial class Search : Form
    {

        SqlConnection connection = new SqlConnection("server=MOH-PC\\MSSQLSERVER0; database=test; integrated security=true");
        SqlCommand command;
        public Search()
        {
            InitializeComponent();
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

                    dataGridView2.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), DateTime.Parse(reader[3].ToString()).ToShortDateString(), DateTime.Parse(reader[4].ToString()).ToShortDateString());

                }
            }
            reader.Close();
            connection.Close();

        }

        private void Search_Load(object sender, EventArgs e)
        {
            //getMembers();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView2.ClearSelection();

            if (txtSearch.Text.Trim() != string.Empty)
            {
                int row = -1;

                if (radioFullName.Checked)
                {
                    for (int i = 0; i < dataGridView2.Rows.Count; i++)
                    {
                        if (dataGridView2.Rows[i].Cells[0].Value.ToString() == txtSearch.Text)
                        {
                            row = i;
                        }
                    }
                }
                else if (radioCin.Checked)
                {
                    for (int i = 0; i < dataGridView2.Rows.Count; i++)
                    {
                        if (dataGridView2.Rows[i].Cells[1].Value.ToString() == txtSearch.Text)
                        {
                            row = i;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("please select something to search for either fullname or cin thank you!!");
                    return;
                }

                if (row > -1)
                {
                    dataGridView2.Rows[row].Selected = true;
                }
                else
                {
                    MessageBox.Show("this thing you entered not found Sorry!!");
                    return;
                }
            }
            else MessageBox.Show("please enter something to search for!!");
        }
    }
}
