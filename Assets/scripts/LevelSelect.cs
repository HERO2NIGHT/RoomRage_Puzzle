using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
	public void Garrage_B()
	{
		SceneManager.LoadSceneAsync(1);
	}

	public void OldGarrage_B()
	{
		SceneManager.LoadSceneAsync(2);
	}

	public void Kitchen_B()
	{
		SceneManager.LoadSceneAsync(3);
	}

	public void Mom_Lab_B()
	{
		SceneManager.LoadSceneAsync(4);
	}

	public void Bathroom_B()
	{
		SceneManager.LoadSceneAsync(5);
	}

	public void Bedroom_B()
	{
		SceneManager.LoadSceneAsync(6);
	}
}
