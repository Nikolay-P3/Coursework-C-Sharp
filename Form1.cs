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

namespace Coursework_C_Sharp
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nicholas\Source\Repos\Coursework C-Sharp\DataBaseCourse.mdf;Integrated Security=True");

        public string reload = "SELECT * FROM [Table]";

        public Form1()
        {
            InitializeComponent();
            ReloadDB(reload);

            Form2 Open = new Form2();
            if (Open.ShowDialog() == DialogResult.Cancel)
                Application.Exit();
        }

        private void ReloadDB(string reload)
        {
            conn.Open();

            SqlCommand command = new SqlCommand(reload, conn);
            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[7]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
            }

            reader.Close();
            conn.Close();
            foreach (string[] s in data)
            {
                dataGridView1.Rows.Add(s);
            }



        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            conn.Open();

            if (!string.IsNullOrEmpty(textBoxNumber.Text) && !string.IsNullOrEmpty(textBoxAddres.Text))
            {
                SqlCommand command = new SqlCommand("INSERT INTO [Table](Number,Name,SName,TName,Address)VALUES(@Number,@Name,@SName,@TName,@Address)", conn);

                command.Parameters.AddWithValue("Number", textBoxNumber.Text);
                command.Parameters.AddWithValue("Name", textBoxName.Text);
                command.Parameters.AddWithValue("SName", textBoxSecondName.Text);
                command.Parameters.AddWithValue("TName", textBoxThridName.Text);
                command.Parameters.AddWithValue("Address", textBoxAddres.Text);

                try
                {
                    command.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                }

            }
            else
            {
                MessageBox.Show("Не все поля заполнены");
                conn.Close();
            }
        }

        private void buttonUpd_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            SqlDataReader reader = null;

            SqlCommand command = new SqlCommand(reload, conn);
            try
            {
                ReloadDB(reload);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("DELETE FROM [Table] WHERE [Id] = @Id", conn);

            command.Parameters.AddWithValue("Id", numericUpDownDel.Value);

            try
            {
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }

        }

        private void buttonFindNumber_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            conn.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM [Table] WHERE (Number LIKE '%' + @search + '%')", conn);
            command.Parameters.AddWithValue("search", textBoxFindNumber.Text);

            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[7]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
            }
            reader.Close();
            conn.Close();

            foreach (string[] s in data)
            {
                dataGridView1.Rows.Add(s);
            }
        }

        private void buttonUpdData_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(textBoxNumber.Text) && !string.IsNullOrEmpty(textBoxAddres.Text))
            {
                conn.Open();
                SqlCommand command = new SqlCommand("UPDATE [Table] SET [Number] = @Number,[Name] = @Name,[SName]= @SName,[TName] = @TName,[Address] = @Address WHERE [Id] = @Id", conn);
                command.Parameters.AddWithValue("Id", numericUpDownUpd.Value);

                command.Parameters.AddWithValue("Number", textBoxNumber.Text);
                command.Parameters.AddWithValue("Name", textBoxName.Text);
                command.Parameters.AddWithValue("SName", textBoxSecondName.Text);
                command.Parameters.AddWithValue("TName", textBoxThridName.Text);
                command.Parameters.AddWithValue("Address", textBoxAddres.Text);

                try
                {
                    command.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                }

            }
            else
            {
                MessageBox.Show("Не все поля заполнены");
                conn.Close();
            }
        }

        private void buttonFindSName_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            conn.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM [Table] WHERE (SName LIKE '%' + @search + '%')", conn);
            command.Parameters.AddWithValue("search", textBoxFindSName.Text);

            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[7]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
            }
            reader.Close();
            conn.Close();

            foreach (string[] s in data)
            {
                dataGridView1.Rows.Add(s);
            }
        }
    }
}


        
