using System.Collections;
using UnityEngine;
using Zenject;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private EnemyController _enemyPrefab;
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private float _delay;
    [SerializeField] private int _count;
    [SerializeField] private float _offset;
    
    [Inject] private DiContainer _diContainer;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        for (int i = 0; i < _count; i++)
        {
            var offsetPos = new Vector3(Random.Range(-_offset, _offset), 0f, Random.Range(-_offset, _offset));
            
            //Таким образом пробрасываются зависимости в новых объектах сцены, если в них есть Inject
            _diContainer.InstantiatePrefab(_enemyPrefab, _spawnPoint.position + offsetPos, Quaternion.identity, null);
            yield return new WaitForSeconds(_delay);
        }
    }
}
