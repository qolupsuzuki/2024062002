using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LastRuleManager: MonoBehaviour
{
    public void PushNextButton(){
        SceneManager.LoadScene("Q1GameScene");

    }
}