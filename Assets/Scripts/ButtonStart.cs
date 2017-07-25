using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonStart : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Rigidbody2D LogoBallLeft;


    public void OnPointerEnter(PointerEventData eventData)
    {
        DOTween.To()
    }

    public void OnPointerExit(PointerEventData eventData)

    {
        Debug.Log("2");
    }

}
