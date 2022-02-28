using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StringColor : MonoBehaviour
{
    public Image String;
    public Image NowColor;

    public void StringColorOnClick()
    {
            String.color = NowColor.color*1.5f;
    }
}
