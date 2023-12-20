using DG.Tweening;
using Shared;
using UnityEngine;
using Zenject;

namespace BasicCommand
{
    public class Player : MonoBehaviour
    {
        private ICommandExecutor<ICommand> _commandExecutor;
        private IInputHandler _inputHandler;
        public static Player Instance;

        [Inject]
        private void Inject(IInputHandler inputHandler, ICommandExecutor<ICommand> commandExecutor)
        {
            _inputHandler = inputHandler;
            _commandExecutor = commandExecutor;
        }
        
        private void Awake()
        {
            Instance = this;
        }

        public void DoJump()
        {
            transform.DOJump(transform.position, 1, 1, 0.2f).SetEase(Ease.InOutSine);
        }

        public void DoMove()
        {
            transform.DORotate(transform.eulerAngles + Vector3.up * 90, 0.2f, RotateMode.FastBeyond360);
        }

        public void DoFire()
        {
            transform.DOShakeRotation(0.1f, 0.5f);
            transform.DOShakeScale(0.1f, 0.5f);
        }

        private void Update()
        {
            if (_inputHandler.IsButtonDown(ButtonType.Jump))
            {
                _commandExecutor.PushCommand(new JumpBasicCommand());
            }

            if (_inputHandler.IsButtonDown(ButtonType.Move))
            {
                _commandExecutor.PushCommand(new MoveBasicCommand());
            }

            if (_inputHandler.IsButtonDown(ButtonType.Fire))
            {
                _commandExecutor.PushCommand(new RotateBasicCommand());
            }
        }
    }
}