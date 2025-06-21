using UnityEngine;
using UnityEngine.EventSystems;

public class DropHandler : MonoBehaviour, IDropHandler
{
    public GameObject tickImage;      // The tick mark image to show
    public GameObject oilCanObject;   // The draggable oil can GameObject

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            if (oilCanObject == null || tickImage == null)
            {
                Debug.LogError("DropHandler: Required references are not assigned in the Inspector.");
                return;
            }

            // Check if the dropped object is the oil can
            if (eventData.pointerDrag == oilCanObject)
            {
                // Disable the oil can (optional)
                oilCanObject.SetActive(false);

                // Show the tick mark
                tickImage.SetActive(true);

                Debug.Log("Correct item dropped!");
            }
            else
            {
                Debug.Log("Wrong item dropped!");
            }
        }
    }
}
