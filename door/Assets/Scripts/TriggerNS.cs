using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerNS : MonoBehaviour
{
    [SerializeField] GameObject obg;
    [SerializeField] GameObject text;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            text.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        text.SetActive(false);
    }
}
