using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSoundController : MonoBehaviour
{
    public AudioClip jump;
    public AudioClip scoreHighlight;
    private AudioSource audioPlayer;

    public void PlayJump()
    {
        audioPlayer.PlayOneShot(jump);
    }

    public void PlayScoreHighlight()
    {
        audioPlayer.PlayOneShot(scoreHighlight);
    }

    private void Start()
    {
        audioPlayer = GetComponent<AudioSource>();
    }
}