using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//����ģʽ
namespace DesignPattern.Example.Pattern
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }

    public class MoveCommand : ICommand
    {
        private Transform _transform;
        private Vector3 _direction;

        public MoveCommand(Transform transform, Vector3 direction)
        {
            _transform = transform;
            _direction = direction;
        }

        public void Execute()
        {
            _transform.position += _direction; // �ƶ�����
        }

        public void Undo()
        {
            _transform.position -= _direction; // �����ƶ�
        }
    }

    public class AttackCommand : ICommand
    {
        private GameObject _target;

        public AttackCommand(GameObject target)
        {
            _target = target;
        }

        public void Execute()
        {
            _target.GetComponent<Enemy>().TakeDamage(); // ����Ŀ��
        }

        public void Undo()
        {
            _target.GetComponent<Enemy>().Heal(); // ��������
        }
    }

    public class CommandInvoker
    {
        private Stack<ICommand> _commands = new Stack<ICommand>();

        public void AddCommand(ICommand command)
        {
            _commands.Push(command);
            command.Execute();
        }

        public void UndoLastCommand()
        {
            if (_commands.Count > 0)
            {
                ICommand command = _commands.Pop();
                command.Undo();
            }
        }
    }
}
