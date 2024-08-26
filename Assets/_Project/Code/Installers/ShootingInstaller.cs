using SquareDino.TestTask.ObjectPool;
using SquareDino.TestTask.Shooting;
using UnityEngine;
using Zenject;

namespace SquareDino.TestTask.Installers
{
    public class ShootingInstaller : MonoInstaller
    {
        [SerializeField] private Projectile _projectile;

        public override void InstallBindings()
        {
            BindObjectPool();
            BindProjectile();
        }

        private void BindObjectPool() =>
            Container
                .Bind<IObjectPool<Projectile>>()
                .To<ProjectilePool>()
                .FromNewComponentOnNewGameObject()
                .AsSingle();

        private void BindProjectile() =>
            Container.BindInstance(_projectile);
    }
}