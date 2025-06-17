using UnityEngine;
using UnityEngine.SceneManagement;

public class HoodClickHandler : MonoBehaviour
{
    public string sceneToLoad = "Old_Garrage P2";

    public void OnHoodClick()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
