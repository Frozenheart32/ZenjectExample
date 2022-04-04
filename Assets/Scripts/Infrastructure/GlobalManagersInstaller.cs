using UnityEngine;
using Zenject;

namespace MyZenject
{
    public class GlobalManagersInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Debug.Log("GlobalManagersInstaller: Binding");
            //Можно привязывать и не через интефейсы, просто указывая необходимый класс
            Container.Bind<GameManager>().AsSingle().NonLazy();
        }
    }
}