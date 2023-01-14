using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class Coin : MonoBehaviour
{
    public delegate void OnCoinCollected();

    public static OnCoinCollected onCoinCollected;
    
    public bool Test = false;
    public GameObject CoinsEffect ;
    public  GameObject _sprite;
    private Collider2D _collider2D;
    private AudioSource _audioSource;

    public AudioClip[] AudioClips;
    
    private void Start()
    {
        _collider2D = GetComponent<Collider2D>();
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnMouseOver()
    {

        if (_audioSource != null)
        {
            int  randomClip = UnityEngine.Random.Range(0, AudioClips.Length -1);
            _audioSource.PlayOneShot(AudioClips[randomClip]);
        }

        GameObject.Instantiate(CoinsEffect, transform.position, Quaternion.identity);
        
        onCoinCollected.Invoke();
        // Debug.Log("collected")

        _sprite.SetActive(false);
        _collider2D.enabled = false;
        
        Invoke("Destroy", 1f);
    }

    void Destroy()
    {
        Destroy(gameObject);
    }
}
