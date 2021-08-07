using SFML.Graphics;

namespace Leveling_Up
{
    interface IColisionable
    {
        public FloatRect GetBounds();
        public void OnCollision(IColisionable other);
        public void OnCollisionEnter(IColisionable other);
        public void OnCollisionExit(IColisionable other);
    }
}