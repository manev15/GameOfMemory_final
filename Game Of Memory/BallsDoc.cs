using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Of_Memory
{
    [Serializable]
    public class BallsDoc
    {
        public List<Ball> Balls { get; set; }
        public int g = 0;
        public int broj;
        public int[] broevi1;
        public string[] a;
        public int i = 0;
        public int k = 0;
        int o = 0;
        public BallsDoc(int[] broevi)
        {
            Balls = new List<Ball>();
            broevi1 = broevi;
             a = new string[100];
        }
        
        public void AddBall(Point center)
        {
            Random r = new Random();
            Point center1 = center;
            if (g >= 20)
            {
                int t = g / 20;
                center1.Y += t * 40;

                center1.X -= t * 400;
                center1.X += g * 20;
                
                    o++;
                    broj = o;
             
                broevi1 = broevi1.Except(new int[] { broj }).ToArray();
                Ball b = new Ball(broj);

                b.Center1 = center1;
                b.Center = center;

                Balls.Add(b);
                g += 2;
            }
            else
            {
                
                    o++;
                    broj = o;

              
                broevi1 = broevi1.Except(new int[] { broj }).ToArray();
                Ball b = new Ball(broj);
                center1.X += g * 20;



                b.Center1 = center1;
                b.Center = center;
                Balls.Add(b);
                g += 2;
            }
        }


        public void Move(int width)
        {
            foreach (Ball b in Balls)
            {

                if (b.Center.Y > 230)
                    b.Move();

            }
        }


        public void Draw(Graphics g, int t, int[] broevi)
        {
           
                foreach (Ball b in Balls)
                {
                    b.Draw(g, a, i, broevi);


                }
            

        }



    }
}
