using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//±¸ÍüÂ¼Ä£Ê½
namespace DesignPattern.Example.Pattern
{
    public class Memento
    {
        public int Level { get; private set; }
        public int Score { get; private set; }

        public Memento(int level, int score)
        {
            Level = level;
            Score = score;
        }
    }

    public class Originator
    {
        public int Level { get; set; }
        public int Score { get; set; }

        public Memento Save()
        {
            return new Memento(Level, Score);
        }

        public void Load(Memento memento)
        {
            Level = memento.Level;
            Score = memento.Score;
        }
    }

    public class Caretaker
    {
        private Dictionary<string, Memento> _mementos = new Dictionary<string, Memento>();

        public void SaveState(string savepoint, Memento memento)
        {
            _mementos.Add(savepoint, memento);
        }

        public Memento LoadState(string savepoint)
        {
            if (!_mementos.ContainsKey(savepoint))
            {
                return null;
            }

            Memento memento = _mementos[savepoint];
            _mementos.Remove(savepoint);
            return memento;
        }
    }
}
