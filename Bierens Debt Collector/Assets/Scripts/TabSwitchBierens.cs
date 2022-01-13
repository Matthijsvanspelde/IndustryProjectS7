using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabSwitchBierens : MonoBehaviour
{
    [SerializeField] private GameObject mainPage;
    [SerializeField] private GameObject incassoPage;
    [SerializeField] private GameObject aboutUsPage;

    public void ShowMainPage()
    {
        mainPage.SetActive(true);
        incassoPage.SetActive(false);
        aboutUsPage.SetActive(false);
    }

    public void ShowIncassoPage()
    {
        mainPage.SetActive(false);
        incassoPage.SetActive(true);
        aboutUsPage.SetActive(false);
    }

    public void ShowAboutUsPage()
    {
        mainPage.SetActive(false);
        incassoPage.SetActive(false);
        aboutUsPage.SetActive(true);
    }

}
