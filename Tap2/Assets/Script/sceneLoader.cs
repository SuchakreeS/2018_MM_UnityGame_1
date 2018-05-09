using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneLoader : MonoBehaviour {

    public string sceneName;    // what scene you gonna load
                                // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void loadScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
