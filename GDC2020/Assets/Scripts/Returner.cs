using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Returner : MonoBehaviour
{
    public void ReturnButtonClicked()
    {
        SceneManager.LoadScene("StartMenu");
    }
}
