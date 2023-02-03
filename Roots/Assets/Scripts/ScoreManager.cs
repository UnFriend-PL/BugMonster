using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text countOfDirtText;


    int countOfDirt = 0;
    // Start is called before the first frame update
    void Start()
    {
        countOfDirtText.text = $"{countOfDirt} Points";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
