using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SampleManager: MonoBehaviour
{
    public void PushNextButton(){
        SceneManager.LoadScene("RuleScene");
    }
}

