using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class btn_managerback : MonoBehaviour
{ int sceneIndex;
void start(){
    sceneIndex = SceneManager.GetActiveScene ().buildIndex;
}
void update(){
    if (Input.GetKeyDown (KeyCode.Escape))
    SceneManager.LoadScene(sceneIndex-1);
}
}
