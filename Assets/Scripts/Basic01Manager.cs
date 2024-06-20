using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Basic01Manager: MonoBehaviour
{
    public void Push01Button(){
        SceneManager.LoadScene("BasicScene02");
    }
    public void Push02Button(){
        SceneManager.LoadScene("BasicScene02");
    }
    public void Push03Button(){
        SceneManager.LoadScene("BasicScene02");
    }

}

