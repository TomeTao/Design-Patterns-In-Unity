using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//观察者模式
namespace DesignPattern.Example.Pattern
{
    public interface IObserver
    {
        void Update(ISubject subject);
    }

    public interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify();
    }

    public abstract class Subject : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (IObserver observer in _observers)
            {
                observer.Update(this);
            }
        }
    }

    public class ConcreteSubject : Subject
    {
        private string _state;

        public string State
        {
            get
            {
                return _state;
            }
            set
            {
                _state = value;
                Notify();
            }
        }
    }

    public class ConcreteObserver : IObserver
    {
        private string _observerState;

        public void Update(ISubject subject)
        {
            if (subject is ConcreteSubject)
            {
                ConcreteSubject concreteSubject = (ConcreteSubject)subject;
                _observerState = concreteSubject.State;
                Debug.Log("Observer State: " + _observerState);
            }
        }
    }
}
