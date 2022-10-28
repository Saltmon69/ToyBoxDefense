using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Button_Gamefeel : MonoBehaviour, IPointerEnterHandler

{
    public AudioSource source;
    private RectTransform _transform;

    private void Start()
    {
        _transform = gameObject.GetComponent<RectTransform>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        _transform.lossyScale.Set(27, 27,27 );
        source.Play();
    }
}
