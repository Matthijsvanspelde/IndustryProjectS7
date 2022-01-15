using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class MainMenuController : MonoBehaviour
{
    private bool hasStarted = false;
    [SerializeField] private Canvas playerCanvas;
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject scenarioPickerMenu;
    [SerializeField] private MouseLook mouseLook;
    [SerializeField] private Interaction interaction;
    [SerializeField] private Animator animator;
    [SerializeField] private GameController gameController;
    [SerializeField] private Animator animatorOS;

    [SerializeField] private Volume v;
    void Start()
    {
        DepthOfField tmp;
        if (v.profile.TryGet<DepthOfField>(out tmp))
        {
            tmp.active = true;
        }

        mainMenu.SetActive(true);
        scenarioPickerMenu.SetActive(false);
        mouseLook.canMove = false;
        interaction.enabled = false;
        playerCanvas.enabled = false;
    }

    public void GoToScenarioPicker() 
    {
        mainMenu.SetActive(false);
        scenarioPickerMenu.SetActive(true);
    }
    
    public void StartGame(int indexStartGame) 
    {
        if (!hasStarted)
        {
            scenarioPickerMenu.SetActive(false);
            DepthOfField tmp;
            if (v.profile.TryGet<DepthOfField>(out tmp))
            {
                tmp.active = false;
            }
            gameController.LoadScenario(indexStartGame);
            animator.SetTrigger("StartGame");
            animatorOS.SetTrigger("Open");
        }        
    }

    private void Update()
    {
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("Idle") && !hasStarted)
        {
            hasStarted = true;
            Cursor.lockState = CursorLockMode.Locked;
            mouseLook.canMove = true;
            interaction.enabled = true;
            playerCanvas.enabled = true;
        }
    }

}
