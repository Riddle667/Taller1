using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public List<AudioClip> AudioClips;
    public AudioSource audioSource;
    public static SoundManager instance;

    private void Awake() {
        if (instance == null){
            instance = this;
        }
        else{
            Destroy(this);
        }
    }

    public void PlaySound(string soundName){
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

    public AudioClip fallSound(){
        return this.AudioClips[1];
    }
    public AudioClip successSound(){
        return this.AudioClips[8];
    }
    
}
