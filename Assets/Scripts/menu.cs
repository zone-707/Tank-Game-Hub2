using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour
{
    public void onStartClick()
    {
        SceneManager.LoadScene("Scenes1");
    }
}
