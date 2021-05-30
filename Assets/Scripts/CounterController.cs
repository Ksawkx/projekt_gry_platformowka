using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CounterController : MonoBehaviour
{

    int numerOfBoxes;
    Text counterView;

    // Start is called before the first frame update
    void Start()
    {
        ResetCounter();

    }

    public void IncrementCounter()
    {
        numerOfBoxes++;
        counterView.text = numerOfBoxes.ToString();
    }
        public void ResetCounter()
    {
        numerOfBoxes = 0;
        counterView.text = numerOfBoxes.ToString();
    }

}
