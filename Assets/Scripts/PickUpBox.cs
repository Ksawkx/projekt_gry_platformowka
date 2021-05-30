using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpBox : MonoBehaviour
{

    CounterController counterController;
    
    // Start is called before the first frame update
    void Start()
    {
        counterController = GameObject.Find("Manager").GetComponent<CounterController>();
        if (counterController == null)
        {
            Debug.LogError("CounterContrlorrer nie zostal znaleziony.");
        }
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.name == "postac"){
            Destroy(this.gameObject);
            counterController.IncrementCounter ();

        }

    }


}
