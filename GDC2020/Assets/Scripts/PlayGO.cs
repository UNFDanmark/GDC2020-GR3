using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayGO : MonoBehaviour
{
    public void StartButtonClicked()
    {
        SceneManager.LoadScene("SampleScene");
    }

}
