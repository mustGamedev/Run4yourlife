using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoreManager : MonoBehaviour
{
    // display finish UI panel with button

    public static CoreManager instance;
    //

    private void Awake()
    {
        instance = this;
    }

}
