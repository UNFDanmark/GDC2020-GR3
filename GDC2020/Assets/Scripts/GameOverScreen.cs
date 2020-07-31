using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameOverScreen : MonoBehaviour
{
    public Text scoreText;
    

    // Start is called before the first frame update
    void Start()
    {
        PointCount Score = FindObjectOfType<PointCount>();
        Cursor.visible = true;
        scoreText.text = "You scored: " + Score.points;

        Destroy(Score.gameObject);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
