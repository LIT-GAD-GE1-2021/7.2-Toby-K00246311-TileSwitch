﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        LevelManager.instance.SwitchTileMap();
    }
}
