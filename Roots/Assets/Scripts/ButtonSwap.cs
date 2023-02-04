using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonSwap : MonoBehaviour
{
    public Sprite firstImage;
    public Sprite secondImage;
    public Image buttonImage;

    public void SwapImage()
    {
      
        if (buttonImage.sprite == firstImage)
        {
            buttonImage.sprite = secondImage;
        }
        else
        {
            buttonImage.sprite = firstImage;
        }
    }
}
