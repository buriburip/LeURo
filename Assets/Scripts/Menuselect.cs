using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menuselect : MonoBehaviour
{
    public void StartGame(int Sceneindex)
    {
        SceneManager.LoadScene(Sceneindex);
    }
    
}