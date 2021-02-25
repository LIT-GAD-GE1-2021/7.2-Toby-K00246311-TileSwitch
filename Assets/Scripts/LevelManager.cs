using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LevelManager : MonoBehaviour {

    public static LevelManager instance;

    public GameObject redWall;
    public GameObject greenWall;

    private void Awake()
    {
        instance = this;
    }

    public void SwitchTileMap()
    {
        redWall.SetActive(!redWall.activeSelf);
        greenWall.SetActive(!greenWall.activeSelf);
    }
    
}
