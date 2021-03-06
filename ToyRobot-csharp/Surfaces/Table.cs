﻿using System;
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
            if(xSize < 1 || ySize < 1)
            {
                throw new NegativeOrZeroDimensionException();
            }
            
            XSize = xSize;
            YSize = ySize;
        }
    }
}
