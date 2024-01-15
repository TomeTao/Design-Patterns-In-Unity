using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//中介者模式
namespace DesignPattern.Example.Pattern
{
    public abstract class Colleague
    {
        protected IMediator _mediator;

        public Colleague(IMediator mediator)
        {
            _mediator = mediator;
        }

        public abstract void Send(string message);
        public abstract void Receive(string message);
    }

    public interface IMediator
    {
        void AddColleague(Colleague colleague);
        void SendMessage(Colleague sender, string message);
    }

    public class ConcreteColleagueA : Colleague
    {
        public ConcreteColleagueA(IMediator mediator) : base(mediator)
        {
        }

        public override void Send(string message)
        {
            _mediator.SendMessage(this, message);
        }

        public override void Receive(string message)
        {
            Debug.Log("Concrete Colleague A received message: " + message);
        }
    }

    public class ConcreteColleagueB : Colleague
    {
        public ConcreteColleagueB(IMediator mediator) : base(mediator)
        {
        }

        public override void Send(string message)
        {
            _mediator.SendMessage(this, message);
        }

        public override void Receive(string message)
        {
            Debug.Log("Concrete Colleague B received message: " + message);
        }
    }

    public class ConcreteMediator : IMediator
    {
        private List<Colleague> _colleagues = new List<Colleague>();

        public void AddColleague(Colleague colleague)
        {
            _colleagues.Add(colleague);
        }

        public void SendMessage(Colleague sender, string message)
        {
            foreach (Colleague colleague in _colleagues)
            {
                if (colleague != sender)
                {
                    colleague.Receive(message);
                }
            }
        }
    }
}
