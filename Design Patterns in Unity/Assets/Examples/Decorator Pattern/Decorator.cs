using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//装饰者模式
namespace DesignPattern.Example.DecoratorPattern
{
    public abstract class Component
    {
        public abstract void Operation();
    }

    public class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Debug.Log("Concrete Component Operation");
        }
    }

    public abstract class Decorator : Component
    {
        private Component _component;

        public Decorator(Component component)
        {
            _component = component;
        }

        public override void Operation()
        {
            if (_component != null)
            {
                _component.Operation();
            }
        }
    }

    public class ConcreteDecoratorA : Decorator
    {
        public ConcreteDecoratorA(Component component) : base(component)
        {
        }

        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
            Debug.Log("Concrete Decorator A Operation");
        }

        private void AddedBehavior()
        {
            Debug.Log("Added Behavior from Concrete Decorator A");
        }
    }

    public class ConcreteDecoratorB : Decorator
    {
        public ConcreteDecoratorB(Component component) : base(component)
        {
        }

        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
            Debug.Log("Concrete Decorator B Operation");
        }

        private void AddedBehavior()
        {
            Debug.Log("Added Behavior from Concrete Decorator B");
        }
    }
}
