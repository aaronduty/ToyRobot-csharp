using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ToyRobot
{
    class RobotPlacementException : Exception
    {
        public RobotPlacementException(string message) : base(message)
        {
        }
    }
}
