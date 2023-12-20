using System.ComponentModel;
using Shared;
using Zenject;

namespace BasicCommand
{
    public class BasicCommandSceneInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind(typeof(ICommandExecutor<ICommand>), typeof(ITickable)).To(typeof(BasicCommandExecutor)).AsSingle();
            Container.Bind<IInputHandler>().To<UnityInputHandler>().AsSingle();
        }
    }
}