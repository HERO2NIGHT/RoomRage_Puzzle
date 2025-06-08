using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   public void StartButton()
    {
        SceneManager.LoadScene("Bedroom");
    }

    public void ContinueButton()
    {
        string lastScene = PlayerPrefs.GetString("LastScene", "menu"); 
        SceneManager.LoadScene(lastScene);
    }

    public void levelSelectButton()
    {
        SceneManager.LoadScene("levelselection");
    }

    public void HowToPlayButton()
    {
        SceneManager.LoadScene("Tutorial");
    }
    public void SettingsButton()
    {
        SceneManager.LoadScene("Settings");
    }


}
