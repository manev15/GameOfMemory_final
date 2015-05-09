using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Of_Memory
{
    public partial class Easy : Form
    {
        int score = 0;
        int br = 0;
        int end;
        private BallsDoc ballsDoc;
        public int[] broevi;
        private int generateBall;
        private Timer timer5;
        public string broj;
        public int f = 0;
        public string[] a;
       
        bool again = false;
        int i;
        int k;

        bool[] flag;
        Random Location = new Random();
        List<Point> points = new List<Point>();
        // List<int> IDS = new List<int>();
        //List<PictureBox> pictureboxes = new List<PictureBox>();

        PictureBox PendingImage1;
        PictureBox PendingImage2;
   
        public Easy()
        {
            InitializeComponent();
            DoubleBuffered = true;

            timer5 = new Timer();
            timer5.Interval = 1;
            timer5.Tick += new EventHandler(timer5_Tick);
            timer5.Start();



            broevi = new int[99];
            for (int i = 0; i < 99; i++)
                broevi[i] = i;
            ballsDoc = new BallsDoc(broevi);
       

        }
        private void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"D:\Finki\VI - semestar\Vizuelno programiranje\Zadaci - vezbanje\Game Of Memory\Game Of Memory\Resources\yes.wav");
            simpleSound.Play();
        }
        private void playNoSound()
        {
            SoundPlayer NoSound = new SoundPlayer(@"D:\Finki\VI - semestar\Vizuelno programiranje\Zadaci - vezbanje\Game Of Memory\Game Of Memory\Resources\no.wav");
            NoSound.Play();

        }


        private void CardsHolder_Paint(object sender, PaintEventArgs e)
        {

        }

       
        private void Form2_Load(object sender, EventArgs e)
        {
            btnPomos.Enabled = false;
            end = CardsHolder.Controls.Count;
            flag = new bool[end+1];
            label3.Text = "5";
            ScoreCounter.Text = "0";
            foreach (PictureBox picture in CardsHolder.Controls)
            {

                picture.Enabled = false;
                points.Add(picture.Location);
            }
            foreach (PictureBox picture in CardsHolder.Controls)
            {
                int next = Location.Next(points.Count);
                Point p = points[next];
                picture.Location = p;
                points.Remove(p);


            }
            timer2.Start();
            timer1.Start();
            Card1.Image = Properties.Resources.slika1;
            DupCard1.Image = Properties.Resources.slika1;
            Card2.Image = Properties.Resources.slika2;
            DupCard2.Image = Properties.Resources.slika2;
            Card3.Image = Properties.Resources.slika3;
            DupCard3.Image = Properties.Resources.slika3;
            Card4.Image = Properties.Resources.slika4;
            DupCard4.Image = Properties.Resources.slika4;
            Card5.Image = Properties.Resources.slika5;
            DupCard5.Image = Properties.Resources.slika5;
            Card6.Image = Properties.Resources.slika6;
            DupCard6.Image = Properties.Resources.slika6;




        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            foreach (PictureBox picture in CardsHolder.Controls)
            {
                picture.Enabled = true;
                picture.Cursor = Cursors.Hand;
                picture.Image = Properties.Resources.cover;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int timer = Convert.ToInt32(label3.Text);
            timer = timer - 1;
            label3.Text = Convert.ToString(timer);
            if (timer == 0)
            {
                timer2.Stop();
                btnPomos.Enabled = true;

            }

        }



        private void Card1_Click(object sender, EventArgs e)
        {


            Card1.Image = Properties.Resources.slika1;

            if (PendingImage1 == null)
            {
                Card1.Enabled = false;
                PendingImage1 = Card1;


            }

            else if (PendingImage1 != null && PendingImage2 == null)
            {

                PendingImage2 = Card1;

            }



            if (PendingImage1 != null && PendingImage2 != null)
            {




                if (PendingImage1.Tag == PendingImage2.Tag)
                {


                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card1.Enabled = false;
                    DupCard1.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);

                    playSimpleSound();
                    flag[1] = true;
                    end = end - 2;
                    if (end == 0)
                    {
                        Score score = new Score(ScoreCounter.Text);

                        //   this.Hide();
                        score.Show();
                        this.Close();
                    }
                }
                else
                {
                    PendingImage1.Enabled = true;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
                    playNoSound();
                    timer3.Start();
                }
            }
        }
        private void DupCard1_Click(object sender, EventArgs e)
        {


            DupCard1.Image = Properties.Resources.slika1;
            if (PendingImage1 == null)
            {
                DupCard1.Enabled = false;
                PendingImage1 = DupCard1;

            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = DupCard1;



            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card1.Enabled = false;
                    DupCard1.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                    playSimpleSound();
                    flag[1] = true;
                    end = end - 2;
                    if (end == 0)
                    {
                        Score score = new Score(ScoreCounter.Text);

                        //   this.Hide();
                        score.Show();
                        this.Close();
                    }
                }
                else
                {
                    PendingImage1.Enabled = true;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
                    playNoSound();
                    timer3.Start();
                }
            }
        }

        private void Card2_Click(object sender, EventArgs e)
        {
            Card2.Image = Properties.Resources.slika2;

            if (PendingImage1 == null)
            {
                Card2.Enabled = false;
                PendingImage1 = Card2;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = Card2;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card2.Enabled = false;
                    DupCard2.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                    flag[2] = true;
                    playSimpleSound();
                    end = end - 2;
                    if (end == 0)
                    {
                        Score score = new Score(ScoreCounter.Text);

                        //   this.Hide();
                        score.Show();
                        this.Close();
                    }
                }

                else
                {
                    PendingImage1.Enabled = true;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
                    playNoSound();
                    timer3.Start();
                }
            }
        }

        private void DupCard2_Click(object sender, EventArgs e)
        {
            DupCard2.Image = Properties.Resources.slika2;
            if (PendingImage1 == null)
            {
                DupCard2.Enabled = false;
                PendingImage1 = DupCard2;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = DupCard2;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card2.Enabled = false;
                    DupCard2.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                    flag[2] = true;
                   playSimpleSound();
                    end = end - 2;
                    if (end == 0)
                    {
                        Score score = new Score(ScoreCounter.Text);

                        //   this.Hide();
                        score.Show();
                        this.Close();
                    }
                }
                else
                {
                    PendingImage1.Enabled = true;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
                    playNoSound();
                    timer3.Start();
                }
            }
        }

        private void Card3_Click(object sender, EventArgs e)
        {
            Card3.Image = Properties.Resources.slika3;
            if (PendingImage1 == null)
            {
                Card3.Enabled = false;
                PendingImage1 = Card3;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = Card3;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card3.Enabled = false;
                    DupCard3.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                    flag[3] = true;
                    playSimpleSound();
                    end = end - 2;
                    if (end == 0)
                    {
                        Score score = new Score(ScoreCounter.Text);

                        //   this.Hide();
                        score.Show();
                        this.Close();
                    }
                }
                else
                {
                    PendingImage1.Enabled = true;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
                    playNoSound();
                    timer3.Start();
                }
            }
        }

        private void DupCard3_Click(object sender, EventArgs e)
        {
            DupCard3.Image = Properties.Resources.slika3;
            if (PendingImage1 == null)
            {
                DupCard3.Enabled = false;
                PendingImage1 = DupCard3;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = DupCard3;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card3.Enabled = false;
                    DupCard3.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                    playSimpleSound();
                    flag[3] = true;
                    end = end - 2;
                    if (end == 0)
                    {
                        Score score = new Score(ScoreCounter.Text);

                        //   this.Hide();
                        score.Show();
                        this.Close();
                    }
                }
                else
                {
                    PendingImage1.Enabled = true;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
                    playNoSound();
                    timer3.Start();
                }
            }
        }

        private void Card4_Click(object sender, EventArgs e)
        {
            Card4.Image = Properties.Resources.slika4;
            if (PendingImage1 == null)
            {
                Card4.Enabled = false;
                PendingImage1 = Card4;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = Card4;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card4.Enabled = false;
                    DupCard4.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                    playSimpleSound();
                    flag[4] = true;
                    end = end - 2;
                    if (end == 0)
                    {
                        Score score = new Score(ScoreCounter.Text);

                        //   this.Hide();
                        score.Show();
                        this.Close();
                    }
                }
                else
                {
                    PendingImage1.Enabled = true;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
                    playNoSound();
                    timer3.Start();
                }
            }
        }

        private void DupCard4_Click(object sender, EventArgs e)
        {
            DupCard4.Image = Properties.Resources.slika4;
            if (PendingImage1 == null)
            {
                DupCard4.Enabled = false;
                PendingImage1 = DupCard4;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = DupCard4;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card4.Enabled = false;
                    DupCard4.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                    playSimpleSound();
                    flag[4] = true;
                    end = end - 2;
                    if (end == 0)
                    {
                        Score score = new Score(ScoreCounter.Text);

                        //   this.Hide();
                        score.Show();
                        this.Close();
                    }
                }
                else
                {
                    PendingImage1.Enabled = true;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
                    playNoSound();
                    timer3.Start();
                }
            }
        }

        private void Card5_Click(object sender, EventArgs e)
        {
            Card5.Image = Properties.Resources.slika5;
            if (PendingImage1 == null)
            {
                Card5.Enabled = false;
                PendingImage1 = Card5;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = Card5;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card5.Enabled = false;
                    DupCard5.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                    playSimpleSound();
                    flag[5] = true;
                    end = end - 2;
                    if (end == 0)
                    {
                        Score score = new Score(ScoreCounter.Text);

                        //   this.Hide();
                        score.Show();
                        this.Close();
                    }
                }
                else
                {
                    PendingImage1.Enabled = true;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
                    playNoSound();
                    timer3.Start();
                }
            }
        }

        private void DupCard5_Click(object sender, EventArgs e)
        {
            DupCard5.Image = Properties.Resources.slika5;
            if (PendingImage1 == null)
            {
                DupCard5.Enabled = false;
                PendingImage1 = DupCard5;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = DupCard5;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card5.Enabled = false;
                    DupCard5.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                    playSimpleSound();
                    flag[5] = true;
                    end = end - 2;
                    if (end == 0)
                    {
                        Score score = new Score(ScoreCounter.Text);

                        //   this.Hide();
                        score.Show();
                        this.Close();
                    }
                }
                else
                {
                    PendingImage1.Enabled = true;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
                    playNoSound();
                    timer3.Start();
                }
            }
        }

        private void Card6_Click(object sender, EventArgs e)
        {
            Card6.Image = Properties.Resources.slika6;
            if (PendingImage1 == null)
            {
                Card6.Enabled = false;
                PendingImage1 = Card6;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = Card6;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card6.Enabled = false;
                    DupCard6.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                    playSimpleSound();
                    end = end - 2;
                    flag[6] = true;
                    if (end == 0)
                    {
                        Score score = new Score(ScoreCounter.Text);

                        //   this.Hide();
                        score.Show();
                        this.Close();
                    }
                }
                else
                {
                    PendingImage1.Enabled = true;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
                    playNoSound();
                    timer3.Start();
                }
            }
        }

        private void DupCard6_Click(object sender, EventArgs e)
        {
            DupCard6.Image = Properties.Resources.slika6;
            if (PendingImage1 == null)
            {
                DupCard6.Enabled = false;
                PendingImage1 = DupCard6;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = DupCard6;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card6.Enabled = false;
                    DupCard6.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                    playSimpleSound();
                    flag[6] = true;
                    end = end - 2;
                    if (end == 0)
                    {
                        Score score = new Score(ScoreCounter.Text);

                        //   this.Hide();
                        score.Show();
                        this.Close();
                    }
                }
                else
                {
                    PendingImage1.Enabled = true;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
                    playNoSound();
                    timer3.Start();
                }
            }
        }








        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            PendingImage1.Image = Properties.Resources.cover;
            PendingImage2.Image = Properties.Resources.cover;
            PendingImage1 = null;
            PendingImage2 = null;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblPomos.Text = Convert.ToString("Немате право на помош");
            br++;
            if (br <= 1)
            {
                for (i = 1; i < 7; i++)
                {

                    if (!flag[i])
                    {

                        if (i == 1)
                        {
                            k = i;
                            Card1.Image = Properties.Resources.slika1;
                            DupCard1.Image = Properties.Resources.slika1;
                            Card1.Enabled = false;
                            DupCard1.Enabled = false;

                            timer4.Start();
                            break;



                        }
                        else if (i == 2)
                        {
                            k = i;
                            Card2.Image = Properties.Resources.slika2;
                            DupCard2.Image = Properties.Resources.slika2;

                            Card2.Enabled = false;
                            DupCard2.Enabled = false;
                            timer4.Start();

                            break;

                        }
                        else if (i == 3)
                        {
                            k = i;
                            Card3.Image = Properties.Resources.slika3;
                            DupCard3.Image = Properties.Resources.slika3;
                            Card3.Enabled = false;
                            DupCard3.Enabled = false;

                            timer4.Start();

                            break;

                        }
                        else if (i == 4)
                        {
                            k = i;
                            Card4.Image = Properties.Resources.slika4;
                            DupCard4.Image = Properties.Resources.slika4;
                            Card4.Enabled = false;
                            DupCard4.Enabled = false;

                            timer4.Start();
                            break;


                        }
                        else if (i == 5)
                        {
                            k = i;
                            Card5.Image = Properties.Resources.slika5;
                            DupCard5.Image = Properties.Resources.slika5;
                            Card5.Enabled = false;
                            DupCard5.Enabled = false;

                            timer4.Start();

                            break;

                        }
                        else if (i == 6)
                        {
                            k = i;
                            Card6.Image = Properties.Resources.slika6;
                            DupCard6.Image = Properties.Resources.slika6;
                            Card6.Enabled = false;
                            DupCard6.Enabled = false;

                            timer4.Start();

                            break;

                        }

                    }

                }
              
                btnPomos.Enabled = false;
            }
           
        }


        private void timer4_Tick(object sender, EventArgs e)
        {
           
            
                if (k == 1)
                {
                    Card1.Enabled = true;
                    Card1.Cursor = Cursors.Hand;
                    Card1.Image = Properties.Resources.cover;

                    DupCard1.Enabled = true;
                    DupCard1.Cursor = Cursors.Hand;
                    DupCard1.Image = Properties.Resources.cover;
                  
                }
                if (k == 2)
                {

                    Card2.Enabled = true;
                    Card2.Cursor = Cursors.Hand;
                    Card2.Image = Properties.Resources.cover;

                    DupCard2.Enabled = true;
                    DupCard2.Cursor = Cursors.Hand;
                    DupCard2.Image = Properties.Resources.cover;
                   
                }
                if (k == 3)
                {

                    Card3.Enabled = true;
                    Card3.Cursor = Cursors.Hand;
                    Card3.Image = Properties.Resources.cover;

                    DupCard3.Enabled = true;
                    DupCard3.Cursor = Cursors.Hand;
                    DupCard3.Image = Properties.Resources.cover;
                  
                }
                if (k == 4)
                {

                    Card4.Enabled = true;
                    Card4.Cursor = Cursors.Hand;
                    Card4.Image = Properties.Resources.cover;

                    DupCard4.Enabled = true;
                    DupCard4.Cursor = Cursors.Hand;
                    DupCard4.Image = Properties.Resources.cover;
            
                }
                if (k == 5)
                {

                    Card5.Enabled = true;
                    Card5.Cursor = Cursors.Hand;
                    Card5.Image = Properties.Resources.cover;

                    DupCard5.Enabled = true;
                    DupCard5.Cursor = Cursors.Hand;
                    DupCard5.Image = Properties.Resources.cover;
                  
                }
                if (k == 6)
                {

                    Card6.Enabled = true;
                    Card6.Cursor = Cursors.Hand;
                    Card6.Image = Properties.Resources.cover;

                    DupCard6.Enabled = true;
                    DupCard6.Cursor = Cursors.Hand;
                    DupCard6.Image = Properties.Resources.cover;
                   
                }

                timer4.Stop();

            
        }
        private void timer5_Tick(object sender, EventArgs e)
        {

            if (generateBall % 40 == 0)
            {
                int y = 400;
                int x = this.Width - 100;
                ballsDoc.AddBall(new Point(x, y));


                int i = ballsDoc.i;
                broj = ballsDoc.a[i];



            }

            ++generateBall;
            ballsDoc.Move(Width);
            Invalidate(true);

        }

        private void Easy_Paint(object sender, PaintEventArgs e)
        {
            ballsDoc.Draw(e.Graphics, 1, broevi);
        
        }



    }
}
