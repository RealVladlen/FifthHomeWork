using UnityEngine;
using TMPro;

public class NameController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _playerNameText;

    TMP_InputField _inputField;

    private void Start()
    {
        _inputField = GetComponentInChildren<TMP_InputField>();

        _playerNameText.text = "Player";

        _inputField.onValueChanged.AddListener(NewName);
    }

    private void NewName(string name)
    {
        _playerNameText.text = name;
    }
}
