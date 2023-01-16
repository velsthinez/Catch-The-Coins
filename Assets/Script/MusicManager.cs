using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioClip EndGameMusic;
    
    private AudioSource _Audio;
    
    private void OnEnable()
    {
        TimeManager.OnEnd += PlayEndGameMusic;
    }

    private void OnDisable()
    {
        TimeManager.OnEnd -= PlayEndGameMusic;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        _Audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void PlayEndGameMusic()
    {
        if (_Audio == null || EndGameMusic == null)
            return;
        
        _Audio.Stop();
        _Audio.clip = EndGameMusic;
        _Audio.Play();
    }
}
