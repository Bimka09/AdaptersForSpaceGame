using Xunit;
using SpaceGame.Model;
using SpaceGame.Adapters;
using System.Numerics;
using SpaceGame.Interfaces;
using System;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestPositionSearch()
        {
            var starship = new Starship(-7, 1, 3);
            var moveAdapter = new MovableAdpater(starship);
            moveAdapter.SetPosition(new Vector2(12, 5));
            moveAdapter.Move();

            Assert.Equal(new Vector2(5, 8), moveAdapter.GetPosition());
        }

        [Fact]
        public void GetDoesntExcistingPosition()
        {
            var moveAdapter = new MovableAdpater(null);

            // Попытка сдвинуть объект, у которого невозможно прочитать положение в пространстве, приводит к ошибке
            Assert.Throws<NullReferenceException>(() => moveAdapter.GetPosition());
        }

        [Fact]
        public void GetDoesntExcistingVelosity()
        {
            var moveAdapter = new MovableAdpater(null);

            // Попытка сдвинуть объект, у которого невозможно прочитать значение мгновенной скорости, приводит к ошибке
            Assert.Throws<NullReferenceException>(() => moveAdapter.GetVelocity());
        }

        [Fact]
        public void MoveNullObject()
        {
            var moveAdapter = new MovableAdpater(null);

            // Попытка сдвинуть объект, у которого невозможно изменить положение в пространстве, приводит к ошибке
            Assert.Throws<NullReferenceException>(() => moveAdapter.Move());
        }

        [Fact]
        public void SetDoesntExcistingDirection()
        {
            var rotateAdapter = new RotableAdapter(null);

            // Попытка сдвинуть объект, у которого невозможно прочитать значение мгновенной скорости, приводит к ошибке
            Assert.Throws<NullReferenceException>(() => rotateAdapter.SetDirection(5));
        }
    }
}