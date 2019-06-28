using System.Collections;
using System.Collections.Generic;
using UnityEngine;


bool sceneChanged = false;


public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (sceneChanged == true) return;
        if(Input.GetMouseButtonDown(0))
        {
            UnityEngine.SceneManagement.SceneManager.LoadSceneAsync("Game");
        }
    }
}
