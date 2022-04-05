using UnityEngine;
using Zenject;

public class HPBar : MonoBehaviour
{
    private PlayerController _playerController;
    
    //Для большего контроля и понимания можно использовать инжекцию методов.
    //Своего рода аналог конструктора для монобехов.
    //Требование: все входные данные должны быть зарегистрированы в каком-нить MonoInstaller
    [Inject]
    private void Construct(PlayerController playerController)
    {
        _playerController = playerController;
    }

    private void Start()
    {
        if (_playerController != null)
        {
            Debug.Log("HPBar: игрок получен");
        }
        else
        {
            Debug.Log("HPBar: игрок потерян");
        }
    }
}
