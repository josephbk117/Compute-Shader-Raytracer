using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedEnable : MonoBehaviour
{
    [SerializeField] private MonoBehaviour toEnable;

    private void Start()
    {
        Invoke("EnableMono", 1.0f);
    }

    private void EnableMono()
    {
        toEnable.enabled = true;
    }
}
