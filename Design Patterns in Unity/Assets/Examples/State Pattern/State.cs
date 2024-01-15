using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//״̬ģʽ
namespace DesignPattern.Example.Pattern
{
    public interface IState
    {
        void HandleState(Context context);
    }

    public class ConcreteStateA : IState
    {
        public void HandleState(Context context)
        {
            Debug.Log("Handle State A");
            context.State = new ConcreteStateB();
        }
    }

    public class ConcreteStateB : IState
    {
        public void HandleState(Context context)
        {
            Debug.Log("Handle State B");
            context.State = new ConcreteStateA();
        }
    }

    public class Context
    {
        public IState State { get; set; }

        public Context(IState state)
        {
            State = state;
        }

        public void Request()
        {
            State.HandleState(this);
        }
    }
}
