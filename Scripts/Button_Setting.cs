using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Setting : MonoBehaviour
{
    public GameObject BridgeGame;

    private void Start()
    {
        BridgeGame.SetActive(false);
    }
    public void OnClick()
    { //ゲームオブジェクト非表示→表示
        BridgeGame.SetActive(true);
    }
}
