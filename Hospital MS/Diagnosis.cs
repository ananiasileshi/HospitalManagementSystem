using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hospital_MS
{
    public partial class Diagnosis : Form
    {
        public Diagnosis()
        {
            InitializeComponent();
            DisplayDiagnosis();
        }
        readonly SqlConnection Con = new SqlConnection(connectionString: @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Hp\OneDrive\Documents\Hospital MS.mdf"";Integrated Security=True;Connect Timeout=30");

        private void DisplayDiagnosis()
        {
            try
            {
                Con.Open();
                string Query = "select * from Diagnosis";
                SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                dataGridView2.DataSource = ds.Tables[0];
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

        void DisplayPatientId()
        {
            string sql = "select * from Patient";
            SqlCommand cmd = new SqlCommand(sql, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("PId", typeof(int));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                comboBox1.ValueMember = "PId";
                comboBox1.DataSource = dt;
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




        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == " " || comboBox1.Text == " " || textBox3.Text == " " || textBox4.Text == " " || textBox5.Text == " ")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    string query = "insert into Diagnosis Values(' " + textBox1.Text + " ',   ' " + comboBox1.Text + " ', ' " + textBox2.Text + " ', ' " + textBox3.Text + " ', ' " + textBox4.Text + " ', ' " + textBox5.Text + " ')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Record Entered Successfully");
                    DisplayDiagnosis();
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

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == " " || comboBox1.Text == " " || textBox3.Text == " " || textBox4.Text == " " || textBox5.Text == " ")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    string query = "update Diagnosis Set PatientId =@PatientId, PatientName= @PatientName, Symptoms=@S, DiagnosticTest=@D, Medicines=@M, where DId = @DId ";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@PatientId", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@PatientName", textBox2.Text);
                    cmd.Parameters.AddWithValue("@S", textBox3.Text);
                    cmd.Parameters.AddWithValue("@D", textBox4.Text);
                    cmd.Parameters.AddWithValue("@M", textBox5.Text);
                    cmd.Parameters.AddWithValue("@DId", textBox1.Text);

                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Recored Update Successfully");
                    DisplayDiagnosis();
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

        private void DelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == " ")

                {
                    MessageBox.Show("Enter The Diagnosis Id");
                }
                else
                {
                    Con.Open();
                    string query = "delete from Diagnosis where DId= '" + textBox1.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Record Deleted Successfully");
                    DisplayDiagnosis();
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

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            comboBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";

        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                comboBox1.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
                textBox2.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
                textBox3.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
                textBox4.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
                textBox5.Text = dataGridView2.SelectedRows[0].Cells[5].Value.ToString();
                label9.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
                label10.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString(); 
                label11.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
                label12.Text = dataGridView2.SelectedRows[0].Cells[5].Value.ToString();

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

        private void Diagnosis_Load(object sender, EventArgs e)
        {
            
            DisplayPatientId();
        }

        string pname;

        void DispalayPatientName()
        {
            try
            {
                Con.Open();
                string ss = "select * from Patient where PId =" + comboBox1.SelectedValue.ToString();

                SqlCommand cmd = new SqlCommand(ss, Con);
                DataTable dt = new DataTable();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    pname = dr["pname"].ToString();
                    textBox2.Text = pname;
                }
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

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DispalayPatientName();
        }

        private void CrossBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
