using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//责任链模式
namespace DesignPattern.Example.ChainOfResponsibilityPattern
{
    public abstract class Handler
    {
        private Handler _nextHandler;

        public Handler NextHandler
        {
            get
            {
                return _nextHandler;
            }
            set
            {
                _nextHandler = value;
            }
        }

        public abstract void HandleRequest(int request);
    }

    public class ConcreteHandlerA : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request < 0)
            {
                Debug.Log("Negative request handled by Handler A");
            }
            else if (NextHandler != null)
            {
                NextHandler.HandleRequest(request);
            }
        }
    }

    public class ConcreteHandlerB : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request > 100)
            {
                Debug.Log("Request > 100 handled by Handler B");
            }
            else if (NextHandler != null)
            {
                NextHandler.HandleRequest(request);
            }
        }
    }

    public class ChainOfResponsibilityTest
    {
        public static void Test()
        {
            var handlerA = new ConcreteHandlerA();
            var handlerB = new ConcreteHandlerB();

            handlerA.NextHandler = handlerB;

            handlerA.HandleRequest(-1); // handled by Handler A
            handlerA.HandleRequest(50); // not handled
            handlerA.HandleRequest(150); // handled by Handler B
        }
    }
}
