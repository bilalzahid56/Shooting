using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeWeapons : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


}
