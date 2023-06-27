using SpaceGame.Interfaces;
using System.Numerics;

namespace SpaceGame.Adapters
{
    public class MovableAdpater : IMovable
    {
        IBaseModel model;
        public MovableAdpater(IBaseModel o)
        {
            this.model = o;
        }
        public Vector2 GetPosition()
        {
            return (Vector2)model.GetProperty("Position");
        }
        public void SetPosition(Vector2 vector)
        {
            model.SetProperty("Position", vector);
        }
        public Vector2 GetVelocity()
        {
            int direction = (int)model.GetProperty("Direction");
            int directionNumber = (int)model.GetProperty("DirectionsNumber");
            int velocity = (int)model.GetProperty("Velocity");
            return new Vector2((float)(velocity * Math.Cos(direction / 360 * directionNumber)), (float)(velocity * Math.Sin(direction / 360 * directionNumber)));
        }
        public void Move()
        {
            SetPosition(GetPosition() + GetVelocity());
        }
    }
}
