using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GUIManager : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnPlay(){
        SceneManager.LoadScene("Main");
    }

    public void OnHard(){
        SceneManager.LoadScene("Hard");
    }

    public void OnHelp(){
        SceneManager.LoadScene("Help");
    }

    public void OnBack(){
        SceneManager.LoadScene("Menu");
    }

}
