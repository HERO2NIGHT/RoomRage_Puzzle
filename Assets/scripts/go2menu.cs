using UnityEngine;
using UnityEngine.SceneManagement;

public class go2menu : MonoBehaviour
{
    public void BackToMenu()
	{
		SceneManager.LoadSceneAsync(0);
	}
}
