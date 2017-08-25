using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundFx : MonoBehaviour
{
    AudioSource m_audio;
    void Start()
    {
        m_audio = GetComponent<AudioSource>();
    }

    public void Play()
    {
        m_audio.PlayOneShot(m_audio.clip);
    }
}
