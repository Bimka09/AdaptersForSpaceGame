using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame.Interfaces
{
    public interface IRotable
    {
        public int GetDirection();
        public void SetDirection(int value);
        public void SetDirectionsNumber(int value);
        public int GetVelosity();
    }
}
