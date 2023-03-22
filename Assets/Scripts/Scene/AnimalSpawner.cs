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
                    animalDescriptionText.text = "O tigre-de-bengala é nativo do sul asiático, sendo uma espécie considerada criticamente ameaçada de extinção, conforme classificação e estudos da IUCN. O número de tigres-de-bengala diminuiu consideravelmente decorrente do comércio de peles, destruição de seu habitat e a caça ilegal.";
                    break;
                case 1:
                    //Gorilla
                    go.transform.localScale = new Vector3(4, 4, 4);
                    go.transform.position = new Vector3(0, -3, 0);
                    animalNameText.text = "Gorila da montanha";
                    animalDescriptionText.text = "O gorila da montanha é uma subespécie do gorila oriental, que vive em duas populações isoladas nas florestas de alta altitude nas regiões vulcânicas e montanhosas da República Democrática do Congo, Ruanda e Uganda, e no Parque Nacional Impenetrável de Bwindi, em Uganda.\nA paisagem de Virunga tem um histórico de instabilidade política junto com altos níveis de pobreza na região. Isso representa uma ameaça substancial ao número de gorilas da montanha, pois as pessoas se mudaram para áreas mais próximas desses grandes símios em busca de comida, abrigo e espaço – mais de 500.000 pessoas vivem perto do habitat dos gorilas da montanha atualmente. Apesar disso, os gorilas da montanha estão tendo uma recuperação promissora com esforços de conservação e intervenções de parceiros locais e internacionais e do WWF por meio do Programa Internacional de Conservação de Gorilas.\n Atualmente, os gorilas da montanha estão listados como espécies ameaçadas de extinção, com pouco mais de 1.000 indivíduos em estado selvagem. No entanto, permanecem várias ameaças que podem impedir o progresso da recuperação dessa espécie.";
                    break;
                case 2:
                    //Black Rhino
                    go.transform.localScale = new Vector3(0.125f, 0.125f, 0.125f);
                    go.transform.position = new Vector3(0, -2, 0);
                    go.transform.Rotate(0, 57, 0);
                    animalNameText.text = "Riconceronte-negro";
                    animalDescriptionText.text = "Entre 1960 e 1995, as populações de rinocerontes-negros sofreram perdas dramáticas devido à caça furtiva em larga escala. Cerca de 2% sobreviveram ao severo ataque do passado. À medida que a conservação dos rinocerontes se consolidou, seus números mais que dobraram em toda a África desde a década de 1990. Mas os rinocerontes negros ainda estão listados como criticamente ameaçados pela IUCN, com cerca de 5.630 indivíduos na natureza.\n Três subespécies de rinoceronte negro agora sobrevivem, com o rinoceronte negro ocidental declarado extinto em 2011. Hoje, 95% dos rinocerontes negros são encontrados em apenas quatro países: Quênia, Namíbia, África do Sul e Zimbábue. A maior ameaça para a população remanescente ainda é a caça ilegal de chifres – nos últimos 10 anos, quase 10.000 rinocerontes africanos foram mortos para abastecer o comércio ilegal de chifres de rinoceronte.";
                    break;
                case 3:
                    //Blue Whale
                    go.transform.localScale = new Vector3(0.009f, 0.009f, 0.009f);
                    go.transform.position = new Vector3(0, 0, 0);
                    go.transform.Rotate(0, -50, 0);
                    animalNameText.text = "Balei-azul";
                    animalDescriptionText.text = "As baleias-azuis eram, até ao início do século XX abundantes em quase todos os oceanos. Caçadas durante mais de um século, foram levadas à beira da extinção pelos baleeiros, até se tornarem objeto de mecanismos de proteção adotados pela comunidade internacional em 1996.";
                    break;
                case 4:
                    //Polar Bear
                    go.transform.localScale = new Vector3(0.025f, 0.025f, 0.025f);
                    go.transform.position = new Vector3(0, -2, 0);
                    go.transform.Rotate(0, -21, 0);
                    animalNameText.text = "Urso-polar";
                    animalDescriptionText.text = "Um estudo publicado na revista Nature Climate Change em 2021 descobriu que a maioria das populações de ursos polares do mundo pode entrar em colapso até 2100, caso as emissões de gases de efeito estufa não sejam fortemente controladas.";
                    break;
                case 5:
                    //Otter
                    go.transform.localScale = new Vector3(13f, 13f, 13f);
                    go.transform.position = new Vector3(0, 0, 0);
                    go.transform.Rotate(0, -20, 0);
                    animalNameText.text = "Ariranha";
                    animalDescriptionText.text = "Atualmente, a ariranha não está entre os animais em extinção no Brasil, mas vários fatores ameaçam a existência desses animais. Além do desmatamento, a poluição de rios por agrotóxicos e resíduos, principalmente o mercúrio, ameaçam as ariranhas.";
                    break;
                case 6:
                    //Giraffe
                    go.transform.localScale = new Vector3(2.2f, 2.2f, 2.2f);
                    go.transform.position = new Vector3(0, -2.5f, 0);
                    animalNameText.text = "Girafas-Masai";
                    animalDescriptionText.text = " As Firafas-Masai estão listadas como ameaçadas de extinção pela União Internacional para a Conservação da Natureza (IUCN). Existem cerca de 35 mil das subespécies restantes na Tanzânia e no Quênia, mas sua população está em declínio devido à caça ilegal e à destruição de seu habitat, diz a organização.";
                    break; 
                case 7:
                    //Great Hammerhead 
                    go.transform.localScale = new Vector3(5f, 5f, 5f);
                    go.transform.position = new Vector3(0, 3f, 0);
                    go.transform.Rotate(0, -40, 0);
                    animalNameText.text = "Tubarão-Martelo";
                    animalDescriptionText.text = "Os tubarões-martelo são os mais ameaçados de extinção. A população em 2003 correspondia a apenas 10% do número estimado de animais em 1986, ano em que os registros populacionais começaram a ser efetuados.";
                    break;
                case 8:
                    //Elephant 
                    go.transform.localScale = new Vector3(2.2f, 2.2f, 2.2f);
                    go.transform.position = new Vector3(0, 13.5f, 0);
                    go.transform.Rotate(0, 52f, 0);
                    animalNameText.text = "Elefante-da-floresta";
                    animalDescriptionText.text = "Nas profundezas das florestas densas e úmidas da África Ocidental e Central, você pode encontrar o indescritível elefante da floresta, um dos dois membros da espécie de elefante africano. O número real de elefantes selvagens africanos da floresta permanece incerto devido à sua natureza tímida, mas sabemos que eles são espécies criticamente ameaçadas e diminuíram cerca de 86% em 31 anos.\n A principal razão por trás do declínio é devido à caça furtiva, que é frequente, generalizada e intensa, especialmente na África Central. Assim como a caça furtiva de elefantes, a perda de habitat e a mudança do uso da terra para agricultura e outros usos da terra resultaram em habitats fragmentados e no aumento do conflito homem-elefante, levando a perdas em ambos os lados.\n Hoje, os elefantes africanos da floresta ocupam cerca de 25% de sua distribuição histórica, espalhados por 20 diferentes nações africanas, principalmente no Gabão e na República do Congo.";
                    break;
                case 9:
                    //Tortoise 
                    go.transform.localScale = new Vector3(4f, 4f, 4f);
                    go.transform.position = new Vector3(0, -1.5f, 0);
                    go.transform.Rotate(0, -33, 0);
                    animalNameText.text = "Tartaruga-de-Galápagos";
                    animalDescriptionText.text = "Além se terem sido historicamente caçadas em grande número para alimento humano, especialmente por marinheiros, que as estocavam vivas nos porões de seus navios, onde podiam resistir por mais de um ano sem comida ou água, as tartarugas enfrentaram outros desafios para sua sobrevivência. Também foram caçadas para obtenção de óleo, muito valorizado no Equador. A colonização das ilhas pelo homem as expulsou de muitas áreas, tomadas pela urbanização e pela agropecuária. Com isso a oferta de alimentos para elas diminuiu. Também passaram a sofrer com os ataques de espécies exóticas introduzidas pelo homem, antes citadas, que além de se tornarem predadoras destruíam seus locais de nidificação. Em anos recentes ainda são ameaçadas pelo crescimento do turismo - elas são uma atração popular - e pela urbanização das ilhas.";
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
