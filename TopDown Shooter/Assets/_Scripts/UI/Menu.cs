using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textRecord;
    private int _record;

    private void Start()
    {
        _record = PlayerPrefs.GetInt("Record", _record);
        _textRecord.text = "You record: " + _record.ToString();
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}
