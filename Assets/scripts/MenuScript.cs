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
	  SceneManager.LoadSceneAsync(8);
  }

   public void How2PlayButton()
  {
	  SceneManager.LoadSceneAsync(9);
  }

   public void QuitButton()
  {
	  Application.Quit();
  }
  
}
