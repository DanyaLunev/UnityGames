using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelPanelUp : MonoBehaviour
{
    public Transform Panel;
    public void TransformPanel()
    {
        Panel.transform.Translate(0, 1150, 0);
    }
}
