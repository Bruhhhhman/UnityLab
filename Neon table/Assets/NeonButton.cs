using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class NeonButton : MonoBehaviour
{


    public void onDown()
    {
        GetComponent<PostProcessVolume>().enabled = true;
    }

    public void onUp()
    {
        GetComponent<PostProcessVolume>().enabled = false;
    }


}
