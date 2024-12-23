using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTV : MonoBehaviour
{
    [SerializeField] GameObject obj;
    [SerializeField] GameObject tv;
    [SerializeField] GameObject light;
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            tv.SetActive(true);
            light.SetActive(true);
        }

    }
    private void OnTriggerExit(Collider other)
    {
        tv.SetActive(false);
        light.SetActive(false);
    }



    void Update()
    {
        
    }
}
