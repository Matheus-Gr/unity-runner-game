using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GeralSFX : MonoBehaviour
{
    public AudioSource[] btn;

    public void PlaySFX(int index) {
        btn[index].Play();
    }

    public IEnumerator PlayBtnSFXAndWaitForLoadScene(int sfxIndex, int sceneIndex)
    {
        FindObjectOfType<GeralSFX>().PlaySFX(sfxIndex);
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(sceneIndex);
    }
}
