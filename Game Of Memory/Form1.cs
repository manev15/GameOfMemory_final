using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Of_Memory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OleDbConnection connect = new OleDbConnection();
            connect.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Finki\VI - semestar\Vizuelno programiranje\Zadaci - vezbanje\Game Of Memory\Game Of Memory\vizuelno.accdb;
Persist Security Info=False;";
           

            connect.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connect;
            command.CommandText = "SELECT Name, Score FROM hightscore ORDER BY Score DESC";

            OleDbDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                lbHightScore.Items.Add(reader["Name"].ToString() + " "+reader["Score"].ToString());
  

            }


            connect.Close();

        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            Easy easy = new Easy();
            this.Hide();
            easy.Show();
        }

        private void btnHightScore_Click(object sender, EventArgs e)
        {
            lbHightScore.Visible = true;
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            Form2 medium = new Form2();
            this.Hide();
            medium.Show();
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            Hard hard = new Hard();
            this.Hide();
            hard.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlPanela1.Visible = true;
        }
    }
}
