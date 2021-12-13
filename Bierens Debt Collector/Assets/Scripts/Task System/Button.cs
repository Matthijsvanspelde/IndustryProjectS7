using UnityEngine;

public class Button : MonoBehaviour
{
    public bool isPressed = false;
    [SerializeField] private ButtonSequenceTask task;

    public void Press()
    {
        if (!isPressed)
        {
            isPressed = true;
            task.HandleButtonPress();
        }       
    }
}