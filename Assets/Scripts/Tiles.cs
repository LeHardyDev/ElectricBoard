using Mono.Cecil;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tiles : MonoBehaviour
{
    public Types.TileTypes tileType;
    int ways;
    public bool upSideIsOpen;
    public bool downSideIsOpen;
    public bool leftSideIsOpen;
    public bool rightSideIsOpen;
    public Sprite[] sprites;
    public Image image;
    public bool isCharged;
}
