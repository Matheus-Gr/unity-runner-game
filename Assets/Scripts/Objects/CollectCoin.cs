using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    public AudioSource coinFX;

    private void OnTriggerEnter(Collider other)
    {
        coinFX.Play();
        CollectableController.CoinUpdate(1);
        this.gameObject.SetActive(false);
        Destroy(this.gameObject);
    }

    
}
