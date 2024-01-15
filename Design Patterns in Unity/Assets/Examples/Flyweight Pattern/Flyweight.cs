using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//ÏíÔªÄ£Ê½
namespace DesignPattern.Example.Pattern
{
    public class Flyweight
    {
        private string _state;

        public Flyweight(string state)
        {
            _state = state;
        }

        public void Operation()
        {
            Debug.Log("Flyweight operation with state: " + _state);
        }
    }

    public class FlyweightFactory
    {
        private Dictionary<string, Flyweight> _flyweights = new Dictionary<string, Flyweight>();

        public Flyweight GetFlyweight(string key)
        {
            if (!_flyweights.ContainsKey(key))
            {
                _flyweights.Add(key, new Flyweight(key));
            }

            return _flyweights[key];
        }
    }
}
