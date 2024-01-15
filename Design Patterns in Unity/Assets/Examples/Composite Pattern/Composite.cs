using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//组合模式
namespace DesignPattern.Example.Pattern
{
    public abstract class Component
    {
        protected string _name;

        public Component(string name)
        {
            _name = name;
        }

        public abstract void Add(Component component);
        public abstract void Remove(Component component);
        public abstract void Display(int depth);
    }

    public class Leaf : Component
    {
        public Leaf(string name) : base(name)
        {
        }

        public override void Add(Component component)
        {
            Debug.Log("Cannot add to a leaf.");
        }

        public override void Remove(Component component)
        {
            Debug.Log("Cannot remove from a leaf.");
        }

        public override void Display(int depth)
        {
            Debug.Log(new string('-', depth) + " " + _name);
        }
    }

    public class Composite : Component
    {
        private List<Component> _children = new List<Component>();
        public Composite(string name) : base(name)
        {
        }

        public override void Add(Component component)
        {
            _children.Add(component);
        }

        public override void Remove(Component component)
        {
            _children.Remove(component);
        }

        public override void Display(int depth)
        {
            Debug.Log(new string('-', depth) + " " + _name);

            foreach (Component component in _children)
            {
                component.Display(depth + 2);
            }
        }
    }
}