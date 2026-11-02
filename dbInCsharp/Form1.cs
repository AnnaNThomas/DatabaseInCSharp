using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace dbInCsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //BtnUpdate.Click += updateBtn_Click;
        }


        BindingSource binder = new BindingSource();


        private void BtnGetAll_Click(object sender, EventArgs e)
        {
            string conString;
            conString = Properties.Settings.Default.SDB;
            SqlConnection con = new SqlConnection(conString);
            con.Open();


            SqlCommand cmd = new SqlCommand("NamesAndCourses", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = binder;

            binder.DataSource = dataTable;










            con.Close();











        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            int studentIdValue = int.Parse(textBox1.Text);


            string conString;
            conString = Properties.Settings.Default.SDB;
            SqlConnection con = new SqlConnection(conString);
            con.Open();


            SqlCommand cmd = new SqlCommand("GetStudentByID", con);
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.Add(new SqlParameter("@param1", studentIdValue));



            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            try
            {
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            dataGridView1.DataSource = binder;

            binder.DataSource = dataTable;
            con.Close();




        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Step 1: Event started");
            int studentIdValue = int.Parse(txtID.Text);
            string fName = txtFamily.Text;
            string gName = txtGiven.Text;
            string conString;
            conString = Properties.Settings.Default.SDB;
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            MessageBox.Show("Step 2: Connection opened");
            SqlCommand cmd = new SqlCommand("UpdateStudentsTable", con);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@sID", studentIdValue));
            cmd.Parameters.Add(new SqlParameter("@Fam", fName));
            cmd.Parameters.Add(new SqlParameter("@Giv", gName));

            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated Successfully");
            con.Close();



        }

        private void BtnGetStudentsTable_Click(object sender, EventArgs e)
        {

            string conString;
            conString = Properties.Settings.Default.SDB;
            SqlConnection con = new SqlConnection(conString);
            con.Open();


            SqlCommand cmd = new SqlCommand("AllStudents", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = binder;

            binder.DataSource = dataTable;
            con.Close();

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string sID;
            string fName;
            string gName;

            DataGridViewRow selectRow = dataGridView1.Rows[e.RowIndex];

            sID = selectRow.Cells[0].Value.ToString();
            fName = selectRow.Cells[1].Value.ToString();
            gName = selectRow.Cells[2].Value.ToString();
            
            txtID.Text = sID;
            txtFamily.Text = fName;
            txtGiven.Text = gName;






        }
    }
}
