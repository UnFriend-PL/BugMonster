using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuteAudio : MonoBehaviour
{
    public AudioSource audiosource;

    public void Mute() {
        audiosource.mute = !audiosource.mute;
    }
}
