using UnityEngine;

public class ButtonSequenceTask : MonoBehaviour
{
    public bool isActive = false;
    [SerializeField] private int buttonCount;
    [SerializeField] private int buttonsToPress;

    public void StartTask() 
    { 
        
    }

    public void HandleButtonPress() 
    {
        if (isActive)
        {
            buttonCount++;
            if (buttonsToPress >= buttonCount)
            {
                EndTask();
            }
        }

    }

    private void EndTask() 
    {
        isActive = false;
    }
}