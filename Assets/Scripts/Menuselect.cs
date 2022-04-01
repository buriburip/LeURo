using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuSelect : MonoBehaviour
{
    public void ChangeScene(int Sceneindex)
    {
        SceneManager.LoadScene(Sceneindex);
    }
    
}