using BasicCommand;
using Shared;
using Zenject;

namespace ActorCommand
{
    public class ActorCommandInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind(typeof(ICommandExecutor<ICommand>), typeof(ITickable)).To(typeof(ActorCommandExecutor)).AsSingle();
            Container.Bind<IInputHandler>().To<UnityInputHandler>().AsSingle();
        }
    }
}