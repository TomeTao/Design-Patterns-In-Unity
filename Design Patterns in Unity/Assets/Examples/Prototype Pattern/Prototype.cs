using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//原型模式
namespace DesignPattern.Example.Pattern
{
    public abstract class Prototype
    {
        public string Type;

        public abstract Prototype Clone();
    }

    public class ConcretePrototypeA : Prototype
    {
        public ConcretePrototypeA()
        {
            Type = "A";
        }

        public override Prototype Clone()
        {
            return (Prototype)MemberwiseClone();
        }
    }

    public class ConcretePrototypeB : Prototype
    {
        public ConcretePrototypeB()
        {
            Type = "B";
        }

        public override Prototype Clone()
        {
            return (Prototype)MemberwiseClone();
        }
    }

    public class PrototypeManager
    {
        private Dictionary<string, Prototype> _prototypes = new Dictionary<string, Prototype>();

        public Prototype this[string key]
        {
            get { return _prototypes[key].Clone(); }
            set { _prototypes.Add(key, value); }
        }
    }
}
