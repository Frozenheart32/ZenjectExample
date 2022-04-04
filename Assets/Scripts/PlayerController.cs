using UnityEngine;
using Zenject;

namespace DefaultNamespace
{
    public class PlayerController : MonoBehaviour
    {
        [Inject] private IPlayerInput _playerInput;
        [Inject] private GameManager _gameManager;

        private void Start()
        {
            _playerInput.GetInput();
            _gameManager.Hello();
        }
    }
}