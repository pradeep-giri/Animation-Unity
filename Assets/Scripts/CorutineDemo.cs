using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorutineDemo : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(WaitForSomeTime());
    }

    IEnumerator WaitForSomeTime()
    {
        yield return new WaitForSeconds(10f);
        // Debug.Log("Function called after 10 second");
    }
}
