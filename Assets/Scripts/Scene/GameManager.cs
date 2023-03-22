using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TMP_Text startText;
    public TMP_Text countText;

    private bool gameStarted = false;

    private void Start()
    {
        countText.enabled = false;

    }

    public float bounceSpeed = 0.1f;
    public float maxBounce = 1;
    private float actualBounce = 0;

    private void Update()
    {
        if (actualBounce < maxBounce) {
            startText.transform.Translate(0, bounceSpeed, 0, Space.World);
            actualBounce += Mathf.Abs(bounceSpeed);
        }else{
            actualBounce = 0;
            bounceSpeed *= -1;
        }
    }

    public void StartGame() {
        gameStarted = true;
        CollectableController.sessionCoinCount = 0;
        FindObjectOfType<PlayerMotor>().animator.SetBool("Running", true);
        FindObjectOfType<CameraMotor>().IsMoving = true;
        startText.enabled = false;
        countText.enabled = true;

    }

    public void DeathScreen() {
        FindObjectOfType<CameraMotor>().offset.z += -4;
        FindObjectOfType<DeathMenu>().isDead = true;
    }
}
