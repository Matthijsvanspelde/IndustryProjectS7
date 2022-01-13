using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonTextHoverEffect : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private TMP_Text text;
    [SerializeField] private Color hoverColor;
    [SerializeField] private float fontSizeIncrease = 2f;

    private Color color;
    private float fontSize;

    private void Start()
    {
        color = text.color;
        fontSize = text.fontSize;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        text.color = hoverColor;
        text.fontSize += fontSizeIncrease;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        text.color = color;
        text.fontSize = fontSize;
    }

}
