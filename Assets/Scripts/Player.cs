using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Animator anim;
    public Rigidbody rb;
    private float horizX;
    private float vertiY;
    // [SerializeField] private float xspeed = 3f;
    // [SerializeField] private float yspeed = 3f; 
    // Start is called before the first frame update
    [SerializeField] private GameObject bombArea;
    [SerializeField] private GameObject pistolAmmo;
    [SerializeField] private GameObject aKAmmo;
    [SerializeField] private GameObject sniperAmmo;
    [SerializeField] private GameObject knife;
    [SerializeField] private GameObject ak47;
    [SerializeField] private GameObject sniper;
    [SerializeField] private GameObject pistol;
    public bool knifeThrow = false;
    public bool AkCLick = false;
    public bool pistolClick = false;
    public bool sniperCLick = false;
    public bool pistolClickAmmo = false;
    public bool sniperClickAmmo = false;
    public GameObject grenade;
    public GameObject grenadeArea;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
         
    }
    void Grenadebomb()
    {
        Instantiate(grenade, grenadeArea.transform.position, grenadeArea.transform.rotation);
    }
        
    // Update is called once per frame
    void Update()
    {
        horizX = Input.GetAxisRaw("Horizontal");
        vertiY = Input.GetAxisRaw("Vertical");
        transform.Translate(Vector3.forward * vertiY*Time.deltaTime);
        transform.Translate(Vector3.right * horizX*Time.deltaTime);
       
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Invoke("Grenadebomb", 1f);
        }
        if(AkCLick)
        {
            if (Input.GetMouseButtonDown(0))
            {
                InstantAmmoAk();
                
            }
        }
        if (pistolClick)
        {
            if (Input.GetMouseButtonDown(0))
            {
                InstantAmmopISTOL();



            }
        }
        if(sniperCLick)
        {
            if (Input.GetMouseButtonDown(0))
            {
                InstantAmmoSniper();



            }

        }

        if(Input.GetKeyDown(KeyCode.Z))
        {
            sniperClickAmmo = false;
            anim.SetBool("Knife", true);
            Invoke("ResetBoolFalse", 2f);
            knifeThrow = true;
            knife.SetActive(true);
            pistol.SetActive(false);
            ak47.SetActive(false);
            sniper.SetActive(false);
            AkCLick = false;
            pistolClick = false;
            pistolClickAmmo = false; 
            sniperClickAmmo = false;
        }
        if(Input.GetKeyDown(KeyCode.X))
        {
            sniperClickAmmo = false;
            AkCLick = false;
            knifeThrow = false;
            knife.SetActive(false);
            pistol.SetActive(true);
            ak47.SetActive(false);
            sniper.SetActive(false);
            pistolClick = true;
            pistolClickAmmo = false;
            sniperClickAmmo = false;
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            sniperClickAmmo = false;
            AkCLick = true;
            knifeThrow = false;
            knife.SetActive(false);
            pistol.SetActive(false);
            ak47.SetActive(true);
            sniper.SetActive(false);
            pistolClick = false;
            sniperClickAmmo = false;
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            sniperCLick = true;
            AkCLick = false;
            knifeThrow = false;
            knife.SetActive(false);
            pistol.SetActive(false);
            ak47.SetActive(false);
            sniper.SetActive(true);
            pistolClick = false;
           // sniperClickAmmo = true;
        }
    }
    void WaitTIme()
    {
        Debug.Log("dd");
        pistolClick = false;
    }
    void WaitTIme2()
    {
        Debug.Log("dd");
        pistolClick = true;
    }
    void WaitTIme3()
    {
        Debug.Log("dd");
        pistolClickAmmo = false;
    }
    void WaitTIme4()
    {
        Debug.Log("dd");
        pistolClickAmmo = true;
    }
    void WaitTIme5()
    {
        Debug.Log("dd");
        sniperCLick = true;
    }
    void WaitTIme6()
    {
        Debug.Log("dd");
        sniperCLick = false;
    }
    void InstantAmmopISTOL()
    {
        Instantiate(pistolAmmo, bombArea.transform.position, bombArea.transform.rotation);
        //Instantiate(ammo, bombArea.transform.position, bombArea.transform.rotation);
        Invoke("WaitTIme", .7f);
        Invoke("WaitTIme3", .01f);
        Invoke("WaitTIme2", 1.2f);
    }
    void InstantAmmoAk()
    {
        Instantiate(aKAmmo, bombArea.transform.position, bombArea.transform.rotation);
        //Instantiate(ammo, bombArea.transform.position, bombArea.transform.rotation);
        Invoke("WaitTIme3", .2f);
        Invoke("WaitTIme1", .01f);
        Invoke("WaitTIme4", .4f);
    }
    void InstantAmmoSniper()
    {
        Instantiate(sniperAmmo, bombArea.transform.position, bombArea.transform.rotation);
        //Instantiate(ammo, bombArea.transform.position, bombArea.transform.rotation);
        Invoke("WaitTIme6", .2f);
        Invoke("WaitTIme1", .01f);
        Invoke("WaitTIme5", 3f);
    }
    private void ResetBoolFalse()
    {
       anim.SetBool("Knife", false);
    }
   
}
