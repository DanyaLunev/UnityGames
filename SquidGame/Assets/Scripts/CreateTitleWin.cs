using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateTitleWin : MonoBehaviour
{
    public Transform panelTitle;
    public Font font;
    public void CrtTitleWin()
    {
        GameObject newTitle = new GameObject("Text", typeof(Text));
        newTitle.transform.SetParent(panelTitle);
        newTitle.GetComponent<Text>().font = font;
        newTitle.GetComponent<Text>().fontSize = 120;
        newTitle.GetComponent<Text>().alignment = TextAnchor.MiddleCenter;
        newTitle.GetComponent<Text>().color = new Color(0, 0, 0);
        newTitle.GetComponent<Text>().text = "Вы выиграли!";
        RectTransform rt = newTitle.GetComponent<RectTransform>();
        rt.sizeDelta = new Vector2(900, 300);
    }
}
