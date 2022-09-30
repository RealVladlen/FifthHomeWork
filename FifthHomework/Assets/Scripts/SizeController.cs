using UnityEngine;
using Slider = UnityEngine.UI.Slider;

public class SizeController : MonoBehaviour
{
    [SerializeField] Transform _head;

    private Slider _slider;
 

    private void Start()
    {
        _slider = GetComponent<Slider>();
        _slider.onValueChanged.AddListener(ChangeSizeHead);
    }

    private void ChangeSizeHead(float size)
    {
        size += 1;
        _head.transform.localScale = new Vector3(size, size, size);
    }
}
