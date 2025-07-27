using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
  public void PlayButton()
  {
	  SceneManager.LoadSceneAsync(1);
  }
	
  public void LevelButton()
  {
	  SceneManager.LoadSceneAsync(7);
  }

   public void How2PlayButton()
  {
	  SceneManager.LoadSceneAsync(0);
  }

   public void QuitButton()
  {
	  Application.Quit();
  }
  
}
