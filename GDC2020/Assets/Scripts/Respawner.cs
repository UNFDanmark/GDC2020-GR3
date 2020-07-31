using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Respawner : MonoBehaviour
{
    public void RespawnButtonClicked()
    {
        
        SceneManager.LoadScene("Level");
    }
}
