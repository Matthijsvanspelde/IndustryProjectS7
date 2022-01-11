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
    public GameObject Bierens;
    public GameObject AddressBar;
    public GameObject websiteBackground;

    private GameObject currentPage;
    private GameObject previousPage;
    private GameObject NextPage;

    private Color32 hyvesColor;

    void Start()
    {
        hyvesColor = new Color32(70, 90, 178, 255);
        currentPage = Vindhet;
    }

    private void changeWebsite(GameObject website)
    {
        previousPage = currentPage;
        NextPage = null;
        currentPage.SetActive(false);
        currentPage = website;
        currentPage.SetActive(true);
    }

    private void checkPage()
    {
        if(currentPage == Vindhet)
        {
            AddressBar.GetComponent<InputField>().text = "http://www.vindhet.nl/";
            websiteBackground.GetComponent<Image>().color = Color.white;
        }
        else if(currentPage == Hyves)
        {
            AddressBar.GetComponent<InputField>().text = "http://www.hyves.nl/";
            websiteBackground.GetComponent<Image>().color = hyvesColor;
        }
        else if(currentPage == Recensie)
        {
            AddressBar.GetComponent<InputField>().text = "http://www.recensie.nl/";
            websiteBackground.GetComponent<Image>().color = Color.white;
        }
        else if(currentPage == KantoorVanKoophandel)
        {
            AddressBar.GetComponent<InputField>().text = "http://www.kantoorvankoophandel.nl/";
            websiteBackground.GetComponent<Image>().color = Color.white;
        }
        else if (currentPage == Bierens)
        {
            AddressBar.GetComponent<InputField>().text = "http://www.bierensgroup.com/";
            websiteBackground.GetComponent<Image>().color = Color.white;
        }
        else
        {
            AddressBar.GetComponent<InputField>().text = "http://www.websitenotfound.nl/";
            websiteBackground.GetComponent<Image>().color = Color.white;
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

    public void BierensButtonClick()
    {
        changeWebsite(Bierens);
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
