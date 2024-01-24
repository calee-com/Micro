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
    public partial class Policy : Form
    {
        internal int selInt;

        public Policy()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Insurance also known as domestic package provides protection to house plus posessions (building, electronics, furniture, clothes, cell phones etc) if stolen or damaged.\r\n\r\nThis Policy covers:\r\n\r\nPersonal Accident Cover for your house keeper, protecting you from any accidental liability.\r\n    Protection for your posessions and house");
        }
       
        

            private void Policy_Load(object sender, EventArgs e)



            {

                
            }



        }
    }


        
    

