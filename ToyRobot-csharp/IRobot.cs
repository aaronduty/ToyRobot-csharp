using System;
using System.Collections.Generic;
using System.Text;

namespace ToyRobot
{
    public interface IRobot
    {
        ITable table { get; }
        int X { get; set; }
        int Y { get; set; }
        Heading F { get; set; }

        void Place(int x, int y, Heading f);
        void Place(ITable table, int x, int y, Heading f);
        void Move();
        void Left();
        void Right();
        String Report();
    }
}
