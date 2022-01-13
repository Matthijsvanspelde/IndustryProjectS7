using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KVKSearch : MonoBehaviour
{
    private string searchInput;
    public InputField searchBar;

    public GameObject articles;
    public GameObject papierEnCo;
    public GameObject kantoorSpul;

    private void Start()
    {
        searchInput = "";
    }

    public void SearchButtonClick()
    {
        searchInput = searchBar.GetComponent<InputField>().text;

        if (searchInput == "www.kantoorspul.nl" || searchInput == "www.kantoorspul.com" || searchInput == "kantoorspul.nl" || searchInput == "kantoorspul.com" || searchInput == "www.Kantoorspul.nl" || searchInput == "www.Kantoorspul.com" || searchInput == "Kantoorspul.nl" || searchInput == "Kantoorspul.com" || searchInput == "Kantoorspul" || searchInput == "kantoorspul")
        {
            articles.SetActive(false);
            papierEnCo.SetActive(false);
            kantoorSpul.SetActive(true);
        }
        else if (searchInput == "Papier&co" || searchInput == "Papier&Co" || searchInput == "papier&co" || searchInput == "www.papier&co.nl" || searchInput == "www.papier&co.com" || searchInput == "papier&co.nl" || searchInput == "papier&co.com" || searchInput == "www.Papier&Co.nl" || searchInput == "www.Papier&Co.com" || searchInput == "Papier&Co.nl" || searchInput == "Papier&Co.com" || searchInput == "www.Papier&co.nl" || searchInput == "www.Papier&co.com" || searchInput == "Papier&co.nl" || searchInput == "Papier&co.com")
        {
            articles.SetActive(false);
            kantoorSpul.SetActive(false);
            papierEnCo.SetActive(true);
        }
        else
        {
            searchBar.GetComponent<InputField>().text = "Bedrijf niet gevonden, probeer het opnieuw";
        }
    }
}
