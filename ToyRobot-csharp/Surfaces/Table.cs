using System;
using System.Collections.Generic;
using System.Text;

namespace ToyRobot
{
    public class Table : ITable
    {
        public int XSize { get; }
        public int YSize { get; }

        public Table(int xSize, int ySize)
        {
            XSize = xSize;
            YSize = ySize;
        }
    }
}
