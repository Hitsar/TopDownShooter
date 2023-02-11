using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private float _timeToDamage;

    private float _time;

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out EnemyHealth enemy))
        {
            _time += Time.deltaTime;
            if (_time >= _timeToDamage)
            {
                TakeDamage();
                _time = 0;
            }
        }
    }

    private void TakeDamage()
    {
        _health--;

        if (_health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
