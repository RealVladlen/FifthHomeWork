using UnityEngine;
using UnityEngine.UI;

public class GlassesController : MonoBehaviour
{
    [SerializeField] GameObject _glasses;

    Toggle _toggle;

    private void Start()
    {
        _toggle = GetComponentInChildren<Toggle>();

        _toggle.onValueChanged.AddListener(ChangeGlasses);
    }

    private void ChangeGlasses(bool state)
    {
        _glasses.SetActive(state);
    }
}   
