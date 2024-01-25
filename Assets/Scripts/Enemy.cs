using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private GameObject enemy;
    [SerializeField] private float ammoAk = 0;
    [SerializeField] private float ammoPistol = 0;
    [SerializeField] private float ammoSniper = 0;

    private void Update()
    {
        if(ammoAk > 4)
        {
            Destroy(gameObject);
        }
        if(ammoPistol >6)
        {
            Destroy(gameObject);
        }
        if(ammoSniper > 2)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("AmmoAk"))
        {
            Debug.Log("dd");
            ammoAk++;
          //  Destroy(this.gameObject);
        }
        if(collision.gameObject.CompareTag("AmmoPistol"))
        {
            Debug.Log("p");
            ammoPistol++;
        }
        if(collision.gameObject.CompareTag("AmmoSniper"))
        {
            Debug.Log("s");
            ammoSniper++;
        }
        if(collision.gameObject.CompareTag("Knife"))
        {
            Destroy(this.gameObject);
            Debug.Log("dds");
        }
        if(collision.gameObject.CompareTag("Bomb"))
        {
            Destroy(gameObject);
        }
    }

}
