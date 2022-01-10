using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Button level2;
    public Button level3;
    public GameObject Camera;
    int levelComplete;

    void Start()
    {
        levelComplete = PlayerPrefs.GetInt("LevelComplete");
        level2.interactable = false;
        level3.interactable = false;

        switch (levelComplete)
        {
            case 1:
                level2.interactable = true;
                Camera.transform.Translate(20, 0, 0);
                break;

            case 2:
                level2.interactable = true;
                level3.interactable = true;
                Camera.transform.Translate(40, 0, 0);
                break;
        }
    }

    public void LoadTo(int level)
    {
        SceneManager.LoadScene(level);
    }

    public void ResetScene()
    {
        level2.interactable = false;
        level3.interactable = false;
        Camera.transform.Translate(-PlayerPrefs.GetInt("LevelComplete") * 20, 0, 0);
        PlayerPrefs.DeleteAll();
    }
}
