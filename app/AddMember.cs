using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace app
{
    public partial class AddMember : Form
    {
        SqlConnection connection = new SqlConnection("server=MOH-PC\\MSSQLSERVER0; database=test; integrated security=true");
        SqlCommand command;
        public AddMember()
        {
            InitializeComponent();
        }

        //Image image = null;
        string Path = "";

        private void Upload_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            dialogResult = openFileDialog1.ShowDialog();
            Path = openFileDialog1.FileName;

            if (dialogResult == DialogResult.OK)
            {
                //image = Image.FromFile(Path); // -- use the process so you can not access it outside this process
                pictureBox1.ImageLocation = Path; // -- Remove the process
            }
        }

        /*
           FileStream stream = new FileStream(Path, FileMode.Open, FileAccess.Read);
           BinaryReader reader = new BinaryReader(stream);
           byte[] img = null;

           img = reader.ReadBytes((int)stream.Length);

           command = new SqlCommand("insert into mytable values(@img)", connection);
           command.Parameters.Add(new SqlParameter("@img", img));

           connection.Open();
           command.ExecuteNonQuery();
           MessageBox.Show("Done");
           connection.Close();
            */
        private void add_Click(object sender, EventArgs e)
        {
            if (fullname.Text != string.Empty && cin.Text != string.Empty && tel.Text != string.Empty)
            {
                //get the image
                FileStream stream = new FileStream(Path, FileMode.Open, FileAccess.Read);
                BinaryReader reader = new BinaryReader(stream);
                byte[] img = null;

                img = reader.ReadBytes((int)stream.Length);

                 
                command = new SqlCommand("insert into mytable values(N'" + fullname.Text + "','" + cin.Text + "','" + tel.Text + "','" + registrationDate.Value.ToString() + "','" + registrationDate.Value.ToString() + "', @img)", connection);

                command.Parameters.Add(new SqlParameter("@img", img));

                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Done");
                connection.Close();
            }
        }


        //string path0= @"C:\Users\MOH\Desktop\qq.jpg";
        //FileStream fileStream = new FileStream(Path, FileMode.Open);
        //FileStream fileStream0 = new FileStream(path0, FileMode.Create);
        //BinaryReader binaryReader = new BinaryReader(fileStream);
        //BinaryWriter binaryWriter = new BinaryWriter(fileStream0);

        //string txtFile = @"C:\Users\MOH\Desktop\qq.txt";
        //StreamWriter streamWriter = new StreamWriter(txtFile);
        //string test = "";

        //for (int i = 0; i < binaryReader.BaseStream.Length; i++)
        //{
        //    test += binaryReader.ReadByte();
        //}

        //binaryWriter.Write(txtFile);
        //streamWriter.WriteLine(test);

        //binaryReader.Close();
        //streamWriter.Close();


        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Regex regex = new Regex("[0-9]+");

        //    if (regex.IsMatch(fullname.Text))
        //    {
        //        command = new SqlCommand("select img from mytable where id = " + fullname.Text, connection);
        //        byte[] img = null;
        //        connection.Open();
        //        SqlDataReader reader = command.ExecuteReader();


        //        if (reader.Read())
        //        {
        //            img = (byte[])reader[0];
        //        }

        //        if (img != null)
        //        {
        //            MemoryStream memoryStream = new MemoryStream(img);
        //            pictureBox2.Image = Image.FromStream(memoryStream);
        //        }


        //        reader.Close();
        //        connection.Close();
        //    }
        //    else
        //        MessageBox.Show("please enter the id of the user to display its image if it is availabel, Thank You!!", "Read Picture", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}


    }
}
