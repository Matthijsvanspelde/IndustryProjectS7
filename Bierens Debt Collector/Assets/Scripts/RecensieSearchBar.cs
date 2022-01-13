using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecensieSearchBar : MonoBehaviour
{
    private string searchInput;
    public InputField searchBar;

    public GameObject userScoreStar1;
    public GameObject userScoreStar2;
    public GameObject userScoreStar3;
    public GameObject userScoreStar4;
    public GameObject userScoreStar5;

    public GameObject companyNameText;
    public GameObject categoryText;
    public GameObject emailText;

    public GameObject review1Name;
    public GameObject review1Star1;
    public GameObject review1Star2;
    public GameObject review1Star3;
    public GameObject review1Star4;
    public GameObject review1Star5;
    public GameObject review1Comment;

    public GameObject review2Name;
    public GameObject review2Star1;
    public GameObject review2Star2;
    public GameObject review2Star3;
    public GameObject review2Star4;
    public GameObject review2Star5;
    public GameObject review2Comment;

    public GameObject review3Name;
    public GameObject review3Star1;
    public GameObject review3Star2;
    public GameObject review3Star3;
    public GameObject review3Star4;
    public GameObject review3Star5;
    public GameObject review3Comment;

    public GameObject review4Name;
    public GameObject review4Star1;
    public GameObject review4Star2;
    public GameObject review4Star3;
    public GameObject review4Star4;
    public GameObject review4Star5;
    public GameObject review4Comment;

    private void Start()
    {
        searchInput = "Recensie.nl";
    }

    public void SearchClick()
    {
        searchInput = searchBar.GetComponent<InputField>().text;

        if (searchInput == "www.recensie.nl" || searchInput == "www.recensie.com" || searchInput == "recensie.nl" || searchInput == "recencie.com" || searchInput == "www.Recensie.nl" || searchInput == "www.Recensie.com" || searchInput == "Recensie.nl" || searchInput == "Recencie.com")
        {
            userScoreStar1.GetComponent<StarChanger>().starFilled = true;
            userScoreStar2.GetComponent<StarChanger>().starFilled = true;
            userScoreStar3.GetComponent<StarChanger>().starFilled = true;
            userScoreStar4.GetComponent<StarChanger>().starFilled = true;
            userScoreStar5.GetComponent<StarChanger>().starFilled = true;

            companyNameText.GetComponent<Text>().text = "Recensie.nl";
            categoryText.GetComponent<Text>().text = "Bedrijfsreview website";
            emailText.GetComponent<Text>().text = "service-info@recensie.nl";

            review1Name.GetComponent<Text>().text = "Piet P.";
            review1Star1.GetComponent<StarChanger>().starFilled = true;
            review1Star2.GetComponent<StarChanger>().starFilled = true;
            review1Star3.GetComponent<StarChanger>().starFilled = true;
            review1Star4.GetComponent<StarChanger>().starFilled = true;
            review1Star5.GetComponent<StarChanger>().starFilled = true;
            review1Comment.GetComponent<Text>().text = "Goede review website. Ik kan ieder bedrijf nu beoordelen en bekijken!";

            review2Name.GetComponent<Text>().text = "Henk J.";
            review2Star1.GetComponent<StarChanger>().starFilled = true;
            review2Star2.GetComponent<StarChanger>().starFilled = true;
            review2Star3.GetComponent<StarChanger>().starFilled = true;
            review2Star4.GetComponent<StarChanger>().starFilled = true;
            review2Star5.GetComponent<StarChanger>().starFilled = true;
            review2Comment.GetComponent<Text>().text = "Perfect! Handig om de betrouwbaarheid van bedrijven op te zoeken.";

            review3Name.GetComponent<Text>().text = "Frank S.";
            review3Star1.GetComponent<StarChanger>().starFilled = true;
            review3Star2.GetComponent<StarChanger>().starFilled = true;
            review3Star3.GetComponent<StarChanger>().starFilled = true;
            review3Star4.GetComponent<StarChanger>().starFilled = true;
            review3Star5.GetComponent<StarChanger>().starFilled = true;
            review3Comment.GetComponent<Text>().text = "Handige website om bedrijven te beoordelen.";

            review4Name.GetComponent<Text>().text = "Sanne M.";
            review4Star1.GetComponent<StarChanger>().starFilled = true;
            review4Star2.GetComponent<StarChanger>().starFilled = true;
            review4Star3.GetComponent<StarChanger>().starFilled = true;
            review4Star4.GetComponent<StarChanger>().starFilled = true;
            review4Star5.GetComponent<StarChanger>().starFilled = true;
            review4Comment.GetComponent<Text>().text = "Goede website. Aanrader voor iedereen die bedrijven wil nachecken.";
        }
        else if(searchInput == "www.kantoorspul.nl" || searchInput == "www.kantoorspul.com" || searchInput == "kantoorspul.nl" || searchInput == "kantoorspul.com" || searchInput == "www.Kantoorspul.nl" || searchInput == "www.Kantoorspul.com" || searchInput == "Kantoorspul.nl" || searchInput == "Kantoorspul.com" || searchInput == "Kantoorspul" || searchInput == "kantoorspul")
        {
            userScoreStar1.GetComponent<StarChanger>().starFilled = true;
            userScoreStar2.GetComponent<StarChanger>().starFilled = true;
            userScoreStar3.GetComponent<StarChanger>().starFilled = true;
            userScoreStar4.GetComponent<StarChanger>().starFilled = false;
            userScoreStar5.GetComponent<StarChanger>().starFilled = false;

            companyNameText.GetComponent<Text>().text = "Kantoorspul.nl";
            categoryText.GetComponent<Text>().text = "Webshop - Kantoorspullenverkoop";
            emailText.GetComponent<Text>().text = "klantvragen@kantoorspul.nl";

            review1Name.GetComponent<Text>().text = "Jack H.";
            review1Star1.GetComponent<StarChanger>().starFilled = true;
            review1Star2.GetComponent<StarChanger>().starFilled = true;
            review1Star3.GetComponent<StarChanger>().starFilled = true;
            review1Star4.GetComponent<StarChanger>().starFilled = false;
            review1Star5.GetComponent<StarChanger>().starFilled = false;
            review1Comment.GetComponent<Text>().text = "Kan ermee door, ze hebben wat je nodig hebt.";

            review2Name.GetComponent<Text>().text = "Michael S.";
            review2Star1.GetComponent<StarChanger>().starFilled = true;
            review2Star2.GetComponent<StarChanger>().starFilled = true;
            review2Star3.GetComponent<StarChanger>().starFilled = true;
            review2Star4.GetComponent<StarChanger>().starFilled = true;
            review2Star5.GetComponent<StarChanger>().starFilled = false;
            review2Comment.GetComponent<Text>().text = "Goede producten, alleen de leveringstijd klopte niet. Maar zeker een aanrader.";

            review3Name.GetComponent<Text>().text = "Bart H.";
            review3Star1.GetComponent<StarChanger>().starFilled = true;
            review3Star2.GetComponent<StarChanger>().starFilled = true;
            review3Star3.GetComponent<StarChanger>().starFilled = true;
            review3Star4.GetComponent<StarChanger>().starFilled = false;
            review3Star5.GetComponent<StarChanger>().starFilled = false;
            review3Comment.GetComponent<Text>().text = "Producten zijn prima. Klantenservice kan verbeteringen gebruiken.";

            review4Name.GetComponent<Text>().text = "Luuk W.";
            review4Star1.GetComponent<StarChanger>().starFilled = true;
            review4Star2.GetComponent<StarChanger>().starFilled = true;
            review4Star3.GetComponent<StarChanger>().starFilled = false;
            review4Star4.GetComponent<StarChanger>().starFilled = false;
            review4Star5.GetComponent<StarChanger>().starFilled = false;
            review4Comment.GetComponent<Text>().text = "Rode pennen besteld en blauwe ontvangen. Uiteindelijk na veel klachtenmails met de klantenservice de goeie pennen gehad.";
        }
        else if(searchInput == "Papier&co" || searchInput == "Papier&Co" || searchInput == "papier&co" || searchInput == "www.papier&co.nl" || searchInput == "www.papier&co.com" || searchInput == "papier&co.nl" || searchInput == "papier&co.com" || searchInput == "www.Papier&Co.nl" || searchInput == "www.Papier&Co.com" || searchInput == "Papier&Co.nl" || searchInput == "Papier&Co.com" || searchInput == "www.Papier&co.nl" || searchInput == "www.Papier&co.com" || searchInput == "Papier&co.nl" || searchInput == "Papier&co.com")
        {
            userScoreStar1.GetComponent<StarChanger>().starFilled = true;
            userScoreStar2.GetComponent<StarChanger>().starFilled = true;
            userScoreStar3.GetComponent<StarChanger>().starFilled = false;
            userScoreStar4.GetComponent<StarChanger>().starFilled = false;
            userScoreStar5.GetComponent<StarChanger>().starFilled = false;

            companyNameText.GetComponent<Text>().text = "Papier&Co";
            categoryText.GetComponent<Text>().text = "Webshop - Papierverkoop";
            emailText.GetComponent<Text>().text = "management@papierco.nl";

            review1Name.GetComponent<Text>().text = "Kim S.";
            review1Star1.GetComponent<StarChanger>().starFilled = true;
            review1Star2.GetComponent<StarChanger>().starFilled = false;
            review1Star3.GetComponent<StarChanger>().starFilled = false;
            review1Star4.GetComponent<StarChanger>().starFilled = false;
            review1Star5.GetComponent<StarChanger>().starFilled = false;
            review1Comment.GetComponent<Text>().text = "Super slecht, bestel hier niet! Verkeerde papiersoort geleverd en Papier&Co weigert te vervangen!";

            review2Name.GetComponent<Text>().text = "Tim S.";
            review2Star1.GetComponent<StarChanger>().starFilled = true;
            review2Star2.GetComponent<StarChanger>().starFilled = true;
            review2Star3.GetComponent<StarChanger>().starFilled = false;
            review2Star4.GetComponent<StarChanger>().starFilled = false;
            review2Star5.GetComponent<StarChanger>().starFilled = false;
            review2Comment.GetComponent<Text>().text = "Na een veelste lange levertijd en mails naar de klantenservice mijn producten eindelijk gehad. Kwaliteit producten is prima maar daar is alles mee gezegd.";

            review3Name.GetComponent<Text>().text = "Robin K.";
            review3Star1.GetComponent<StarChanger>().starFilled = true;
            review3Star2.GetComponent<StarChanger>().starFilled = true;
            review3Star3.GetComponent<StarChanger>().starFilled = false;
            review3Star4.GetComponent<StarChanger>().starFilled = false;
            review3Star5.GetComponent<StarChanger>().starFilled = false;
            review3Comment.GetComponent<Text>().text = "Slechte service, na een levering met beschadigde producten veel mails moeten sturen voor er vervanging geregeld werd. Wel de verzendkosten terug gekregen.";

            review4Name.GetComponent<Text>().text = "Sam L.";
            review4Star1.GetComponent<StarChanger>().starFilled = true;
            review4Star2.GetComponent<StarChanger>().starFilled = true;
            review4Star3.GetComponent<StarChanger>().starFilled = true;
            review4Star4.GetComponent<StarChanger>().starFilled = false;
            review4Star5.GetComponent<StarChanger>().starFilled = false;
            review4Comment.GetComponent<Text>().text = "Goede producten en prima service. Wel lange levertijden ondanks de vermelding dat de producten de volgende dag in huis zouden zijn.";
        }
        else
        {
            searchBar.GetComponent<InputField>().text = "Bedrijf niet gevonden, probeer het opnieuw";
        }
    }
}
