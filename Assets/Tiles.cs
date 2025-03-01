using Mono.Cecil;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiles : MonoBehaviour
{
    [Header("Sides")]
    
    public bool UpSideIsOpen;
    public bool DownSideIsOpen;
    public bool LeftSideIsOpen;
    public bool RightSideIsOpen;

    [Header("Ways")]
    public int ways;

    [Header("Type")]
    public Types.TileTypes type;

    private void Start()
    {
        SpriteManager.BuildSprite();
    }
}
