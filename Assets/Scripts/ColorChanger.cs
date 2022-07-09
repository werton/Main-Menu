using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

[RequireComponent(typeof(Button))]
public class ColorChanger : MonoBehaviour
{
    [SerializeField] Color _targetColor = Color.red;
    [SerializeField] float _duration = 1f;

    private Button _button;
    private Tweener _buttonColorTween;

    void Awake()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(StartColorChange);
    }

    private void StartColorChange()
    {

        _buttonColorTween = _button.image.DOColor(_targetColor, _duration);
        StartCoroutine(ChangeFontColor());
    }

    private IEnumerator ChangeFontColor()
    {
        while (_buttonColorTween?.IsPlaying() == true)
        {
            yield return null;
        }

        Debug.Log("sdf");

        _button.GetComponentInChildren<Text>().color = Color.white;
        yield break;
    }
}
