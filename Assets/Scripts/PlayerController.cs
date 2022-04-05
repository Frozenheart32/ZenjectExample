using UnityEngine;
using Zenject;

public class PlayerController : MonoBehaviour
{
    private IPlayerInput _playerInput;
    private GameManager _gameManager;
    private IPowerUpManager _powerUpManager;

    [Inject]
    private void Construct(IPlayerInput playerInput, GameManager gameManager, IPowerUpManager powerUpManager)
    {
        _playerInput = playerInput;
        _gameManager = gameManager;
        _powerUpManager = powerUpManager;
    }

    private void Start()
    {
        _playerInput.GetInput();
        _gameManager.Hello();
        if (_powerUpManager != null)
        {
            Debug.Log("Player: У меня есть PowerUpManager");
        }
    }
}