using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//模板方法模式
namespace DesignPattern.Example.Pattern
{
    public abstract class AbstractClass
    {
        public void TemplateMethod()
        {
            Operation1();
            Operation2();
            Operation3();
        }

        protected abstract void Operation1();
        protected abstract void Operation2();
        protected abstract void Operation3();
    }

    public class ConcreteClass : AbstractClass
    {
        protected override void Operation1()
        {
            Debug.Log("Operation 1");
        }

        protected override void Operation2()
        {
            Debug.Log("Operation 2");
        }

        protected override void Operation3()
        {
            Debug.Log("Operation 3");
        }
    }

    public class TemplateMethodTest
    {
        public static void Test()
        {
            AbstractClass obj = new ConcreteClass();
            obj.TemplateMethod();
        }
    }
}