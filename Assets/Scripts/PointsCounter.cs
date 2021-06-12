using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

    
public class PointsCounter : MonoBehaviour
{

    // Start is called before the first frame update
    public static PointsCounter instance;
    public int points = 0;
    public int pointsToAdd = 0;
    Text pointText;

    void Awake() 
    {
        if (instance == null)
        {
            instance = this;
        }
        else if(instance != this)
        {
            Destroy (gameObject);
        }
    }
    void Start()
    {
        pointText = GetComponent<Text>();
    }

    // Update is called once per frame
    public void AddPoints( int pointsToAdd)
    {
        //points++;
        points = points + pointsToAdd;
        UpdatePoints();
    }
    
    public void UpdatePoints ()
    {
        pointText.text = points.ToString();
    }
}
