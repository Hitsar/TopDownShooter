using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private ParticleSystem _particle;

    private KilledEnemyDisplay _enemyDisplay;

    private void Start()
    {
        _enemyDisplay = FindObjectOfType<KilledEnemyDisplay>().GetComponent<KilledEnemyDisplay>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Bullet bullet))
        {
            _particle.Play();
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
            _enemyDisplay.KilledEnemy();
            _health = 5;
        }
    }
}
