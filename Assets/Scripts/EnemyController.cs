using UnityEngine;
using Zenject;

public class EnemyController : MonoBehaviour
{
    [Inject] private PlayerController _playerController;

    private void Start()
    {
        if (_playerController != null)
        {
            SetTarget(_playerController.transform.position);
        }
    }

    private void SetTarget(Vector3 position)
    {
        Debug.Log("Враг идет к игроку");
    }
}
