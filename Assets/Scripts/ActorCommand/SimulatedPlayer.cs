using BasicCommand;
using DG.Tweening;
using UnityEngine;
using Zenject;

namespace ActorCommand
{
    public class SimulatedPlayer : MonoBehaviour, IActor
    {
        [SerializeField] private float _jumpCooldown;
        
        private ICommandExecutor<ICommand> _commandExecutor;
        private float _currentTime;
        
        [Inject]
        private void Inject(ICommandExecutor<ICommand> commandExecutor)
        {
            _commandExecutor = commandExecutor;
        }
        
        public void Jump()
        {
            transform.DOJump(transform.position, 1, 1, 0.2f).SetEase(Ease.InOutSine);
        }

        private void Update()
        {
            if (_currentTime > _jumpCooldown)
            {
                _commandExecutor.PushCommand(new JumpCommand(this));
                _currentTime -= _jumpCooldown;
            }

            _currentTime += Time.deltaTime;
        }
    }
}