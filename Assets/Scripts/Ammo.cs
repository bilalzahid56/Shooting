using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : Weapons
{
    
    [SerializeField] private float speed = 50;

    // Start is called before the first frame update
    override protected void Start()
    {
        
        Invoke("Destory", 3f);
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(Vector3.forward*speed);
    }
    void Destory()
    {
        Destroy(this.gameObject);
    }
  
}
