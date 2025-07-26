using UnityEngine;
using TMPro;

public class Password : MonoBehaviour
{
    public string Code = "674362";

    public GameObject CorrectPass;

    public GameObject IncorrectPass;

   // public TMP_InputField inputField;

    public void Validate(string  enteredPassword)
    {
        if (enteredPassword == Code)
        {
           CorrectPass.SetActive(true);
           IncorrectPass.SetActive(false);
        }
        else
        {
           CorrectPass.SetActive(false);
           IncorrectPass.SetActive(true);
        }
    }
}
