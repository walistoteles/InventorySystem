using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class MouseItemData : MonoBehaviour
{
    public Image ItemSprite;
    public TextMeshProUGUI text;

    private void Awake()
    {
        ItemSprite.color = Color.clear;
        text.text = "";
    }
}
