using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public bool isPressed;

    Button[] myButton;

    public void OnPointerDown(PointerEventData eventData)
    {
        
        isPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isPressed = false;
    }


}

