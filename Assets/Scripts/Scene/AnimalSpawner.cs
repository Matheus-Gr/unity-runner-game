using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AnimalSpawner : MonoBehaviour
{

    public GameObject[] animals;
    public TMP_Text animalNameText;
    public TMP_Text animalDescriptionText;

    void Start()
    {
        int index = PlayerPrefs.GetInt("ViewAnimal", 0);
        GameObject go = animals[index];
        if (go != null) {
            switch (index)
            {   
                case 0:
                    //tiger
                    go.transform.localScale = new Vector3(4, 4, 4);
                    go.transform.position = new Vector3(0, -2, 0);
                    animalNameText.text = "Tigre-de-bengala";
                    animalDescriptionText.text = "O tigre-de-bengala � nativo do sul asi�tico, sendo uma esp�cie considerada criticamente amea�ada de extin��o, conforme classifica��o e estudos da IUCN. O n�mero de tigres-de-bengala diminuiu consideravelmente decorrente do com�rcio de peles, destrui��o de seu habitat e a ca�a ilegal.";
                    break;
                case 1:
                    //Gorilla
                    go.transform.localScale = new Vector3(4, 4, 4);
                    go.transform.position = new Vector3(0, -3, 0);
                    animalNameText.text = "Gorila da montanha";
                    animalDescriptionText.text = "O gorila da montanha � uma subesp�cie do gorila oriental, que vive em duas popula��es isoladas nas florestas de alta altitude nas regi�es vulc�nicas e montanhosas da Rep�blica Democr�tica do Congo, Ruanda e Uganda, e no Parque Nacional Impenetr�vel de Bwindi, em Uganda.\nA paisagem de Virunga tem um hist�rico de instabilidade pol�tica junto com altos n�veis de pobreza na regi�o. Isso representa uma amea�a substancial ao n�mero de gorilas da montanha, pois as pessoas se mudaram para �reas mais pr�ximas desses grandes s�mios em busca de comida, abrigo e espa�o � mais de 500.000 pessoas vivem perto do habitat dos gorilas da montanha atualmente. Apesar disso, os gorilas da montanha est�o tendo uma recupera��o promissora com esfor�os de conserva��o e interven��es de parceiros locais e internacionais e do WWF por meio do Programa Internacional de Conserva��o de Gorilas.\n Atualmente, os gorilas da montanha est�o listados como esp�cies amea�adas de extin��o, com pouco mais de 1.000 indiv�duos em estado selvagem. No entanto, permanecem v�rias amea�as que podem impedir o progresso da recupera��o dessa esp�cie.";
                    break;
                case 2:
                    //Black Rhino
                    go.transform.localScale = new Vector3(0.125f, 0.125f, 0.125f);
                    go.transform.position = new Vector3(0, -2, 0);
                    go.transform.Rotate(0, 57, 0);
                    animalNameText.text = "Riconceronte-negro";
                    animalDescriptionText.text = "Entre 1960 e 1995, as popula��es de rinocerontes-negros sofreram perdas dram�ticas devido � ca�a furtiva em larga escala. Cerca de 2% sobreviveram ao severo ataque do passado. � medida que a conserva��o dos rinocerontes se consolidou, seus n�meros mais que dobraram em toda a �frica desde a d�cada de 1990. Mas os rinocerontes negros ainda est�o listados como criticamente amea�ados pela IUCN, com cerca de 5.630 indiv�duos na natureza.\n Tr�s subesp�cies de rinoceronte negro agora sobrevivem, com o rinoceronte negro ocidental declarado extinto em 2011. Hoje, 95% dos rinocerontes negros s�o encontrados em apenas quatro pa�ses: Qu�nia, Nam�bia, �frica do Sul e Zimb�bue. A maior amea�a para a popula��o remanescente ainda � a ca�a ilegal de chifres � nos �ltimos 10 anos, quase 10.000 rinocerontes africanos foram mortos para abastecer o com�rcio ilegal de chifres de rinoceronte.";
                    break;
                case 3:
                    //Blue Whale
                    go.transform.localScale = new Vector3(0.009f, 0.009f, 0.009f);
                    go.transform.position = new Vector3(0, 0, 0);
                    go.transform.Rotate(0, -50, 0);
                    animalNameText.text = "Balei-azul";
                    animalDescriptionText.text = "As baleias-azuis eram, at� ao in�cio do s�culo XX abundantes em quase todos os oceanos. Ca�adas durante mais de um s�culo, foram levadas � beira da extin��o pelos baleeiros, at� se tornarem objeto de mecanismos de prote��o adotados pela comunidade internacional em 1996.";
                    break;
                case 4:
                    //Polar Bear
                    go.transform.localScale = new Vector3(0.025f, 0.025f, 0.025f);
                    go.transform.position = new Vector3(0, -2, 0);
                    go.transform.Rotate(0, -21, 0);
                    animalNameText.text = "Urso-polar";
                    animalDescriptionText.text = "Um estudo publicado na revista Nature Climate Change em 2021 descobriu que a maioria das popula��es de ursos polares do mundo pode entrar em colapso at� 2100, caso as emiss�es de gases de efeito estufa n�o sejam fortemente controladas.";
                    break;
                case 5:
                    //Otter
                    go.transform.localScale = new Vector3(13f, 13f, 13f);
                    go.transform.position = new Vector3(0, 0, 0);
                    go.transform.Rotate(0, -20, 0);
                    animalNameText.text = "Ariranha";
                    animalDescriptionText.text = "Atualmente, a ariranha n�o est� entre os animais em extin��o no Brasil, mas v�rios fatores amea�am a exist�ncia desses animais. Al�m do desmatamento, a polui��o de rios por agrot�xicos e res�duos, principalmente o merc�rio, amea�am as ariranhas.";
                    break;
                case 6:
                    //Giraffe
                    go.transform.localScale = new Vector3(2.2f, 2.2f, 2.2f);
                    go.transform.position = new Vector3(0, -2.5f, 0);
                    animalNameText.text = "Girafas-Masai";
                    animalDescriptionText.text = " As Firafas-Masai est�o listadas como amea�adas de extin��o pela Uni�o Internacional para a Conserva��o da Natureza (IUCN). Existem cerca de 35 mil das subesp�cies restantes na Tanz�nia e no Qu�nia, mas sua popula��o est� em decl�nio devido � ca�a ilegal e � destrui��o de seu habitat, diz a organiza��o.";
                    break; 
                case 7:
                    //Great Hammerhead 
                    go.transform.localScale = new Vector3(5f, 5f, 5f);
                    go.transform.position = new Vector3(0, 3f, 0);
                    go.transform.Rotate(0, -40, 0);
                    animalNameText.text = "Tubar�o-Martelo";
                    animalDescriptionText.text = "Os tubar�es-martelo s�o os mais amea�ados de extin��o. A popula��o em 2003 correspondia a apenas 10% do n�mero estimado de animais em 1986, ano em que os registros populacionais come�aram a ser efetuados.";
                    break;
                case 8:
                    //Elephant 
                    go.transform.localScale = new Vector3(2.2f, 2.2f, 2.2f);
                    go.transform.position = new Vector3(0, 13.5f, 0);
                    go.transform.Rotate(0, 52f, 0);
                    animalNameText.text = "Elefante-da-floresta";
                    animalDescriptionText.text = "Nas profundezas das florestas densas e �midas da �frica Ocidental e Central, voc� pode encontrar o indescrit�vel elefante da floresta, um dos dois membros da esp�cie de elefante africano. O n�mero real de elefantes selvagens africanos da floresta permanece incerto devido � sua natureza t�mida, mas sabemos que eles s�o esp�cies criticamente amea�adas e diminu�ram cerca de 86% em 31 anos.\n A principal raz�o por tr�s do decl�nio � devido � ca�a furtiva, que � frequente, generalizada e intensa, especialmente na �frica Central. Assim como a ca�a furtiva de elefantes, a perda de habitat e a mudan�a do uso da terra para agricultura e outros usos da terra resultaram em habitats fragmentados e no aumento do conflito homem-elefante, levando a perdas em ambos os lados.\n Hoje, os elefantes africanos da floresta ocupam cerca de 25% de sua distribui��o hist�rica, espalhados por 20 diferentes na��es africanas, principalmente no Gab�o e na Rep�blica do Congo.";
                    break;
                case 9:
                    //Tortoise 
                    go.transform.localScale = new Vector3(4f, 4f, 4f);
                    go.transform.position = new Vector3(0, -1.5f, 0);
                    go.transform.Rotate(0, -33, 0);
                    animalNameText.text = "Tartaruga-de-Gal�pagos";
                    animalDescriptionText.text = "Al�m se terem sido historicamente ca�adas em grande n�mero para alimento humano, especialmente por marinheiros, que as estocavam vivas nos por�es de seus navios, onde podiam resistir por mais de um ano sem comida ou �gua, as tartarugas enfrentaram outros desafios para sua sobreviv�ncia. Tamb�m foram ca�adas para obten��o de �leo, muito valorizado no Equador. A coloniza��o das ilhas pelo homem as expulsou de muitas �reas, tomadas pela urbaniza��o e pela agropecu�ria. Com isso a oferta de alimentos para elas diminuiu. Tamb�m passaram a sofrer com os ataques de esp�cies ex�ticas introduzidas pelo homem, antes citadas, que al�m de se tornarem predadoras destru�am seus locais de nidifica��o. Em anos recentes ainda s�o amea�adas pelo crescimento do turismo - elas s�o uma atra��o popular - e pela urbaniza��o das ilhas.";
                    break;

            }
            go.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
