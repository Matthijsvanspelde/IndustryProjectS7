using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BrowserController : MonoBehaviour
{
    [SerializeField] private GameObject homePage;
    //[SerializeField] private GameObject recensie;
    //[SerializeField] private GameObject hyves;
    //[SerializeField] private GameObject kantoorVanKoophandel;
    //[SerializeField] private GameObject bierens;
    [SerializeField] private TMP_Text addresBarText;

    private GameObject currentPage;
    private GameObject previousPage;
    private GameObject NextPage;

    void Start()
    {
        currentPage = homePage;
    }

    private void changeWebsite(GameObject website)
    {
        previousPage = currentPage;
        NextPage = null;
        currentPage.SetActive(false);
        currentPage = website;
        currentPage.SetActive(true);
    }

    //private void checkPage()
    //{
    //    if (currentPage == homePage)
    //    {
    //        addresBarText.text = "http://www.vindhet.nl/";
    //    }
    //    else if (currentPage == hyves)
    //    {
    //        addresBarText.text = "http://www.hyves.nl/";
    //    }
    //    else if (currentPage == recensie)
    //    {
    //        addresBarText.text = "http://www.recensie.nl/";
    //    }
    //    else if (currentPage == kantoorVanKoophandel)
    //    {
    //        addresBarText.text = "http://www.kantoorvankoophandel.nl/";
    //    }
    //    else if (currentPage == bierens)
    //    {
    //        addresBarText.text = "http://www.bierensgroup.com/";
    //    }
    //    else
    //    {
    //        addresBarText.text = "http://www.websitenotfound.nl/";
    //    }
    //}

    public void OpenWebsite(GameObject website) 
    {
        previousPage = currentPage;
        NextPage = null;
        currentPage.SetActive(false);
        currentPage = website;
        currentPage.SetActive(true);
        addresBarText.text = currentPage.GetComponent<Website>().Address;
    }


    //public void HyvesButtonClick()
    //{
    //    changeWebsite(hyves);
    //    checkPage();
    //}

    //public void RecensieButtonClick()
    //{
    //    changeWebsite(recensie);
    //    checkPage();
    //}

    //public void KantoorVanKoophandelButtonClick()
    //{
    //    changeWebsite(kantoorVanKoophandel);
    //    checkPage();
    //}

    //public void BierensButtonClick()
    //{
    //    changeWebsite(bierens);
    //    checkPage();
    //}

    public void GoBack()
    {
        if (currentPage != previousPage && previousPage != null)
        {
            currentPage.SetActive(false);
            NextPage = currentPage;
            currentPage = previousPage;
            previousPage = null;
            currentPage.SetActive(true);
        }
    }

    public void GoForward()
    {
        if (currentPage != NextPage && NextPage != null)
        {
            currentPage.SetActive(false);
            previousPage = currentPage;
            currentPage = NextPage;
            NextPage = null;
            currentPage.SetActive(true);
        }
    }

    public void GoHome()
    {
        currentPage.SetActive(false);
        previousPage = currentPage;
        currentPage = homePage;
        NextPage = null;
        currentPage.SetActive(true);
    }
}
