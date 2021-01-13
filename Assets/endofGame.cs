using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endofGame : MonoBehaviour
{
   public void EndOfGame()
    {
        Debug.Log("HIT");
        Application.Quit();
    }
}
