using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZdejmijZeSceny : MonoBehaviour
{
    Licznik licznik;
    // Start is called before the first frame update
    void Start()
    {
        licznik = GameObject.Find("Manager").GetComponent<Licznik>();
        if (licznik == null)
        {
            Debug.LogError ("Licznik nie zostal znaleziony.");
        }
        
    }

    // Update is called once per frame
    void OnTriggerEnter2D (Collider2D other) 
    {
        if (other.gameObject.name == "postac") {
            Destroy (this.gameObject);
            licznik.PunktyPlus ();
        }
    }
    
}
