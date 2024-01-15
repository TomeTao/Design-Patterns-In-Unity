using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//ге╫сдёй╫
namespace DesignPattern.Example.Pattern
{
    public abstract class Shape
    {
        protected IDrawAPI _drawAPI;

        protected Shape(IDrawAPI drawAPI)
        {
            _drawAPI = drawAPI;
        }

        public abstract void Draw();
    }

    public interface IDrawAPI
    {
        void DrawCircle(int x, int y, int radius);
    }

    public class DrawAPI1 : IDrawAPI
    {
        public void DrawCircle(int x, int y, int radius)
        {
            Debug.Log("DrawAPI1 Circle " + x + "," + y + "," + radius);
        }
    }

    public class DrawAPI2 : IDrawAPI
    {
        public void DrawCircle(int x, int y, int radius)
        {
            Debug.Log("DrawAPI2 Circle " + x + "," + y + "," + radius);
        }
    }

    public class Circle : Shape
    {
        private int _x, _y, _radius;

        public Circle(int x, int y, int radius, IDrawAPI drawAPI) : base(drawAPI)
        {
            _x = x;
            _y = y;
            _radius = radius;
        }

        public override void Draw()
        {
            _drawAPI.DrawCircle(_x, _y, _radius);
        }
    }
}
