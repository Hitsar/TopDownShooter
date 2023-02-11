using UnityEngine;

public class Spawner : ObjectPool
{
    [SerializeField] GameObject[] _prefabObjects;
    [SerializeField] Transform[] _spawner;
    [SerializeField] float _secondForSpawn;
    private float _time = 0;

    private void Start()
    {
        Initialized(_prefabObjects);
    }

    private void Update()
    {
        _time += Time.deltaTime;

        if (_time >= _secondForSpawn)
        {
            if (TryGetObject(out GameObject enemy))
            {
                _time = 0;

                int spawnPointNumber = Random.Range(0, _spawner.Length);

                SetEnemy(enemy, _spawner[spawnPointNumber].position);
            }
        }
    }

    private void SetEnemy(GameObject enemy, Vector3 spawnPoint)
    {
        enemy.SetActive(true);
        enemy.transform.position = spawnPoint;
    }
}