using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    private static BackgroundMusic instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Don’t destroy on scene change
        }
        else
        {
            Destroy(gameObject); // Prevent duplicates
        }
    }
}
