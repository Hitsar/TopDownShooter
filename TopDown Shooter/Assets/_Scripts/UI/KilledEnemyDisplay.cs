using TMPro;
using UnityEngine;

public class KilledEnemyDisplay : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    private int _count;

    public void KilledEnemy()
    {
        _count++;
        _text.text = _count.ToString();

    }

    public void SetRecord()
    {
        if (PlayerPrefs.GetInt("Record") < _count)
        {
            PlayerPrefs.SetInt("Record", _count);
        }
    }
}
