using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class walkForwardController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public void OnPointerDown(PointerEventData data)
    {
        fighterController.moveForward = true;
    }

    public void OnPointerUp(PointerEventData data)
    {
        fighterController.moveForward = false;
    }

}
