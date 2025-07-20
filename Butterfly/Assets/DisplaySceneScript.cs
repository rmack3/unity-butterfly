using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DisplayChecker : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Total displays Unity sees: " + Display.displays.Length);
    }
}