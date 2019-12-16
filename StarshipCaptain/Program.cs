using System;
using System.Collections.Generic;

namespace StarshipCaptain
{
    class Program
    {

        static void Main(string[] args)
        {
            createUniverse();

        }

        public void colonise() { }

        public static void print()
        {

        }
        public static void createUniverse()
        {
            //point[] universe = new point[15000]; //convert to list
            var universe = new List<point>();

            for (int i = 0; i < 15000; i++)
            {

                Random random1 = new Random();
                bool IsMonster = random1.Next(100) % 2 == 0;

                if (IsMonster)
                {
                    universe.Add(new monster());
                }
                else
                {
                    universe.Add(new planet());
                }

                Random random = new Random();
                universe[i].setX(random.Next(0, 999), random.Next(0, 999), random.Next(0, 99), random.Next(0, 9));
                universe[i].setY(random.Next(0, 999), random.Next(0, 999), random.Next(0, 99), random.Next(0, 9));
                universe[i].setZ(random.Next(0, 999), random.Next(0, 999), random.Next(0, 99), random.Next(0, 9));
                universe[i].pos = i;
                Console.WriteLine(universe[i].ToString());
            }


        }

    }

    class point
    {
        public int[] x = new int[4];
        public int[] y = new int[4];
        public int[] z = new int[4];

        public int pos;
        public void setX(int a, int b, int c, int d)
        {

            x[0] = a;
            x[1] = b;
            x[2] = c;
            x[3] = d;

        }

        public void setY(int a, int b, int c, int d)
        {
            y[0] = a;
            y[1] = b;
            y[2] = c;
            y[3] = d;

        }

        public void setZ(int a, int b, int c, int d)
        {
            z[0] = a;
            z[1] = b;
            z[2] = c;
            z[3] = d;

        }
    }

    class planet : point
    {
        public bool habitable = false; //default not habitable 
        public int sArea = 0; //surface area (millions of km^2): 0 default for non habitable
        public bool colonised = false;
        public int aColonised = 0; //area colonised
        public bool travelled = false; //has it landed on this point?
        public int travelTime = 10; //time in mins

        public bool isHabitable() { return habitable; }

        public planet()
        {
            Random random = new Random();
            habitable = random.Next(100) % 2 == 0; //randomly set habitable

            if (habitable)
            {
                Random random1 = new Random();
                sArea = random1.Next(1, 100);
            }

        }
        public override string ToString()
        {

            return pos.ToString() + '\t' + "planet" + '\t' + travelled + '\t' + travelTime + " minutes" + '\t' + habitable;
        }
    }

    class monster : point
    {
        public int travelTime = 20; //time in mins
        public bool travelled = false; //has it landed on this point?

        public int getTravelTime() { return travelTime; }

        public void setTravelled(bool tr) { travelled = tr; }

        public bool getTravelled() { return travelled; }

        public override string ToString()
        {

            return pos.ToString() + '\t' + "monster" + '\t' + travelled + '\t' + travelTime + " minutes" + '\t' + "N/A";
        }

    }
}