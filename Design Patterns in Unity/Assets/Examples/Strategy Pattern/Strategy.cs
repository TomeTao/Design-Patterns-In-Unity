using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//²ßÂÔÄ£Ê½
namespace DesignPattern.Example.StrategyPattern
{
    public interface IStrategy
    {
        void Execute();
    }

    public class ConcreteStrategyA : IStrategy
    {
        public void Execute()
        {
            Debug.Log("Execute Strategy A");
        }
    }

    public class ConcreteStrategyB : IStrategy
    {
        public void Execute()
        {
            Debug.Log("Execute Strategy B");
        }
    }

    public class Context
    {
        private IStrategy _strategy;

        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void DoAction()
        {
            _strategy.Execute();
        }
    }
}