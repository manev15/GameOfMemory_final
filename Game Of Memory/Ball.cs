using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Of_Memory
{
    [Serializable]
    public class Ball
    {
        public static readonly int RADIUS = 35;
        public static readonly int RADIUS1 = 25;
        public int Digit { get; set; }

        public Brush b { get; set; }
        public int i = 0;
        public Point Center { get; set; }
        public Point Center1 { get; set; }
        public bool flag;

        public Ball(int broj)
        {
            Digit = broj;

            Center1 = new Point(300, 200);
        }

        public void Move()
        {
            Center = new Point(Center.X, Center.Y - 10);


        }
       
        public void Draw(Graphics g, string[] a, int i, int[] broevi)
        {
            a[i] = Digit.ToString();





            b = new SolidBrush(Color.AliceBlue);

            Font f = new Font("Arial", 24);
            g.FillEllipse(b, Center.X - RADIUS, Center.Y - RADIUS, RADIUS * 2, RADIUS * 2);
            if (Digit < 10)
                g.DrawString(string.Format("{0}", Digit), f, Brushes.Black, Center.X - 13, Center.Y - 15);
            else
                g.DrawString(string.Format("{0}", Digit), f, Brushes.Black, Center.X - 22, Center.Y - 17);
            b.Dispose();

        }
      
      


    }
}
