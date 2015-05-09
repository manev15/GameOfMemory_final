using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Of_Memory
{
    public partial class Score : Form
    {
       
        public Score(string p)
        {
            InitializeComponent();
            label1.Text = p;
           

        }
        private void playAplaus()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"D:\Finki\VI - semestar\Vizuelno programiranje\Zadaci - vezbanje\Game Of Memory\Game Of Memory\Resources\aplaus.wav");
            simpleSound.Play();
        }

        

        private void Score_Load(object sender, EventArgs e)
        {
            playAplaus();
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void btnZacuvajRezultat_Click(object sender, EventArgs e)
        {
           OleDbConnection connect = new OleDbConnection();
           connect.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Finki\VI - semestar\Vizuelno programiranje\Zadaci - vezbanje\Game Of Memory\Game Of Memory\vizuelno.accdb;
Persist Security Info=False;";
            connect.Open();
            OleDbCommand putScores = new OleDbCommand();
            putScores.Connection = connect;
            putScores.CommandText = "INSERT INTO hightscore (Name, Score) VALUES ('" + tbIme.Text + "', '" + label1.Text + "')";
            putScores.ExecuteNonQuery();
            connect.Close();


            MessageBox.Show("Резултатот ви е зачуван");
            
            Form1 forma = new Form1();
            forma.Show();
            this.Close();

        }
    }
}
