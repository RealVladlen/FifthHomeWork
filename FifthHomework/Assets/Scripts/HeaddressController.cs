using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class HeaddressController : MonoBehaviour
{
    [SerializeField] Transform _parent;

    TMP_Dropdown _dropdown;

    private void Awake()
    {
        _dropdown = GetComponent<TMP_Dropdown>();
        _dropdown.value = 0;

        List<TMP_Dropdown.OptionData> options = new List<TMP_Dropdown.OptionData>();

        for (int i = 0; i < _parent.childCount; i++)
        {
            TMP_Dropdown.OptionData option = new TMP_Dropdown.OptionData();
            option.text = _parent.GetChild(i).name;
            options.Add(option);
        }
        _dropdown.options = options;

        _dropdown.onValueChanged.AddListener(Show);
    }

    void Show(int index)
    {
        for (int i = 0; i < _parent.childCount; i++)
        {
            _parent.GetChild(i).gameObject.SetActive(index == i);
        }
    }
}
