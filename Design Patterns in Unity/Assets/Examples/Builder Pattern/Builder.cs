using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//建造者模式
namespace DesignPattern.Example.Pattern
{
    public class Character
    {
        private string _name;
        private string _gender;
        private string _race;
        private string _class;
        private int _level;
        private int _health;
        private int _mana;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public string Race
        {
            get { return _race; }
            set { _race = value; }
        }

        public string Class
        {
            get { return _class; }
            set { _class = value; }
        }

        public int Level
        {
            get { return _level; }
            set { _level = value; }
        }

        public int Health
        {
            get { return _health; }
            set { _health = value; }
        }

        public int Mana
        {
            get { return _mana; }
            set { _mana = value; }
        }
    }

    public abstract class CharacterBuilder
    {
        protected Character _character;

        public Character Character
        {
            get { return _character; }
        }

        public virtual void BuildName(string name)
        {
            _character.Name = name;
        }

        public virtual void BuildGender(string gender)
        {
            _character.Gender = gender;
        }

        public virtual void BuildRace(string race)
        {
            _character.Race = race;
        }

        public virtual void BuildClass(string className)
        {
            _character.Class = className;
        }

        public virtual void BuildLevel(int level)
        {
            _character.Level = level;
        }

        public virtual void BuildHealth(int health)
        {
            _character.Health = health;
        }

        public virtual void BuildMana(int mana)
        {
            _character.Mana = mana;
        }
    }

    public class HumanBuilder : CharacterBuilder
    {
        public HumanBuilder()
        {
            _character = new Character();
        }

        public override void BuildRace(string race)
        {
            if (race.Equals("Human"))
            {
                _character.Race = race;
            }
            else
            {
                throw new System.Exception("Invalid race for Human builder.");
            }
        }

        public override void BuildClass(string className)
        {
            if (className.Equals("Warrior") || className.Equals("Mage"))
            {
                _character.Class = className;
            }
            else
            {
                throw new System.Exception("Invalid class for Human builder.");
            }
        }
    }

    public class CharacterDirector
    {
        private CharacterBuilder _builder;

        public CharacterDirector(CharacterBuilder builder)
        {
            _builder = builder;
        }

        public void Construct(string name, string gender, string race, string className, int level, int health, int mana)
        {
            _builder.BuildName(name);
            _builder.BuildGender(gender);
            _builder.BuildRace(race);
            _builder.BuildClass(className);
            _builder.BuildLevel(level);
            _builder.BuildHealth(health);
            _builder.BuildMana(mana);
        }
    }
}
