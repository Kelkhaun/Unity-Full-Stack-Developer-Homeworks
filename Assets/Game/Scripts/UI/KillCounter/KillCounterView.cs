using TMPro;
using UnityEngine;

public class CounterView : MonoBehaviour
{
    [SerializeField] private TMP_Text _counterText;

    public void SetCounterText(string text)
    {
        _counterText.text = text;
    }
}
