using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrinterInteractable : Interactable
{
    private bool isActive = false;
    [SerializeField] private Animator animator;
    [SerializeField] private AudioSource audioSource;
    [Header("Partical Systems")]
    [SerializeField] ParticleSystem paperEmitter;
    [SerializeField] ParticleSystem paper;
    
    public override void HideToolTip()
    {
        
    }

    public override void ShowToolTip()
    {
        
    }

    public void StartPrinting() 
    {
        if (!isActive)
        {
            isActive = true;
            paperEmitter.Play();
            paper.Play();
        }        
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
                paperEmitter.Stop();
                paper.Stop();
            }
        }
    }
}
