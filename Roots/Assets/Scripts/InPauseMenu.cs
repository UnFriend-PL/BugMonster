using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InPauseMenu : MonoBehaviour
{
    private bool gamePaused = false;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)) {
		if(gamePaused) {
			Time.timeScale = 1;
			gamePaused = false;
		} else {
			Time.timeScale = 0;
			gamePaused = true;
            }
		}
    }
    void OnGUI() {
	if(gamePaused) {
		Color background = Color.black;
		background.a = 0.3f;
		DrawQuad(new Rect(0, 0, Screen.width, Screen.height), background);
        ShowPause();
	    }
    }
    void DrawQuad(Rect position, Color color) {
	Texture2D texture = new Texture2D(1, 1);
	texture.SetPixel(0,0,color);
	texture.Apply();
	GUI.skin.box.normal.background = texture;
	GUI.Box(position, GUIContent.none);
}
    void ShowPause() {

    }
}




