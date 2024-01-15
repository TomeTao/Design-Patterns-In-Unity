using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//抽象工厂模式
namespace DesignPattern.Example.Pattern
{
    public interface IButton
    {
        void Paint();
    }

    public interface ICheckbox
    {
        void Paint();
    }

    public abstract class GUIFactory
    {
        public abstract IButton CreateButton();
        public abstract ICheckbox CreateCheckbox();
    }

    public class WinFactory : GUIFactory
    {
        public override IButton CreateButton()
        {
            return new WinButton();
        }

        public override ICheckbox CreateCheckbox()
        {
            return new WinCheckbox();
        }
    }

    public class MacFactory : GUIFactory
    {
        public override IButton CreateButton()
        {
            return new MacButton();
        }

        public override ICheckbox CreateCheckbox()
        {
            return new MacCheckbox();
        }
    }

    public class WinButton : IButton
    {
        public void Paint()
        {
            Debug.Log("Windows Button");
        }
    }

    public class WinCheckbox : ICheckbox
    {
        public void Paint()
        {
            Debug.Log("Windows Checkbox");
        }
    }

    public class MacButton : IButton
    {
        public void Paint()
        {
            Debug.Log("Mac Button");
        }
    }

    public class MacCheckbox : ICheckbox
    {
        public void Paint()
        {
            Debug.Log("Mac Checkbox");
        }
    }
}