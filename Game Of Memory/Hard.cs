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
    public partial class Hard : Form
    {
        int score = 0;
        int end;
        int k;
        int i;
        int br = 0;
        int br1 = 3;
        bool[] flag;
        private BallsDoc ballsDoc;
        public int[] broevi;
        private int generateBall;
        private Timer timer5;
        public string broj;
        public int f = 0;
        public string[] a;

        bool again = false;
        Random Location = new Random();
        List<Point> points = new List<Point>();


        PictureBox PendingImage1;
        PictureBox PendingImage2;

        public Hard()
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
      

        private void Form2_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            end = CardsHolder.Controls.Count;
            flag = new bool[end + 1];
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
            Card7.Image = Properties.Resources.slika7;
            DupCard7.Image = Properties.Resources.slika7;
            Card8.Image = Properties.Resources.slika8;
            DupCard8.Image = Properties.Resources.slika8;
            Card9.Image = Properties.Resources.slika9;
            DupCard9.Image = Properties.Resources.slika9;
            Card10.Image = Properties.Resources.slika10;
            DupCard10.Image = Properties.Resources.slika10;
            Card11.Image = Properties.Resources.slika11;
            DupCard11.Image = Properties.Resources.slika11;
            Card12.Image = Properties.Resources.slika12;
            DupCard12.Image = Properties.Resources.slika12;
            Card13.Image = Properties.Resources.slika13;
            DupCard13.Image = Properties.Resources.slika13;
            Card14.Image = Properties.Resources.slika14;
            DupCard14.Image = Properties.Resources.slika14;
            Card15.Image = Properties.Resources.slika15;
            DupCard15.Image = Properties.Resources.slika15;


            label2.Text = "Имате право на 3 помош";


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
                button1.Enabled = true;

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
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 30);
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
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 30);
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
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 30);
                    playSimpleSound();
                    flag[2] = true;
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
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 30);
                    playSimpleSound();
                    flag[2] = true;
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
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 30);
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
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 30);
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
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 30);
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
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 30);
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
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 30);
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
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 30);
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
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 30);
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
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 30);
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

        private void Card7_Click(object sender, EventArgs e)
        {
            Card7.Image = Properties.Resources.slika7;
            if (PendingImage1 == null)
            {
                Card7.Enabled = false;
                PendingImage1 = Card7;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = Card7;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card7.Enabled = false;
                    DupCard7.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 30);
                    playSimpleSound();
                    flag[7] = true;
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

        private void DupCard7_Click(object sender, EventArgs e)
        {
            DupCard7.Image = Properties.Resources.slika7;
            if (PendingImage1 == null)
            {
                DupCard7.Enabled = false;
                PendingImage1 = DupCard7;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = DupCard7;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card7.Enabled = false;
                    DupCard7.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 30);
                    playSimpleSound();
                    flag[7] = true;
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

        private void Card8_Click(object sender, EventArgs e)
        {
            Card8.Image = Properties.Resources.slika8;
            if (PendingImage1 == null)
            {
                Card8.Enabled = false;
                PendingImage1 = Card8;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = Card8;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card8.Enabled = false;
                    DupCard8.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 30);
                    playSimpleSound();
                    flag[8] = true;
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

        private void DupCard8_Click(object sender, EventArgs e)
        {
            DupCard8.Image = Properties.Resources.slika8;
            if (PendingImage1 == null)
            {
                DupCard8.Enabled = false;
                PendingImage1 = DupCard8;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = DupCard8;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card8.Enabled = false;
                    DupCard8.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 30);
                    playSimpleSound();
                    flag[8] = true;
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

        private void Card9_Click_1(object sender, EventArgs e)
        {


            Card9.Image = Properties.Resources.slika9;

            if (PendingImage1 == null)
            {
                Card9.Enabled = false;
                PendingImage1 = Card9;


            }

            else if (PendingImage1 != null && PendingImage2 == null)
            {

                PendingImage2 = Card9;

            }



            if (PendingImage1 != null && PendingImage2 != null)
            {




                if (PendingImage1.Tag == PendingImage2.Tag)
                {


                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card9.Enabled = false;
                    DupCard9.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 30);
                    playSimpleSound();
                    flag[9] = true;
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
        private void DupCard9_Click_1(object sender, EventArgs e)
        {


            DupCard9.Image = Properties.Resources.slika9;
            if (PendingImage1 == null)
            {
                DupCard9.Enabled = false;
                PendingImage1 = DupCard9;

            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = DupCard9;



            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card9.Enabled = false;
                    DupCard9.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 30);
                    playSimpleSound();
                    flag[9] = true;
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

        private void Card10_Click_1(object sender, EventArgs e)
        {


            Card10.Image = Properties.Resources.slika10;

            if (PendingImage1 == null)
            {
                Card10.Enabled = false;
                PendingImage1 = Card10;


            }

            else if (PendingImage1 != null && PendingImage2 == null)
            {

                PendingImage2 = Card10;

            }



            if (PendingImage1 != null && PendingImage2 != null)
            {




                if (PendingImage1.Tag == PendingImage2.Tag)
                {


                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card10.Enabled = false;
                    DupCard10.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 30);
                    playSimpleSound();
                    flag[10] = true;
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
        private void DupCard10_Click_1(object sender, EventArgs e)
        {


            DupCard10.Image = Properties.Resources.slika10;
            if (PendingImage1 == null)
            {
                DupCard10.Enabled = false;
                PendingImage1 = DupCard10;

            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = DupCard10;



            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card10.Enabled = false;
                    DupCard10.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 30);
                    playSimpleSound();
                    flag[10] = true;
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
        private void Card11_Click_1(object sender, EventArgs e)
        {


            Card11.Image = Properties.Resources.slika11;

            if (PendingImage1 == null)
            {
                Card11.Enabled = false;
                PendingImage1 = Card11;


            }

            else if (PendingImage1 != null && PendingImage2 == null)
            {

                PendingImage2 = Card11;

            }



            if (PendingImage1 != null && PendingImage2 != null)
            {




                if (PendingImage1.Tag == PendingImage2.Tag)
                {

                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card11.Enabled = false;
                    DupCard11.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 30);
                    playSimpleSound();
                    flag[11] = true;
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
        private void DupCard11_Click_1(object sender, EventArgs e)
        {


            DupCard11.Image = Properties.Resources.slika11;
            if (PendingImage1 == null)
            {
                DupCard11.Enabled = false;
                PendingImage1 = DupCard11;

            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = DupCard11;



            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card11.Enabled = false;
                    DupCard11.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 30);
                    playSimpleSound();
                    flag[11] = true;
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

        private void Card12_Click_1(object sender, EventArgs e)
        {


            Card12.Image = Properties.Resources.slika12;

            if (PendingImage1 == null)
            {
                Card12.Enabled = false;
                PendingImage1 = Card12;


            }

            else if (PendingImage1 != null && PendingImage2 == null)
            {

                PendingImage2 = Card12;

            }



            if (PendingImage1 != null && PendingImage2 != null)
            {




                if (PendingImage1.Tag == PendingImage2.Tag)
                {


                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card12.Enabled = false;
                    DupCard12.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 30);
                    playSimpleSound();
                    flag[12] = true;
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
        private void DupCard12_Click_1(object sender, EventArgs e)
        {


            DupCard12.Image = Properties.Resources.slika12;
            if (PendingImage1 == null)
            {
                DupCard12.Enabled = false;
                PendingImage1 = DupCard12;

            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = DupCard12;



            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card12.Enabled = false;
                    DupCard12.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 30);
                    playSimpleSound();
                    flag[12] = true;
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

        private void Card13_Click_1(object sender, EventArgs e)
        {


            Card13.Image = Properties.Resources.slika13;

            if (PendingImage1 == null)
            {
                Card13.Enabled = false;
                PendingImage1 = Card13;


            }

            else if (PendingImage1 != null && PendingImage2 == null)
            {

                PendingImage2 = Card13;

            }



            if (PendingImage1 != null && PendingImage2 != null)
            {




                if (PendingImage1.Tag == PendingImage2.Tag)
                {


                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card13.Enabled = false;
                    DupCard13.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 30);
                    playSimpleSound();
                    flag[13] = true;
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
        private void DupCard13_Click_1(object sender, EventArgs e)
        {


            DupCard13.Image = Properties.Resources.slika13;
            if (PendingImage1 == null)
            {
                DupCard13.Enabled = false;
                PendingImage1 = DupCard13;

            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = DupCard13;



            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card13.Enabled = false;
                    DupCard13.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 30);
                    playSimpleSound();
                    flag[13] = true;
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

        private void Card14_Click_1(object sender, EventArgs e)
        {


            Card14.Image = Properties.Resources.slika14;

            if (PendingImage1 == null)
            {
                Card14.Enabled = false;
                PendingImage1 = Card14;


            }

            else if (PendingImage1 != null && PendingImage2 == null)
            {

                PendingImage2 = Card14;

            }



            if (PendingImage1 != null && PendingImage2 != null)
            {




                if (PendingImage1.Tag == PendingImage2.Tag)
                {


                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card14.Enabled = false;
                    DupCard14.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 30);
                    playSimpleSound();
                    flag[14] = true;
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
        private void DupCard14_Click_1(object sender, EventArgs e)
        {


            DupCard14.Image = Properties.Resources.slika14;
            if (PendingImage1 == null)
            {
                DupCard14.Enabled = false;
                PendingImage1 = DupCard14;

            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = DupCard14;



            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card14.Enabled = false;
                    DupCard14.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 30);
                    playSimpleSound();
                    flag[14] = true;
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

        private void Card15_Click_1(object sender, EventArgs e)
        {


            Card15.Image = Properties.Resources.slika15;

            if (PendingImage1 == null)
            {
                Card15.Enabled = false;
                PendingImage1 = Card15;


            }

            else if (PendingImage1 != null && PendingImage2 == null)
            {

                PendingImage2 = Card15;

            }



            if (PendingImage1 != null && PendingImage2 != null)
            {




                if (PendingImage1.Tag == PendingImage2.Tag)
                {


                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card15.Enabled = false;
                    DupCard15.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 30);
                    playSimpleSound();
                    flag[15] = true;
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
        private void DupCard15_Click_1(object sender, EventArgs e)
        {


            DupCard15.Image = Properties.Resources.slika15;
            if (PendingImage1 == null)
            {
                DupCard15.Enabled = false;
                PendingImage1 = DupCard15;

            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = DupCard15;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card15.Enabled = false;
                    //DupCard15.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 30); playSimpleSound();
                    flag[15] = true;
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
            br++;
            br1--;
            if (br < 4)
            {
                for (i = 1; i < 16; i++)
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

                        else if (i == 7)
                        {
                            k = i;
                            Card7.Image = Properties.Resources.slika7;
                            DupCard7.Image = Properties.Resources.slika7;
                            Card7.Enabled = false;
                            DupCard7.Enabled = false;

                            timer4.Start();

                            break;

                        }

                        else if (i == 8)
                        {
                            k = i;
                            Card8.Image = Properties.Resources.slika8;
                            DupCard8.Image = Properties.Resources.slika8;
                            Card8.Enabled = false;
                            DupCard8.Enabled = false;
                            timer4.Start();
                            break;
                        }

                        else if (i == 9)
                        {
                            k = i;
                            Card9.Image = Properties.Resources.slika9;
                            DupCard9.Image = Properties.Resources.slika9;
                            Card9.Enabled = false;
                            DupCard9.Enabled = false;
                            timer4.Start();
                            break;
                        }
                        else if (i == 10)
                        {
                            k = i;
                            Card10.Image = Properties.Resources.slika10;
                            DupCard10.Image = Properties.Resources.slika10;
                            Card10.Enabled = false;
                            DupCard10.Enabled = false;
                            timer4.Start();
                            break;
                        }
                        else if (i == 11)
                        {
                            k = i;
                            Card11.Image = Properties.Resources.slika11;
                            DupCard11.Image = Properties.Resources.slika11;
                            Card11.Enabled = false;
                            DupCard11.Enabled = false;
                            timer4.Start();
                            break;
                        }
                        else if (i == 12)
                        {
                            k = i;
                            Card12.Image = Properties.Resources.slika12;
                            DupCard12.Image = Properties.Resources.slika12;
                            Card12.Enabled = false;
                            DupCard12.Enabled = false;
                            timer4.Start();
                            break;
                        }
                        else if (i == 13)
                        {
                            k = i;
                            Card13.Image = Properties.Resources.slika13;
                            DupCard13.Image = Properties.Resources.slika13;
                            Card13.Enabled = false;
                            DupCard13.Enabled = false;
                            timer4.Start();
                            break;
                        }
                        else if (i == 14)
                        {
                            k = i;
                            Card14.Image = Properties.Resources.slika14;
                            DupCard14.Image = Properties.Resources.slika14;
                            Card14.Enabled = false;
                            DupCard14.Enabled = false;
                            timer4.Start();
                            break;
                        }
                        else if (i == 15)
                        {
                            k = i;
                            Card15.Image = Properties.Resources.slika15;
                            DupCard15.Image = Properties.Resources.slika15;
                            Card15.Enabled = false;
                            DupCard15.Enabled = false;
                            timer4.Start();
                            break;
                        }


                    }
                }
                label2.Text = Convert.ToString("Имате право на " + br1 + " помош");
                if (br == 3)
                {
                    button1.Enabled = false;
                    label2.Text = "Немате право на помош!!";
                }
            }
            else
            {

                button1.Enabled = false;

            }
        }

       

        private void timer4_Tick_1(object sender, EventArgs e)
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

            if (k == 7)
            {

                Card7.Enabled = true;
                Card7.Cursor = Cursors.Hand;
                Card7.Image = Properties.Resources.cover;

                DupCard7.Enabled = true;
                DupCard7.Cursor = Cursors.Hand;
                DupCard7.Image = Properties.Resources.cover;
            }

            if (k == 8)
            {

                Card8.Enabled = true;
                Card8.Cursor = Cursors.Hand;
                Card8.Image = Properties.Resources.cover;

                DupCard8.Enabled = true;
                DupCard8.Cursor = Cursors.Hand;
                DupCard8.Image = Properties.Resources.cover;
            }
            if (k == 9)
            {

                Card9.Enabled = true;
                Card9.Cursor = Cursors.Hand;
                Card9.Image = Properties.Resources.cover;

                DupCard9.Enabled = true;
                DupCard9.Cursor = Cursors.Hand;
                DupCard9.Image = Properties.Resources.cover;
            }
            if (k == 10)
            {

                Card10.Enabled = true;
                Card10.Cursor = Cursors.Hand;
                Card10.Image = Properties.Resources.cover;

                DupCard10.Enabled = true;
                DupCard10.Cursor = Cursors.Hand;
                DupCard10.Image = Properties.Resources.cover;
            }
            if (k == 11)
            {

                Card11.Enabled = true;
                Card11.Cursor = Cursors.Hand;
                Card11.Image = Properties.Resources.cover;

                DupCard11.Enabled = true;
                DupCard11.Cursor = Cursors.Hand;
                DupCard11.Image = Properties.Resources.cover;
            }
            if (k == 12)
            {

                Card12.Enabled = true;
                Card12.Cursor = Cursors.Hand;
                Card12.Image = Properties.Resources.cover;

                DupCard12.Enabled = true;
                DupCard12.Cursor = Cursors.Hand;
                DupCard12.Image = Properties.Resources.cover;
            }
            if (k == 13)
            {

                Card13.Enabled = true;
                Card13.Cursor = Cursors.Hand;
                Card13.Image = Properties.Resources.cover;

                DupCard13.Enabled = true;
                DupCard13.Cursor = Cursors.Hand;
                DupCard13.Image = Properties.Resources.cover;
            }
            if (k == 14)
            {

                Card14.Enabled = true;
                Card14.Cursor = Cursors.Hand;
                Card14.Image = Properties.Resources.cover;

                DupCard14.Enabled = true;
                DupCard14.Cursor = Cursors.Hand;
                DupCard14.Image = Properties.Resources.cover;

            }
            if (k == 15)
            {

                Card15.Enabled = true;
                Card15.Cursor = Cursors.Hand;
                Card15.Image = Properties.Resources.cover;

                DupCard15.Enabled = true;
                DupCard15.Cursor = Cursors.Hand;
                DupCard15.Image = Properties.Resources.cover;

            }




            timer4.Stop();



        }
        private void timer5_Tick(object sender, EventArgs e)
        {

            if (generateBall % 25 == 0)
            {
                int y = 500;
                int x = this.Width - 100;
                ballsDoc.AddBall(new Point(x, y));


                int i = ballsDoc.i;
                broj = ballsDoc.a[i];



            }

            ++generateBall;
            ballsDoc.Move(Width);
            Invalidate(true);

        }

        private void Hard_Paint(object sender, PaintEventArgs e)
        {
            ballsDoc.Draw(e.Graphics, 1, broevi);
        }


    }
}
