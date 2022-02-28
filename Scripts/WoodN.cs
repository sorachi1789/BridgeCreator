using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WoodN : MonoBehaviour
{
    public Image Wood_M;
    public Image Wood_B;

    public void WoodNOnClick()
    {
        Wood_M.color = new Color(255.0f / 255.0f, 255.0f / 255.0f, 255.0f / 255.0f, 255.0f / 255.0f);
        Wood_B.color = new Color(255.0f / 255.0f, 255.0f / 255.0f, 255.0f / 255.0f, 255.0f / 255.0f);

    }
}
