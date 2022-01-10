using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void ChangeScene()
    {
        if (PlayerPrefs.GetInt("LevelComplete") < 3)
        {
            SceneManager.LoadScene(PlayerPrefs.GetInt("LevelComplete") + 1);
        }
        else
        {
            SceneManager.LoadScene(3);
        }
    }
}
