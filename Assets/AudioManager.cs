using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Start is called before the first frame update

    AudioSource audiosource;
   public AudioClip [] clips;
    AudioClip playaudioclip;
    void Start()
    {
        audiosource = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void PlayAudio(int i, float avolume, float delay)
    {
        
        playaudioclip = clips[i];
        audiosource.clip = playaudioclip;
        StartCoroutine(PlayAudioNow(delay));
    }
    IEnumerator PlayAudioNow(float i)
    {
        yield return new WaitForSeconds(i);
        audiosource.Play();
    }
}
