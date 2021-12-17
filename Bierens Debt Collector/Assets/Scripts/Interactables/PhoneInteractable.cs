using UnityEngine;

public class PhoneInteractable : Interactable
{
    private bool isActive = false;
    [SerializeField] private Animator animator;
    [SerializeField] private AudioSource audioSource;

    private void Start()
    {
        //StartRinging();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            StartRinging();
        }
    }

    public override void ShowToolTip()
    {
        
    }

    private void StartRinging() 
    {
        isActive = true;
        audioSource.Play();
    }

    public override void HideToolTip()
    {
        
    }

    public override void Interact()
    {
        if (Input.GetKey(KeyCode.E))
        {
            if (isActive)
            {
                animator.SetTrigger("PressButton");
                audioSource.Stop();
                isActive = false;
            }
        }              
    }
}
