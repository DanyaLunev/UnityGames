using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CreateButtonFail : MonoBehaviour
{
    public Font font;
    public Transform panelBtn;
    public int sceneNumberRepeat;
    public void CrtButtonFail()
    {
        GameObject newButton = new GameObject("Button", typeof(Image), typeof(Button), typeof(LayoutElement));
        newButton.transform.SetParent(panelBtn);
        newButton.transform.SetParent(newButton.transform);
        RectTransform rect = newButton.GetComponent<RectTransform>();
        rect.sizeDelta = new Vector2(700, 170);

        GameObject newText = new GameObject("Text", typeof(Text));
        newText.transform.SetParent(newButton.transform);
        newText.GetComponent<Text>().font = font;
        newText.GetComponent<Text>().fontSize = 70;
        newText.GetComponent<Text>().alignment = TextAnchor.MiddleCenter;
        newText.GetComponent<Text>().color = new Color(0, 0, 0);
        newText.GetComponent<Text>().text = "Повторить";
        RectTransform rect1 = newText.GetComponent<RectTransform>();
        rect1.sizeDelta = new Vector2(350, 100);

        newButton.GetComponent<Button>().onClick.AddListener(delegate { SceneManager.LoadScene(sceneNumberRepeat); });
    }
}
