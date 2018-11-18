using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class walkBackController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {

    public void OnPointerDown(PointerEventData data)
    {
        fighterController.moveBack = true;
    }

    public void OnPointerUp(PointerEventData data)
    {
        fighterController.moveBack = false;
    }

}
