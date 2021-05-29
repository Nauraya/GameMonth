using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLoader : MonoBehaviour
{
    public float delayLoading = 5f;

    private float timeElapsed;

    void Update() 
    { timeElapsed += Time.deltaTime;
        if(timeElapsed > delayLoading)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        }
        
    }
}
