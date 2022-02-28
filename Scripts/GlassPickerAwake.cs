using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassPickerAwake : MonoBehaviour
{
    public GameObject GlassPipe;
    void Start()
    {
        GlassPipe.SetActive(false);
    }

}
