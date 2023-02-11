using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Transform _playerPosition;

    private void Start()
    {
        _playerPosition = FindObjectOfType<PlayerMovement>().GetComponent<Transform>();
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, _playerPosition.position, _speed * Time.deltaTime);
    }
}
