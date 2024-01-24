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
using System.Xml.Linq;

namespace MICRO
{
    public partial class List : Form
    {
        private static object Items;

        public List()
        {
            InitializeComponent();
        }

        public string list { get; private set; }
        public int selInt { get; private set; }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Company.FocusedItem != null)
            {
                int i = Company.FocusedItem.Index;

                list = Company.Items[i].Text + "-" + "Name:" + Company.Items[i].SubItems[1].Text + "/" + "Code :" + Company.Items[i].SubItems[2].Text;

                // Assuming selInt is an integer
                this.selInt = int.Parse(Company.Items[i].Text);
            }
        }

        private void List_Load(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = @"Data Source=DESKTOP-TFBBAM0\SQLEXPRESS; Initial Catalog=POINT;User Id=Guest; password=guest; Trusted_Connection=True";
            conn.Open();


            string sql = "";
            sql = "SELECT code, Name FROM  MICRO";

            SqlCommand comm = new SqlCommand(sql, conn);
            SqlDataReader rd = comm.ExecuteReader();

            while (rd.Read())
            {
                ListViewItem item = new ListViewItem(rd[0].ToString());
                item.SubItems.Add(rd[1].ToString());
                item.SubItems.Add(rd[2].ToString());
                Company.Items.Add(item);
                object items = List.Items;

            }



            //code goes here....
            conn.Close();
        
        }
    }
}
    

