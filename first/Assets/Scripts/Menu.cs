using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Level01");
    }

    public void EnterShop()
    {
        SceneManager.LoadScene("Shop");
    }

    public void BackInMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
