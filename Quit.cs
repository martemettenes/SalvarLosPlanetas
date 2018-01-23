using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour {

    public void quitApplication(){
        print("quit game");
        Application.Quit();   
    }
}
