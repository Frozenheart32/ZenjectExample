using UnityEngine;
using Zenject;

public class PlayerInstaller : MonoInstaller
{
    [SerializeField] private PlayerController _playerPrefab;
    public override void InstallBindings()
    {
        //Cпособ регистрации интерфейса и приявзки конкретной реализации.
        //таким способом можно подменять на тестовую реализацию.
        Container.Bind<IPlayerInput>().To<PlayerInput>().AsCached();
        
        //Теперь создаем игрока и оставляем на него ссылку
        var playerInstance =
            Container.
                InstantiatePrefabForComponent<PlayerController>(_playerPrefab, Vector3.zero, Quaternion.identity, null);

        Container.
            Bind<PlayerController>().
            FromInstance(playerInstance)
            .AsSingle()
            .NonLazy();
    }
}
