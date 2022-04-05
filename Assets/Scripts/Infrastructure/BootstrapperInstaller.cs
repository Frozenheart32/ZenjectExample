using UnityEngine;
using Zenject;

namespace MyZenject
{
    public class BootstrapperInstaller : MonoInstaller
    {
        [SerializeField] private PowerUpManager _powerUpManagerPrefab;
        public override void InstallBindings()
        {
            Debug.Log("BootstrapperInstaller: Bindings");
            Container.Bind<IPowerUpManager>()
                .To<PowerUpManager>()
                .FromComponentInNewPrefab(_powerUpManagerPrefab)
                .AsSingle();
            //Если бы powerUpManager не будет монобехом, то не нужен будет префаб и .FromComponentInNewPrefab
        }
    }
}
