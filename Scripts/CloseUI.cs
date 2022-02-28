using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseUI : MonoBehaviour
{
    public GameObject UIMiniGame;

    public void CloseBridgeMiniGame() 
    {
        UIMiniGame.SetActive(false);
    }
}