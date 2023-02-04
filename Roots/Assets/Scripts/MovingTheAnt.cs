using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovingTheAnt : MonoBehaviour
{
    private float speed = 1.0f; //Szybkośc poruszania się,
    private Vector3 targetposition;             //Pozycja docelowa
    private void Update() {
        if(Input.GetMouseButtonDown(1))         //Sprawdzenie czy przycisk zostal kliknięty.
        {
            targetposition = Camera.main.ScreenToWorldPoint(Input.mousePosition); //Pobieranie pozycji kursora

            targetposition.z = 1; //ustawienie wartość z na 1;


        }
        transform.position = Vector3.Lerp(transform.position, targetposition, speed*Time.deltaTime);



        // if(Input.GetMouseButtonDown(1))
        // {
        //     Vector3 targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //     targetPos.z = transform.position.z; 
        //     StartCoroutine(SmoothMovement(targetPos));

        // }
    }
    /*IEnumerator SmoothMovement(Vector3 targetPos)
    {
        while(Vector3.Distance(transform.position, targetPos)>0.01f)
        {
            transform.position = Vector3.Lerp(transform.position, targetPos, speed * Time.deltaTime);
            yield return null;
        }
    }*/
}
