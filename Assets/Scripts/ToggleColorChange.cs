using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleColorChange : MonoBehaviour
{
    private SpriteRenderer sprite;
    private Color originalColor;
    private bool colorChanged = false;

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        originalColor = sprite.color;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (colorChanged)
            {
                sprite.color = originalColor;
            }
            else
            {
                sprite.color = new Color(0, 0, 0, 0.5f);
            }

            colorChanged = !colorChanged;
        }
    }
}
