using TMPro;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private float _timeToDamage;
    [SerializeField] private GameObject _lozeMenu;

    [SerializeField] private TextMeshProUGUI _textHealth;

    private KilledEnemyDisplay _enemyDisplay;
    private float _time;

    private void Start()
    {
        _enemyDisplay = FindObjectOfType<KilledEnemyDisplay>().GetComponent<KilledEnemyDisplay>();
    }

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
        _textHealth.text = _health.ToString();

        if (_health <= 0)
        {
            _lozeMenu.SetActive(true);
            _enemyDisplay.SetRecord();
            Destroy(gameObject);
        }
    }
}
