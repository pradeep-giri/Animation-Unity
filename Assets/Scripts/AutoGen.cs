using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoGen : MonoBehaviour
{
    [SerializeField]
    private GameObject s;
    [SerializeField]
    private Transform pos;

    private int number = 5;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("WaitForSphare");
        //Invoke("SphareInstantiate", 5f);
        //InvokeRepeating("SphareInstantiate", 5f, 1f);
        //Time.timeScale = 0;
        InvokeRepeating("CountDown", 2f, 1f);
    }

    void CountDown()
    {
        number--;
    }

    bool NoCount()
    {
        Debug.Log("Number - " + number);
        
        if(number <= 0)
        {
            CancelInvoke("CountDown");
            return true;
        }
        else
        {
            return false;
        }  
    }

    //private void Update()
    //{
    //    if (Input.GetMouseButtonDown(0))
    //    {
    //        StopCoroutine("WaitForSphare");
    //        Debug.Log("Stop Coroutine");
    //    }
    //}

    void SphareInstantiate()
    {
        Instantiate(s, pos);
    }

    IEnumerator WaitForSphare()
    {
        while (true)
        {
            yield return new WaitUntil(NoCount);
            SphareInstantiate();
            yield return new WaitForSeconds(2);
            Debug.Log("Function called after 2 second");
        }
    }
}
