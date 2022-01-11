using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HyvesSearch : MonoBehaviour
{
    private string searchInput;
    public InputField searchBar;

    public GameObject homePage;
    public GameObject profileLayout;
    public GameObject papierEnCo;
    public GameObject kantoorSpul;

    private void Start()
    {
        searchInput = "";
    }

    public void HomeButtonClick()
    {
        profileLayout.SetActive(false);
        kantoorSpul.SetActive(false);
        papierEnCo.SetActive(false);
        searchBar.GetComponent<InputField>().text = "Zoeken";
        homePage.SetActive(true);
    }

    public void SearchButtonClick()
    {
        searchInput = searchBar.GetComponent<InputField>().text;

        if (searchInput == "www.kantoorspul.nl" || searchInput == "www.kantoorspul.com" || searchInput == "kantoorspul.nl" || searchInput == "kantoorspul.com" || searchInput == "www.Kantoorspul.nl" || searchInput == "www.Kantoorspul.com" || searchInput == "Kantoorspul.nl" || searchInput == "Kantoorspul.com" || searchInput == "Kantoorspul" || searchInput == "kantoorspul")
        {
            homePage.SetActive(false);
            papierEnCo.SetActive(false);
            profileLayout.SetActive(true);
            kantoorSpul.SetActive(true);
        }
        else if (searchInput == "Papier&co" || searchInput == "Papier&Co" || searchInput == "papier&co" || searchInput == "www.papier&co.nl" || searchInput == "www.papier&co.com" || searchInput == "papier&co.nl" || searchInput == "papier&co.com" || searchInput == "www.Papier&Co.nl" || searchInput == "www.Papier&Co.com" || searchInput == "Papier&Co.nl" || searchInput == "Papier&Co.com" || searchInput == "www.Papier&co.nl" || searchInput == "www.Papier&co.com" || searchInput == "Papier&co.nl" || searchInput == "Papier&co.com")
        {
            homePage.SetActive(false);
            kantoorSpul.SetActive(false);
            profileLayout.SetActive(true);
            papierEnCo.SetActive(true);
        }
        else
        {
            searchBar.GetComponent<InputField>().text = "Profiel niet gevonden, probeer het opnieuw";
        }
    }
}
