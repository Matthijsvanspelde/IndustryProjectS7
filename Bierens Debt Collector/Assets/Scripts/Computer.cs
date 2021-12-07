using UnityEngine;

public class Computer : MonoBehaviour
{   
    [SerializeField] private GameObject canvas;
    public Transform zoomPoint;

    private void Awake()
    {
        HideToolTip();
    }

    public void ShowToolTip() 
    {
        canvas.SetActive(true);
    }

    public void HideToolTip()
    {
        canvas.SetActive(false);
    }
}
