using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ObjectShaker : MonoBehaviour
{
    [SerializeField] private float _shakeDuration = .4f;
    [SerializeField] private float _shakeStrength = 15f;
    [SerializeField] private int _shakeCicles = 20;
    [SerializeField] private bool _fadeOut = true;

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    public void Shake()
    {
        transform.DOShakePosition(duration:_shakeDuration, strength:new Vector3(_shakeStrength, 0f, 0f), vibrato: _shakeCicles, randomness: 0, snapping: true, fadeOut: _fadeOut);
    }
}
