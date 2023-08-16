using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Cutscene : MonoBehaviour
{
    public Text ct;

    // Ct means cutscene text

    void Start()
    {
        StartCoroutine(Test());
    }

    IEnumerator Test()
    {
        yield return new WaitForSeconds(3f);
        Debug.Log("IDK");
    }
}
