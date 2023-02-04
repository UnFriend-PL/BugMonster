using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseObjAppear : MonoBehaviour
{
    private bool gamePaused = false;

    void Update(){
        if(Input.GetKeyDown(KeyCode.Escape)) {
            if (gamePaused == true) {
                transform.position = new Vector3(transform.position.x, transform.position.y + 310, transform.position.z);
                gamePaused = !gamePaused;
            } else {
                transform.position = new Vector3(transform.position.x, transform.position.y - 310, transform.position.z);
                gamePaused = !gamePaused;
            }
        }
    }
    
}
