using System;
using System.Collections.Generic;
using System.Text;

namespace ToyRobot
{
    public class Robot : IRobot
    {
        public Robot(ITable table, int x, int y, Heading f)
        {
            Place(table, x, y, f);
        }

        public ITable Table { get; private set; }

        public int X { get; set; }
        public int Y { get; set; }
        public Heading F { get; set; }

        public void Left()
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            throw new NotImplementedException();
        }

        public void Place(int x, int y, Heading f)
        {
            throw new NotImplementedException();
        }

        public void Place(ITable table, int x, int y, Heading f)
        {
            throw new NotImplementedException();
        }

        public string Report()
        {
            throw new NotImplementedException();
        }

        public void Right()
        {
            throw new NotImplementedException();
        }
    }
}
