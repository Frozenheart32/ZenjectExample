using UnityEngine;
using Zenject;

namespace MyZenject
{
    public class BootstrapperInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Debug.Log("BootstrapperInstaller: Bindings");
        }
    }
}
