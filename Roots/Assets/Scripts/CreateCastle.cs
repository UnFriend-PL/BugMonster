using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCastle : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject selectedSquare;

    public GameObject icon;
    Transform iconObject;
    public void CreateNewCastle()
    {
        // reference prefab
        Debug.Log("Clicked");
         iconObject = Instantiate(icon).transform;
    }
    private void Update()
    {
        if (selectedSquare != null)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            iconObject.position = mousePosition;
        }
    }
    //    private void OnMouseDown()
    //    {
    //        selectedSquare = gameObject;
    //    }
}
