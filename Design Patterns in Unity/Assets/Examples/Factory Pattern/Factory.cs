using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//工厂模式
namespace DesignPattern.Example.FactoryPattern
{
    public interface IProduct
    {
        void Use();
    }

    public class ConcreteProduct : IProduct
    {
        public void Use()
        {
            Debug.Log("ConcreteProduct");
        }
    }

    public abstract class Factory
    {
        public abstract IProduct Create();
    }

    public class ConcreteFactory : Factory
    {
        public override IProduct Create()
        {
            return new ConcreteProduct();
        }
    }
}