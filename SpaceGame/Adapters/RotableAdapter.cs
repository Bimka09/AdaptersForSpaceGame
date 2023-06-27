using SpaceGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.Intrinsics;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame.Adapters
{
    public class RotableAdapter : IRotable
    {
        IBaseModel model;

        public RotableAdapter(IBaseModel model)
        {
            this.model = model;
        }
        public int GetVelosity()
        {
            return (int)model.GetProperty("Velosity");
        }

        public int GetDirection()
        {
            return (int)model.GetProperty("Direction");
        }

        public void SetDirection(int value)
        {
            model.SetProperty("Direction", value);
        }

        public void SetDirectionsNumber(int value)
        {
            model.SetProperty("DirectionsNumber", value);
        }
    }
}
