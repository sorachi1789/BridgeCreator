using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WoodColor : MonoBehaviour
{
    public Image Wood_M;
    public Image Wood_B;
    public Image NowColor;

    public void WoddColorOnClick()
    {
        
        Wood_M.color = NowColor.color*1.5f;
        Wood_B.color = NowColor.color*1.5f;
    }
}
