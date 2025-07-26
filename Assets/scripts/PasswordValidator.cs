using UnityEngine;
using TMPro;

public class PasswordValidator : MonoBehaviour
{
    public string correctPassword = "1234";

    public TMP_InputField passwordInput;
    public GameObject passwordPanel;
    public GameObject correctPanel;
    public GameObject incorrectPanel;

    public void CheckPassword()
    {
        string enteredPassword = passwordInput.text;

        if (enteredPassword == correctPassword)
        {
            correctPanel.SetActive(true);
            incorrectPanel.SetActive(false);
            passwordPanel.SetActive(false);
        }
        else
        {
            correctPanel.SetActive(false);
            incorrectPanel.SetActive(true);
        }
    }
}
