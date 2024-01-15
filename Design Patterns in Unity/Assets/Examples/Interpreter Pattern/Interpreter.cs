using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//½âÊÍÆ÷Ä£Ê½
namespace DesignPattern.Example.Pattern
{
    public abstract class AbstractExpression
    {
        public abstract double Interpret();
    }

    public class NumberExpression : AbstractExpression
    {
        private double _number;

        public NumberExpression(double number)
        {
            _number = number;
        }

        public override double Interpret()
        {
            return _number;
        }
    }

    public class AdditionExpression : AbstractExpression
    {
        private AbstractExpression _expression1;
        private AbstractExpression _expression2;

        public AdditionExpression(AbstractExpression expression1, AbstractExpression expression2)
        {
            _expression1 = expression1;
            _expression2 = expression2;
        }

        public override double Interpret()
        {
            return _expression1.Interpret() + _expression2.Interpret();
        }
    }

    public class SubtractionExpression : AbstractExpression
    {
        private AbstractExpression _expression1;
        private AbstractExpression _expression2;

        public SubtractionExpression(AbstractExpression expression1, AbstractExpression expression2)
        {
            _expression1 = expression1;
            _expression2 = expression2;
        }

        public override double Interpret()
        {
            return _expression1.Interpret() - _expression2.Interpret();
        }
    }

    public class MultiplicationExpression : AbstractExpression
    {
        private AbstractExpression _expression1;
        private AbstractExpression _expression2;

        public MultiplicationExpression(AbstractExpression expression1, AbstractExpression expression2)
        {
            _expression1 = expression1;
            _expression2 = expression2;
        }

        public override double Interpret()
        {
            return _expression1.Interpret() * _expression2.Interpret();
        }
    }

    public class DivisionExpression : AbstractExpression
    {
        private AbstractExpression _expression1;
        private AbstractExpression _expression2;

        public DivisionExpression(AbstractExpression expression1, AbstractExpression expression2)
        {
            _expression1 = expression1;
            _expression2 = expression2;
        }

        public override double Interpret()
        {
            return _expression1.Interpret() / _expression2.Interpret();
        }
    }

    public class Interpreter
    {
        public static void Test()
        {
            AbstractExpression expression = new AdditionExpression(
                new NumberExpression(5),
                new MultiplicationExpression(
                    new NumberExpression(10),
                    new SubtractionExpression(
                        new NumberExpression(8),
                        new NumberExpression(2)
                    )
                )
            );

            double result = expression.Interpret();
            Debug.Log("Interpreter result: " + result);
        }
    }
}
