using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
    public TMP_Text sessionCoinText;
    public TMP_Text totalCoinText;

    public Animator animator;

    public bool isDead = false;

    public void PlayButton() {
        StartCoroutine(FindObjectOfType<GeralSFX>().PlayBtnSFXAndWaitForLoadScene(0, 1));
        CollectableController.sessionCoinCount = 0;
    }

    public void BackButton()
    {
        StartCoroutine(FindObjectOfType<GeralSFX>().PlayBtnSFXAndWaitForLoadScene(1, 0));
        CollectableController.sessionCoinCount = 0;
    }

    public void Update()
    {
        totalCoinText.text = "" + CollectableController.coinCount;
        sessionCoinText.text = "" + CollectableController.sessionCoinCount;
        if (isDead)
            animator.SetTrigger("Dead");
        isDead = false;
    }
}
