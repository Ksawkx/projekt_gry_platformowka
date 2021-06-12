using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class PickUpBox : MonoBehaviour
{ 
    // Start is called before the first frame update
    
    //public PointsCounter pointsCounter;   
    public int pointsValue;
    /*
    CounterController counterController;

    void Start()
    {
        counterController = GameObject.Find("Manager").GetComponent<CounterController>();
        if (counterController == null)
        {
            Debug.LogError("CounterContrlorrer nie zostal znaleziony.");
        }
    }
    */
    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.name == "postac")
        {
            
            //pointsCounter.AddPoints (pointsValue);
            PointsCounter.instance.AddPoints(pointsValue);
            Destroy(this.gameObject);
            
//            counterController.IncrementCounter ();

        }

    }


}
