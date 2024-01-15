using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//  ≈‰∆˜ƒ£ Ω
namespace DesignPattern.Example.Pattern
{
    public interface ITarget
    {
        void Request();
    }

    public class Adaptee
    {
        public void SpecificRequest()
        {
            Debug.Log("Specific Request");
        }
    }

    public class Adapter : ITarget
    {
        private Adaptee _adaptee = new Adaptee();

        public void Request()
        {
            _adaptee.SpecificRequest();
        }
    }
}