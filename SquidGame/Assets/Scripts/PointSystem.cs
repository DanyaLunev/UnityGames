using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PointSystem : MonoBehaviour
{
    public CreateTitleWin createTitleWin;
    public CreateTitleFail createTitleFail;
    public CreateButtonWin createButtonWin;
    public CreateButtonFail createButtonFail;
    public LevelController levelController;
    public int pointsNumber;
    public GameObject FailCollider;
    private int isWin = 0;
    private bool isFail = false;

    void OnTriggerEnter(Collider other)
    {
        if (isWin != pointsNumber)
        {
            if (other.tag == "PointCrack")
            {
                isWin += 1;
                Debug.Log("Crack");
            }

            if (isWin == pointsNumber)
            {
                isFail = false;
                createTitleWin.CrtTitleWin();
                createButtonWin.CrtButtonWin();
                levelController.Start();
                levelController.isEndGame();
            }
        }

        if (other.tag == "PointFail")
        {
            if (!isFail)
            {
                isFail = true;
                Destroy(FailCollider, 1f);
                createTitleFail.CrtTitleFail();
                createButtonFail.CrtButtonFail();
                Debug.Log("Fail");
            }
        }
    }
}
