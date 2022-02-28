using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MovePage : MonoBehaviour
{
    public GameObject ThisOB;
    public GameObject Picker;
    public Transform PickerPre;

    public void MovePageOnClick() 
    {

        ThisOB.SetActive(false);
        Picker.SetActive(true);

    }
}
