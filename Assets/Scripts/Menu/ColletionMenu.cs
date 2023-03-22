using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ColletionMenu : MonoBehaviour
{
    public Button[] buttons;
    public Sprite[] sprites;

    private readonly int princeIncrease = 200;

    private int unlockIndex = 0;

    private void Start()
    {
        string animal;
        Button button;
        for (int i = 0; i < buttons.Length; i++)
        {
            button= buttons[i];
            animal = "Animal_" + i;
            /*PlayerPrefs.SetInt(animal, 1);
            PlayerPrefs.Save();*/
            if (PlayerPrefs.GetInt(animal, 0) == 1) {
                button.GetComponent<Image>().sprite = sprites[i];
            }
        }
    }

    public void BackButton() {
        StartCoroutine(FindObjectOfType<GeralSFX>().PlayBtnSFXAndWaitForLoadScene(0, 0));
    }

    public void UnlockAnimal() {
        string animal;

        if (CollectableController.coinCount >= PriceLabel.ActualCost) {
            do
            {
                unlockIndex = Random.Range(0, 10);
                animal = "Animal_" + unlockIndex;
                print(animal + " Lock:" + PlayerPrefs.GetInt(animal, 0));
            } while (PlayerPrefs.GetInt(animal, 0) == 1);

            Button button = buttons[unlockIndex];

            button.GetComponent<Image>().sprite = sprites[unlockIndex];
            CollectableController.CoinUpdate(-PriceLabel.ActualCost);
            PriceLabel.ActualCost += princeIncrease;

            PlayerPrefs.SetInt("ActualPrice", PriceLabel.ActualCost);
            PlayerPrefs.SetInt(animal, 1);
            PlayerPrefs.Save();
            FindObjectOfType<GeralSFX>().PlaySFX(2);
        }
        
    }

    public void AnimalViwer(int index)
    {   
        string animal = "Animal_" + index;
        if (PlayerPrefs.GetInt(animal, 0) == 0)
            return;

        PlayerPrefs.SetInt("ViewAnimal", index);
        PlayerPrefs.Save();

        SceneManager.LoadScene(3);
    }
}
