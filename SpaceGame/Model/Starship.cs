using SpaceGame.Adapters;
using SpaceGame.Interfaces;
using System.Numerics;

namespace SpaceGame.Model
{
    public class Starship : IBaseModel
    {
        public Vector2 Position { get; set; }
        public int Velocity { get; set; }
        public int DirectionsNumber { get; set; }
        public int Direction { get; set; }

        public Starship(int velocity, int directionsNumber, int direction)
        {
            Velocity = velocity;
            DirectionsNumber = directionsNumber;
            Direction = direction;
        }
        public object? GetProperty(string key)
        {
            Type type = typeof(Starship);
            var property = type.GetProperty(key);
            return property?.GetValue(this);
        }

        public void SetProperty(string key, object newValue)
        {
            Type type = typeof(Starship);
            var property = type.GetProperty(key);
            property?.SetValue(this, newValue);
        }
    }
}
