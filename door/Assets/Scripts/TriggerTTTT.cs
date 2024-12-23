using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTTTT : MonoBehaviour
{

    [SerializeField] GameObject obj;
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
