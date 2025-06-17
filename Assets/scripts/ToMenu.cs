using UnityEngine;
using UnityEngine.SceneManagement;

public class ToMenu : MonoBehaviour
{
    public void MENU()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
