using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text countOfDirtText;


    public int countOfDirt = 0;
    public int countOfFood = 0;
    
    // Start is called before the first frame update
    public void Start()
    {
        countOfDirtText.text = $"{countOfDirt} Points";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
