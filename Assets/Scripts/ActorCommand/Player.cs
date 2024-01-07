using BasicCommand;
using DG.Tweening;
using Shared;
using UnityEngine;
using Zenject;

namespace ActorCommand
{
    public class Player : MonoBehaviour, IActor
    {
        private ICommandExecutor<ICommand> _commandExecutor;
        private IInputHandler _inputHandler;
        private Sequence _currentAction;
        
        [Inject]
        private void Inject(IInputHandler inputHandler, ICommandExecutor<ICommand> commandExecutor)
        {
            _inputHandler = inputHandler;
            _commandExecutor = commandExecutor;
        }
        
        public void Jump()
        {
            if (_currentAction != null && _currentAction.IsPlaying())
            {
                return;
            }
            
            _currentAction = transform.DOJump(transform.position, 1, 1, 0.2f).SetEase(Ease.InOutSine);
        }
        
        private void Update()
        {
            if (_inputHandler.IsButtonDown(ButtonType.Jump))
            {
                _commandExecutor.PushCommand(new JumpCommand(this));
            }
        }
    }
}