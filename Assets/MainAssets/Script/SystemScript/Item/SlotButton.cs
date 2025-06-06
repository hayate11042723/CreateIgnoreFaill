using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SlotButton : MonoBehaviour,
    IPointerClickHandler,
    IPointerDownHandler,
    IPointerUpHandler
{
    [SerializeField] GameObject itemKanriObject;
    [SerializeField] GameObject itemSellObject;

    ItemKanri itemscript;
    ItemSellExplanation itemSellExplanation;

    void Start()
    {
        itemscript = itemKanriObject.GetComponent<ItemKanri>();
        itemSellExplanation = itemSellObject.GetComponent<ItemSellExplanation>();
    }

    // 押す  
    public void OnPointerClick(PointerEventData eventData)
    {
        itemscript.slotkoushin();
        itemSellExplanation.slotkoushin();
    }

    // 押されたまま
    public void OnPointerDown(PointerEventData eventData)
    {

    }

    // 押した後放した 
    public void OnPointerUp(PointerEventData eventData)
    {

    }
}
