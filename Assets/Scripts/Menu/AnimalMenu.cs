using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimalMenu : MonoBehaviour
{
    public Animator animator;

    private bool showInfo = false;

    public void BackButton()
    {
        SceneManager.LoadScene(2);
    }

    public void ShowInfo()
    {
        showInfo = !showInfo;
        animator.SetTrigger(showInfo ? "Show" : "Hide");
    }
}
