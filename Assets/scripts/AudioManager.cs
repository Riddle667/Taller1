using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public List<AudioClip> AudioClips;
    public AudioSource audioSource;
    public static AudioManager instance;
    


    private void Awake() {
        if (instance == null){
            instance = this;
        }
        else{
            Destroy(this);
        }
    }

    //para que se reproduzca la canción
    public void PlaySound(string soundName)
    {
        foreach (var clip in this.AudioClips)
        {
            if(clip.name == soundName){
                this.audioSource.clip = clip;
                audioSource.Play();
                return;
            }
        }
        Debug.Log("Audio no fue encontrado.");
    }


    //para la música de fondo
    public void BackGroundMusic(string soundName)
    {
        foreach (var clip in this.AudioClips)
        {
            if(clip.name == soundName){
                this.audioSource.clip = clip;
                audioSource.Play();
                audioSource.loop = true;
                return;
            }
        }
        Debug.Log("Audio no fue encontrado.");
    }
}
