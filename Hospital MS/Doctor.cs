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

namespace Hospital_MS
{
    public partial class Doctor: Form
    {
        public Doctor()
        {
            InitializeComponent();
            DisplayDoctor();
        }

        readonly SqlConnection Con = new SqlConnection(connectionString: @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Hp\OneDrive\Documents\Hospital MS.mdf"";Integrated Security=True;Connect Timeout=30");

        private void DisplayDoctor()
        {
            try
            {
                Con.Open();
                string Query = "select * from Doctor";
                SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }
        private void CrossBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == " " || textBox2.Text == " " || comboBox1.Text == " " || textBox3.Text == " " || textBox3.Text == " ")
                {
                    MessageBox.Show("Missing Information");
                }
                else {
                    Con.Open();
                    string query = "insert into Doctor Values(' "+textBox1.Text+ " ', ' "+textBox2.Text+ " ', ' "+comboBox1.Text+ " ', ' "+textBox3.Text+ " ', ' "+textBox3.Text+" ')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Record Entered Successfully");
                    DisplayDoctor();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                Con.Close() ;
            }
        }

        private void Doctor_Load(object sender, EventArgs e)
        {
            DisplayDoctor();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
             textBox1.Text= " ";
             textBox2.Text = " ";
             comboBox1.Text = " ";
             textBox3.Text = " ";
             textBox3.Text = " ";
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == " " || textBox2.Text == " " || comboBox1.Text == " " || textBox3.Text == " " || textBox3.Text == " ")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    string query = "update Doctor Set DocName =@DocName, DocGen= @DocGen,Experience=@Experience, Licensce=@Licensce where DocId = @DocId ";
                    SqlCommand cmd = new SqlCommand(query,Con);
                    cmd.Parameters.AddWithValue("@DocName",textBox2.Text);
                    cmd.Parameters.AddWithValue("@DocGen", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@Experience", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Licensce", textBox4.Text);
                    cmd.Parameters.AddWithValue("@DocId", textBox1.Text);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Recored Update Successfully");
                    DisplayDoctor();
                }

            } catch (Exception ex)
            {
                MessageBox.Show (ex.Message);
            } 
            finally 
            {
                Con.Close ();
            }
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == " ")

                {
                    MessageBox.Show("Enter The Doctor ID");
                }
                else 
                {
                    Con.Open();
                    string query = "delete from Doctor where DocId= '" + textBox1.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Record Deleted Successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                Con.Close();
            }

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                comboBox1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textBox3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                textBox4.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                Con.Close();
            }
        }
    }
}
