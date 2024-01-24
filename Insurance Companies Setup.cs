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

namespace MICRO
{
    public partial class Form1 : Form
    {
        int curId = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            curId = 0;
            clearText();
            txtName.Focus();


        }

        private void clearText()
        {

            txtCode.Text = "";
            txtName.Text = "";
            txtPhysical.Text = "";
            txtBox.Text = "";
            txtPostal.Text = "";
            txtCity.Text = "";
            txtState.Text = "";
            Email.Text = "";
            txtWeb.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (txtCode.Text.Trim() == "")
            {
                MessageBox.Show("please enter the code");
                txtCode.Focus();
                return;
            }
            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("please enter the Name ");
                return;
            }

            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = @"Data Source=DESKTOP-TFBBAM0\SQLEXPRESS; Initial Catalog=POINT;User Id=Guest; password=guest; Trusted_Connection=True";
            conn.Open();



            String sql = "";
            if (curId == 0)
            {
                sql = "INSERT INTO MICRO (code,Name,Physical,P,City,Postal ,State,Address,Url) VALUES ('" + txtCode.Text + "','" + txtName.Text + "','" + txtPhysical.Text + "','" + txtBox.Text + "','" + txtCity.Text + "','" + txtPostal.Text + "','" + txtState.Text + "','" + Email.Text + "','" + txtWeb.Text + "')";
            }
            else
            {
                sql = "UPDATE MICRO SET code = '" + txtCode.Text + "',Name ='" + txtName.Text + "',Physical ='" + txtPhysical.Text + "',P ='" + txtBox.Text + "',City ='" + txtCity.Text + "',Postal = '" + txtPostal.Text + "',Address='" + Email + "', State = '" + txtState + "' , Url ='" + txtWeb.Text + "' WHERE code =" + curId + "";





                MessageBox.Show(sql);

            }






            SqlCommand comm = new SqlCommand(sql, conn);




            MessageBox.Show(sql);


            //code goes here...



            conn.Close();
            MessageBox.Show("process completed");
            curId = 0;
            clearText();
            txtName.Focus();
        }

            private void button4_Click(object sender, EventArgs e)
        {
            {
                if (curId <= 0)
                {
                    MessageBox.Show("please enter item to be deleted", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                DialogResult dresult = MessageBox.Show("Are you sure you want to delete the selected item!", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dresult == DialogResult.No)
                    return;
                SqlConnection conn = new SqlConnection();

                conn.ConnectionString = @"Data Source=DESKTOP-TFBBAM0\SQLEXPRESS; Initial Catalog=POINT;User Id=Guest; password=guest; Trusted_Connection=True";
                conn.Open();


                String sql = "";




                {
                    sql = "DELETE FROM MICRO  WHERE code =" + Code;


                    MessageBox.Show(sql);

                }
                SqlCommand comm = new SqlCommand(sql, conn);
                comm.ExecuteNonQuery();

                MessageBox.Show(sql);


                //code goes here....
                conn.Close();
                MessageBox.Show("Process succeeded");
                curId = 0;
                clearText();
                txtName.Focus();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            List frm = new List();
            frm.ShowDialog();
            displayInfor(frm.selInt);
            curId = frm.selInt;
        }

        private void displayInfor(int selInt)
        {
            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = @"Data Source=DESKTOP-TFBBAM0\SQLEXPRESS; Initial Catalog=POINT;User Id=Guest; password=guest; Trusted_Connection=True";
            conn.Open();


            string sql = "" ;
            sql = "SELECT code, Name FROM MICRO WHERE code = " + curId;;

            SqlCommand comm = new SqlCommand(sql, conn);
            SqlDataReader rd = comm.ExecuteReader();

            if (rd.Read())
            {
                txtCode.Text = rd[1].ToString();
                txtName.Text = rd[2].ToString();
              
           

            }


           
            //code goes here....
            conn.Close();
            


        }

        private void button6_Click(object sender, EventArgs e)
        {
            Policy frm = new Policy();
            frm.ShowDialog();
            displayInfor(frm.selInt);
            curId = frm.selInt;
        }

        private void displayInfor(object selInt)
        {
            throw new NotImplementedException();
        }
    }
    }

    


