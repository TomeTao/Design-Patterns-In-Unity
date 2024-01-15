using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//访问者模式
namespace DesignPattern.Example.Pattern
{
    public interface IVisitor
    {
        void Visit(ConcreteElementA element);
        void Visit(ConcreteElementB element);
    }

    public abstract class Element
    {
        public abstract void Accept(IVisitor visitor);
    }

    public class ConcreteElementA : Element
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public string OperationA()
        {
            return "Concrete Element A Operation";
        }
    }

    public class ConcreteElementB : Element
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public string OperationB()
        {
            return "Concrete Element B Operation";
        }
    }

    public class ConcreteVisitor : IVisitor
    {
        public void Visit(ConcreteElementA element)
        {
            Debug.Log(element.OperationA());
        }

        public void Visit(ConcreteElementB element)
        {
            Debug.Log(element.OperationB());
        }
    }

    public class ObjectStructure
    {
        private List<Element> _elements = new List<Element>();

        public void AddElement(Element element)
        {
            _elements.Add(element);
        }

        public void RemoveElement(Element element)
        {
            _elements.Remove(element);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (Element element in _elements)
            {
                element.Accept(visitor);
            }
        }
    }
}
