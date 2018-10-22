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

        private ITable Table { get; set; }

        private int X { get; set; }
        private int Y { get; set; }
        private Heading F { get; set; }

        public void Left()
        {
            switch (F)
            {
                case Heading.NORTH:
                    F = Heading.WEST;
                    break;
                case Heading.EAST:
                    F = Heading.NORTH;
                    break;
                case Heading.SOUTH:
                    F = Heading.EAST;
                    break;
                case Heading.WEST:
                    F = Heading.SOUTH;
                    break;
            }
        }

        public void Move()
        {
            if (Table == null)
            {
                return;
            }

            switch (F)
            {
                case Heading.NORTH:
                    if(Y + 1 < Table.YSize)
                    {
                        Y++;
                    }
                    break;
                case Heading.EAST:
                    var convertedXSize = -(Table.XSize + 1);
                    if (X - 1 >= convertedXSize)
                    {
                        X--;
                    }
                    break;
                case Heading.SOUTH:
                    if (Y - 1 >= 0)
                    {
                        Y--;
                    }
                    break;
                case Heading.WEST:
                    if (X + 1 >= -1)
                    {
                        X++;
                    }
                    break;
            }
        }

        public void Place(int x, int y, Heading f)
        {
            if(Table == null || x < 0 || x >= Table.XSize || y < 0 || y >= Table.YSize)
            {
                throw new RobotPlacementException("Placement failed. X or Y are out of bounds for the supplied surface.");
            }
            X = -(x + 1);
            Y = y;
            F = f;
        }

        public void Place(ITable table, int x, int y, Heading f)
        {
            this.Table = table;
            Place(x, y, f);
        }

        public string Report()
        {
            return String.Format("Output: {0},{1},{2}", (Math.Abs(X) - 1).ToString(), Y.ToString(), F.ToString());
        }

        public void Right()
        {
            switch (F)
            {
                case Heading.NORTH:
                    F = Heading.EAST;
                    break;
                case Heading.EAST:
                    F = Heading.SOUTH;
                    break;
                case Heading.SOUTH:
                    F = Heading.WEST;
                    break;
                case Heading.WEST:
                    F = Heading.NORTH;
                    break;
            }
        }
    }
}
