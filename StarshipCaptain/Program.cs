using System;

namespace StarshipCaptain
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public void createUniverse()
        {
            point[] universe = new point[15000];

            for (int i = 0; i < 15000; i++)
            {
                Random random = new Random();
                universe[i].setX(random.Next(0, 999), random.Next(0, 999), random.Next(0, 99), random.Next(0, 9));
                universe[i].setY(random.Next(0, 999), random.Next(0, 999), random.Next(0, 99), random.Next(0, 9));
                universe[i].setZ(random.Next(0, 999), random.Next(0, 999), random.Next(0, 99), random.Next(0, 9));
            }
        }

    }

    class point
    {
        int[] x = new int[4];
        int[] y = new int[4];
        int[] z = new int[4];

        public void setX(int a, int b, int c, int d)
        {

            x[0] = a; x[1] = b; x[2] = c; x[3] = d;

        }

        public void setY(int a, int b, int c, int d)
        {
            y[0] = a; y[1] = b; y[2] = c; y[3] = d;

        }

        public void setZ(int a, int b, int c, int d)
        {
            z[0] = a; z[1] = b; z[2] = c; z[3] = d;

        }
    }
}





