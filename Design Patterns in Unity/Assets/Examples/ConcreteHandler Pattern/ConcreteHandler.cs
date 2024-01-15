using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//处理者模式
namespace DesignPattern.Example.Pattern
{
    public abstract class Handler
    {
        protected Handler _successor;

        public void SetSuccessor(Handler successor)
        {
            _successor = successor;
        }

        public abstract void HandleRequest(int request);
    }

    public class ConcreteHandlerA : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 0 && request < 10)
            {
                Debug.Log("Handled by Concrete Handler A");
            }
            else if (_successor != null)
            {
                _successor.HandleRequest(request);
            }
        }
    }

    public class ConcreteHandlerB : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 10 && request < 20)
            {
                Debug.Log("Handled by Concrete Handler B");
            }
            else if (_successor != null)
            {
                _successor.HandleRequest(request);
            }
        }
    }

    public class ConcreteHandlerC : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 20 && request < 30)
            {
                Debug.Log("Handled by Concrete Handler C");
            }
            else if (_successor != null)
            {
                _successor.HandleRequest(request);
            }
        }
    }

    public class Client
    {
        private Handler _handlerChain;
        public Client()
        {
            _handlerChain = new ConcreteHandlerA();
            Handler handlerB = new ConcreteHandlerB();
            Handler handlerC = new ConcreteHandlerC();
            _handlerChain.SetSuccessor(handlerB);
            handlerB.SetSuccessor(handlerC);
        }

        public void ProcessRequests()
        {
            int[] requests = new int[] { 2, 17, 25, 40, 5 };

            foreach (int request in requests)
            {
                _handlerChain.HandleRequest(request);
            }
        }
    }
}
