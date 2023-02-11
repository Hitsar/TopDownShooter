using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private int _health;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Bullet bullet))
        {
            TakeDamage();
            Destroy(bullet.gameObject);
        }
    }

    private void TakeDamage()
    {
        _health--;

        if (_health <= 0)
        {
            gameObject.SetActive(false);
            _health = 5;
        }
    }
}
