using UnityEngine;

public class Window : MonoBehaviour
{
    [SerializeField] private Animator animator;

    public void CloseWindow()
    {
        animator.SetTrigger("Close");
    }

    public void OpenWindow()
    {
        animator.SetTrigger("Open");
    }
}
