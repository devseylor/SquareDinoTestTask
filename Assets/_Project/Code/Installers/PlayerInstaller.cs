using SquareDino.TestTask.Input;
using SquareDino.TestTask.Movement;
using UnityEngine;
using Zenject;

namespace SquareDino.TestTask.Installers
{
    public class PlayerInstaller : MonoInstaller
    {
        [SerializeField] private WaypointsMovement _playerMovement;

        public override void InstallBindings()
        {
            BindClickHandler();
            BindMovement();
        }

        private void BindClickHandler() =>
            Container
                .Bind<ClickHandler>()
                .FromNewComponentOnNewGameObject()
                .AsSingle();

        private void BindMovement() => Container.BindInstance(_playerMovement);
    }
}