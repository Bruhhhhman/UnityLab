using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class AudioManager : MonoBehaviour
{
    public AudioClip[] musicClips;
    private int currentTrack;
    private AudioSource source;


    public Text clipTitleText;
    public Text clipTimeText;

    public int fullLenght;
    public int playTime;
    public int seconds;
    private int minutes;
    void Start()
    {
        source = GetComponent<AudioSource>();
        PlayMusic();
    }

    public void PlayMusic()
    {
        if (source.isPlaying)
        {
            return;
        }

        currentTrack--;
        if (currentTrack<0)
        {
            currentTrack = musicClips.Length - 1;
        }
        StartCoroutine("WaitForMusicEnd");
    }
    IEnumerator WaitForMusicEnd()
    {
        while (source.isPlaying)
        {
            playTime = (int)source.time;
            ShowPlayTime();
            yield return null;
        }
        NextTitle();
    }
    public void NextTitle()
    {
        source.Stop();
        currentTrack++;
        if (currentTrack > musicClips.Length -1)
        {
            currentTrack = 0;
        }
        source.clip = musicClips[currentTrack];
        source.Play();
        ShowCurrentTitle();
        StartCoroutine("WaitForMusicEnd");
    }
    public void PreviousTitle()
    {
        source.Stop();
        currentTrack--;
        if (currentTrack < 0)
        {
            currentTrack = musicClips.Length - 1;
        }
        source.clip = musicClips[currentTrack];
        source.Play();
        ShowCurrentTitle();
        StartCoroutine("WaitForMusicEnd");
    }
    public void StopMusic()
    {
        StopCoroutine("WaitForMusicEnd");
        source.Pause();
    }
    public void MuteMusic()
    {
        source.mute = !source.mute;

    }
    void ShowCurrentTitle()
    {
        clipTitleText.text = source.clip.name;
        fullLenght = (int)source.clip.length;
    }
    void ShowPlayTime()
    {
        seconds = playTime % 60;
        minutes = (playTime / 60) % 60;
        clipTimeText.text = minutes + ":" + seconds.ToString("D2") + "/" + ((fullLenght/60) %60) + ":" + (fullLenght %60).ToString("D2");
    }
    public void PlusTen()
    {
        source.time = source.time + 10;
    }
    public void MinusTen()
    {
        if (source.time > 10)
        {
            source.time = source.time - 10;
        }
        else
        {
            source.time = 0;
        }
    }
}
