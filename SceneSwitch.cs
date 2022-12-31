using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{

    public void sceneMenu(){
        SceneManager.LoadScene("#1Menu");
    }

    public void sceneMulai(){
        // 
    }

    public void sceneMarker(){
        SceneManager.LoadScene("#4UnduhMarker");
    }

    public void sceneRumus1(){
        SceneManager.LoadScene("#5_1Rumus");
    }

    public void sceneRumus2(){
        SceneManager.LoadScene("#5_2Rumus");
    }

    public void sceneRumus3(){
        SceneManager.LoadScene("#5_3Rumus");
    }

    public void sceneBantuan(){
        SceneManager.LoadScene("#2Petunjuk Penggunaan");
    }

    public void sceneTentang(){
        SceneManager.LoadScene("#3Informasi Aplikasi");
    }

}
