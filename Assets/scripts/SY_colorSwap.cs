using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SY_colorSwap : MonoBehaviour
{
    [SerializeField] private SpriteRenderer sprite;
    [SerializeField] private Color colorA, colorB;
    private bool state;
    private float index;

    void Start()
    {
        StartCoroutine(blink());
    }

    IEnumerator blink()
    {
        if (state)
        {
            sprite.color = Color.Lerp(sprite.color, colorA, index);
            index += 0.01f;
            if (index >= 1) { state = false; }
        }
        else
        {
            sprite.color = Color.Lerp(sprite.color, colorB, index);
            index -= 0.01f;
            if (index <= 0) { state = true; }
        }
        yield return new WaitForSeconds(0.001f);
        StartCoroutine(blink());

    }
}
