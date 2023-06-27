using System.Numerics;

namespace SpaceGame.Interfaces
{
    public interface IMovable
    {
        public Vector2 GetPosition();
        public void SetPosition(Vector2 vector);
        public Vector2 GetVelocity();
        public void Move();
    }
}
