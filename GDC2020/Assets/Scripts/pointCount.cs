using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointCount : MonoBehaviour
{ 
    public int points = 0;

    public Text pointsText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetPoints(int pointDiff)
    {
        //points = points + pointDiff;
        points += pointDiff;

        pointsText.text = "Points: " + points.ToString();
    }
}
