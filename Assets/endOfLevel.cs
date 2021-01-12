using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class endOfLevel : MonoBehaviour
{    public void EndOfGame()
    {
        //Debug.Log("HIT");
        //Application.Quit();
        SceneManager.LoadScene("Sala");
    }
}
