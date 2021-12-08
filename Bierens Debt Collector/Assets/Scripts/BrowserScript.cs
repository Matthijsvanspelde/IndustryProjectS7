using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrowserScript : MonoBehaviour
{
    public GameObject Vindhet;
    public GameObject Recensie;
    public GameObject Hyves;
    public GameObject KantoorVanKoophandel;
    public GameObject AddressBar;

    private GameObject currentPage;
    private GameObject previousPage;
    private GameObject NextPage;

    void Start()
    {
        currentPage = Vindhet;
    }

    private void changeWebsite(GameObject website)
    {
        previousPage = currentPage;
        currentPage.SetActive(false);
        currentPage = website;
        currentPage.SetActive(true);
    }

    private void checkPage()
    {
        if(currentPage == Vindhet)
        {
            AddressBar.GetComponent<InputField>().text = "http://www.vindhet.nl/";
        }
        else if(currentPage == Hyves)
        {
            AddressBar.GetComponent<InputField>().text = "http://www.hyves.nl/";
        }
        else if(currentPage == Recensie)
        {
            AddressBar.GetComponent<InputField>().text = "http://www.recensie.nl/";
        }
        else if(currentPage == KantoorVanKoophandel)
        {
            AddressBar.GetComponent<InputField>().text = "http://www.kantoorvankoophandel.nl/";
        }
        else
        {
            AddressBar.GetComponent<InputField>().text = "http://www.websitenotfound.nl/";
        }
    }

    public void HyvesButtonClick()
    {
        changeWebsite(Hyves);
        checkPage();
    }

    public void RecensieButtonClick()
    {
        changeWebsite(Recensie);
        checkPage();
    }

    public void KantoorVanKoophandelButtonClick()
    {
        changeWebsite(KantoorVanKoophandel);
        checkPage();
    }

    public void BackButtonClick()
    {
        if(currentPage != previousPage && previousPage != null)
        {
            currentPage.SetActive(false);
            NextPage = currentPage;
            currentPage = previousPage;
            previousPage = null;
            currentPage.SetActive(true);
            checkPage();
        }
    }

    public void ForwardButtonClick()
    {
        if(currentPage != NextPage && NextPage != null)
        {
            currentPage.SetActive(false);
            previousPage = currentPage;
            currentPage = NextPage;
            NextPage = null;
            currentPage.SetActive(true);
            checkPage();
        }
    }
}
