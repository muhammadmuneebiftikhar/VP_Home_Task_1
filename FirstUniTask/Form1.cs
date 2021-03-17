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

namespace FirstUniTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        public int flag = 0;
        public int rollno, s1 ,s2 ,s3 ,s4, total;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string con = "Data Source=DESKTOP-IH5CIOA;Initial Catalog=VP_Home_Task;Integrated Security=True";

                SqlConnection sqlcon = new SqlConnection(con);
                sqlcon.Open();

                //string qry = "Update Students VALUES '" + txtName.Text + "','" + Convert.ToInt32(txtSub1.Text) + "','" + Convert.ToInt32(txtSub2.Text) + "','" + Convert.ToInt3(txtSub3.Text) + "','" + Convert.ToInt32(txtSub4.Text) + "','" + Convert.ToInt32(totalSub.Text) + "','" + Convert.ToInt32(PercentageAns.Text) + "' where Roll_No = '" + Convert.ToInt32(txtRollNo.Text) + "'";
                string updateQueryFormat = String.Format("Update Students set Name = '{0}',Sub1 = {1},Sub2 = {2},Sub3 = {3},Sub4 ={4},Total = {5},Percentage ={6} where Roll_No = {7}",txtName.Text ,txtSub1.Text , txtSub2.Text , txtSub3.Text , txtSub4.Text , totalSub.Text , PercentageAns.Text , txtRollNo.Text );
                //string qry = "Update Students(Name, Sub1, Sub2, Sub3, Sub4, Total, Percentage) Values ('" + txtName.Text +"','"+ Convert.ToInt32(txtSub1.Text) + "','"+ Convert.ToInt32(txtSub2.Text) + "','"+ Convert.ToInt32(txtSub3.Text) + "','"+ Convert.ToInt32(txtSub4.Text) + "','"+ Convert.ToInt32(totalSub.Text) + "','"+ Convert.ToInt32(PercentageAns.Text)+"') where Roll_No ='"+ Convert.ToInt32(txtRollNo.Text) +"'";



                SqlCommand cmd = new SqlCommand(updateQueryFormat, sqlcon);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Updated.");
                }
                else
                {
                    MessageBox.Show("Failed to Update Values.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string con = "Data Source=DESKTOP-IH5CIOA;Initial Catalog=VP_Home_Task;Integrated Security=True";

                SqlConnection sqlcon = new SqlConnection(con);
                sqlcon.Open();

                string qry = "Select * from Students where Roll_No = '" + Convert.ToInt32(txtRollNo.Text) + "'";
                SqlDataAdapter sda = new SqlDataAdapter(qry, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                sqlcon.Close();
                if (dt != null)
                {
                    txtName.Text = dt.Rows[0]["Name"].ToString();
                    txtSub1.Text = dt.Rows[0]["Sub1"].ToString();
                    txtSub2.Text = dt.Rows[0]["Sub2"].ToString();
                    txtSub3.Text = dt.Rows[0]["Sub3"].ToString();
                    txtSub4.Text = dt.Rows[0]["Sub4"].ToString();
                    totalSub.Text = dt.Rows[0]["Total"].ToString();
                    PercentageAns.Text = dt.Rows[0]["Percentage"].ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPinsert_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-IH5CIOA;Initial Catalog=VP_Home_Task;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand("dbo.SP_inserResult", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@roll", Convert.ToInt32(txtRollNo.Text.ToString())));
                cmd.Parameters.Add(new SqlParameter("@name", txtName.Text.ToString()));
                cmd.Parameters.Add(new SqlParameter("@subj1", Convert.ToInt32(txtSub1.Text.ToString())));
                cmd.Parameters.Add(new SqlParameter("@subj2", Convert.ToInt32(txtSub2.Text.ToString())));
                cmd.Parameters.Add(new SqlParameter("@subj3", Convert.ToInt32(txtSub3.Text.ToString())));
                cmd.Parameters.Add(new SqlParameter("@subj4", Convert.ToInt32(txtSub4.Text.ToString())));
                cmd.Parameters.Add(new SqlParameter("@total", Convert.ToInt32(totalSub.Text.ToString())));
                cmd.Parameters.Add(new SqlParameter("percent", Convert.ToInt32(PercentageAns.Text.ToString())));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Inserted");

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPSearch_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-IH5CIOA;Initial Catalog=VP_Home_Task;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand("dbo.SP_searchResult", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@roll",Convert.ToInt32(txtRollNo.Text.ToString())));
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                foreach(DataRow dr in dt.Rows)
                {
                    txtName.Text = dr["Name"].ToString();
                    txtSub1.Text = dr["Sub1"].ToString();
                    txtSub2.Text = dr["Sub2"].ToString();
                    txtSub3.Text = dr["Sub3"].ToString();
                    txtSub4.Text = dr["Sub4"].ToString();
                    totalSub.Text = dr["Total"].ToString();
                    PercentageAns.Text = dr["Percentage"].ToString();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-IH5CIOA;Initial Catalog=VP_Home_Task;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.SP_deleteResult", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@roll", Convert.ToInt32(txtRollNo.Text.ToString())));
            cmd.ExecuteNonQuery();
            MessageBox.Show("Deleted.");
            conn.Close();
        }

        private void btnPUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-IH5CIOA;Initial Catalog=VP_Home_Task;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand("dbo.SP_updateResult", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@roll", Convert.ToInt32(txtRollNo.Text.ToString())));
                cmd.Parameters.Add(new SqlParameter("@name", txtName.Text.ToString()));
                cmd.Parameters.Add(new SqlParameter("@subj1", Convert.ToInt32(txtSub1.Text.ToString())));
                cmd.Parameters.Add(new SqlParameter("@subj2", Convert.ToInt32(txtSub2.Text.ToString())));
                cmd.Parameters.Add(new SqlParameter("@subj3", Convert.ToInt32(txtSub3.Text.ToString())));
                cmd.Parameters.Add(new SqlParameter("@subj4", Convert.ToInt32(txtSub4.Text.ToString())));
                cmd.Parameters.Add(new SqlParameter("@total", Convert.ToInt32(totalSub.Text.ToString())));
                cmd.Parameters.Add(new SqlParameter("percent", Convert.ToInt32(PercentageAns.Text.ToString())));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Updated.");

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string con = "Data Source=DESKTOP-IH5CIOA;Initial Catalog=VP_Home_Task;Integrated Security=True";

                SqlConnection sqlcon = new SqlConnection(con);
                sqlcon.Open();

                string qry = "Delete from Students where Roll_No = '"+ Convert.ToInt32(txtRollNo.Text) +"'";
                SqlCommand cmd = new SqlCommand(qry, sqlcon);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Deleted.");
                }
                else
                {
                    MessageBox.Show("Failed to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string name;
        public float per;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            rollno = Convert.ToInt32(txtRollNo.Text);
            name = txtName.Text;
            s1 = Convert.ToInt32(txtSub1.Text);
            s2 = Convert.ToInt32(txtSub2.Text);
            s3 = Convert.ToInt32(txtSub3.Text);
            s4 = Convert.ToInt32(txtSub4.Text);

            total = s1 + s2 + s3 + s4;

            totalSub.Text = total.ToString();

           per = (total *100) / 400;

            PercentageAns.Text = per.ToString();

            if(total > 0 && per > 0)
            {
                flag = 1;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(flag == 1)
            {
                string con = "Data Source=DESKTOP-IH5CIOA;Initial Catalog=VP_Home_Task;Integrated Security=True";

                SqlConnection sqlcon = new SqlConnection(con);
                sqlcon.Open();

                string qry = "insert into Students (Roll_No, Name, Sub1, Sub2, Sub3, Sub4, Total, Percentage) values ('" + rollno + "', '" + name + "','" + s1 + "','" + s2 + "','" + s3 + "','" + s4 + "','" + total + "','" + per + "')";

                SqlCommand cmd = new SqlCommand(qry, sqlcon);

                if(cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Data Inserted.");
                }
                else
                {
                    MessageBox.Show("There is an Error.");
                }
            }
            else
            {
                MessageBox.Show("Calculate Values First.");
            }
        }
    }
}
