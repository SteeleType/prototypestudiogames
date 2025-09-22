using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class FlashingScript : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    private Color newestColor;

    public void Update()
    {
        int choice = Random.Range(0, 1);
        if (choice == 1)
        {
            Color newestColor = new Color(255f, 255f, 255f, 1f);
        }

        if (choice == 0)
        {
            Color newestColor = new Color(0f, 0f, 0f, 1f);
        }

        spriteRenderer.color = newestColor;
    }
}
