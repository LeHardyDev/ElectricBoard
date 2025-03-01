using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;
using UnityEngine.UI;

public class SpriteManager : MonoBehaviour
{
    public static void BuildSprite(Types.TileTypes type, int ways, bool upSideIsOpen, bool downSideIsOpen, bool leftSideIsOpen, bool rightSideIsOpen, Sprite[][] spriteArrays, Image image)
    {
        switch (type)
        {
            case Types.TileTypes.Empty:
                ZeroToFourWays(0, false, false, false, false, image, spriteArrays[0]);
                break;
            case Types.TileTypes.Start:
                ZeroToFourWays(1, upSideIsOpen, downSideIsOpen, leftSideIsOpen, rightSideIsOpen, image, spriteArrays[1]);
                break;
            case Types.TileTypes.Goal:
                ZeroToFourWays(1, upSideIsOpen, downSideIsOpen, leftSideIsOpen, rightSideIsOpen, image, spriteArrays[2]);
                break;
            case Types.TileTypes.Block:
                ZeroToFourWays(0, false, false, false, false, image, spriteArrays[3]);
                break;
            case Types.TileTypes.StaticConducter:
                ZeroToFourWays(ways, upSideIsOpen, downSideIsOpen, leftSideIsOpen, rightSideIsOpen, image, spriteArrays[4]);
                break;
            case Types.TileTypes.PlayerConducter:
                ZeroToFourWays(ways, upSideIsOpen, downSideIsOpen, leftSideIsOpen, rightSideIsOpen, image, spriteArrays[5]);
                break;
            case Types.TileTypes.Button:
                ZeroToFourWays(1, upSideIsOpen, downSideIsOpen, leftSideIsOpen, rightSideIsOpen, image, spriteArrays[6]);
                break;
            case Types.TileTypes.Gate:
                ZeroToFourWays(2, upSideIsOpen, downSideIsOpen, leftSideIsOpen, rightSideIsOpen, image, spriteArrays[7]);
                break;
            case Types.TileTypes.Detonator:
                ZeroToFourWays(1, upSideIsOpen, downSideIsOpen, leftSideIsOpen, rightSideIsOpen, image, spriteArrays[8]);
                break;
            case Types.TileTypes.BreakableBlock:
                ZeroToFourWays(0, false, false, false, false, image, spriteArrays[9]);
                break;

        }
    }

    public static void ZeroToFourWays(int ways, bool upSideIsOpen, bool downSideIsOpen, bool leftSideIsOpen, bool rightSideIsOpen, Image image, Sprite[] sprites)
    {
        switch (ways)
        {
            case 0:
                image.sprite = sprites[0];
                break;
            case 1:
                if (upSideIsOpen)
                {
                    image.sprite = sprites[1];
                }
                else if (downSideIsOpen)
                {
                    image.sprite = sprites[2];
                }
                else if (leftSideIsOpen)
                {
                    image.sprite = sprites[3];
                }
                else if (rightSideIsOpen)
                {
                    image.sprite = sprites[4];
                }
                break;
            case 2:
                if (upSideIsOpen && downSideIsOpen)
                {
                    image.sprite = sprites[5];
                }
                else if (upSideIsOpen && leftSideIsOpen)
                {
                    image.sprite = sprites[6];
                }
                else if (upSideIsOpen && rightSideIsOpen)
                {
                    image.sprite = sprites[7];
                }
                else if (downSideIsOpen && leftSideIsOpen)
                {
                    image.sprite = sprites[8];
                }
                else if (downSideIsOpen && rightSideIsOpen)
                {
                    image.sprite = sprites[9];
                }
                else if (leftSideIsOpen && rightSideIsOpen)
                {
                    image.sprite = sprites[10];
                }
                break;
            case 3:
                if (upSideIsOpen && downSideIsOpen && leftSideIsOpen)
                {
                    image.sprite = sprites[11];
                }
                else if (upSideIsOpen && downSideIsOpen && rightSideIsOpen)
                {
                    image.sprite = sprites[12];
                }
                else if (upSideIsOpen && leftSideIsOpen && rightSideIsOpen)
                {
                    image.sprite = sprites[13];
                }
                else if (downSideIsOpen && leftSideIsOpen && rightSideIsOpen)
                {
                    image.sprite = sprites[14];
                }
                break;
            case 4:
                image.sprite = sprites[15];
                break;
        }
    }
}
