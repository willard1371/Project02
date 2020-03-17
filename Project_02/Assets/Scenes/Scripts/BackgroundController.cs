﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    private Renderer renderer;
    private Vector2 savedOffset;

    public float scrollSpeed;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float y = Mathf.Repeat(Time.time * scrollSpeed, 1);
        Vector2 offset = new Vector2(0, y);
        renderer.sharedMaterial.SetTextureOffset("_MainTex", offset);
    }
}
