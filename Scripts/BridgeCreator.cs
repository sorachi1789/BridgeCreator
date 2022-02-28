using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BridgeCreator : MonoBehaviour
{
    public GameObject UIMiniGame;
    public GameObject Set;
    public Transform Parent;

    public Image SetBottom;
    public Image SetBottom2;
    public Image SetString;
    public Image Bottom;
    public Image Bottom2;
    public Image String;
    public DropImage Drop;

    public void CreatBridgeMain()
    {
        if (Drop.StringPicker > 0)
        {
            var clones = GameObject.FindGameObjectsWithTag("Set");
            foreach (var clone in clones)
            {
                Destroy(clone);
            }

            SetBottom.sprite = Bottom.sprite;
            SetBottom.color = Bottom.color;
            SetBottom2.sprite = Bottom2.sprite;
            SetBottom2.color = Bottom2.color;
            SetString.sprite = String.sprite;
            SetString.color = String.color;

            for (int i = 0; i < 4; ++i)
            {
                GameObject a = Instantiate(Set, new Vector3(-100.0f + i * 100f, 0.0f, 0.0f), Quaternion.identity);
                a.transform.SetParent(Parent, false);
                a.tag = "Set";
            }

            UIMiniGame.SetActive(false);
        }
    }
}
