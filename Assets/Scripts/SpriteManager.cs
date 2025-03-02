using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;
using UnityEngine.UI;

public class SpriteManager : MonoBehaviour
{
    public static void BuildSprite(Types.TileTypes type, int ways, bool upSideIsOpen, bool downSideIsOpen, bool leftSideIsOpen, bool rightSideIsOpen, Sprite[] sprites, Image image, bool isCharged)
    {
        switch (type)
        {
            case Types.TileTypes.Empty:
                Sprite[] spriteArrayEmptyTile = { sprites[0] };
                ZeroToFourWays(0, false, false, false, false, image, spriteArrayEmptyTile);
                break;
            case Types.TileTypes.Start:
                Sprite[] spriteArrayStart = { null, sprites[1], sprites[2], sprites[3], sprites[4] };
                ZeroToFourWays(1, upSideIsOpen, downSideIsOpen, leftSideIsOpen, rightSideIsOpen, image, spriteArrayStart);
                break;
            case Types.TileTypes.Goal:
                if (!isCharged)
                {
                    Sprite[] spriteArrayGoalNotCharged = { null, sprites[5], sprites[6], sprites[7], sprites[8] };
                    ZeroToFourWays(1, upSideIsOpen, downSideIsOpen, leftSideIsOpen, rightSideIsOpen, image, spriteArrayGoalNotCharged);
                }
                else
                {
                    Sprite[] spriteArrayGoalCharged = { null, sprites[9], sprites[10], sprites[11], sprites[12] };
                    ZeroToFourWays(1, upSideIsOpen, downSideIsOpen, leftSideIsOpen, rightSideIsOpen, image, spriteArrayGoalCharged);
                }
                break;
            case Types.TileTypes.PlayerConducter:
                if (!isCharged)
                {
                    Sprite[] spriteArrayPlayerConducterNotCharged = { null, null, null, null, null, sprites[13], sprites[14], sprites[15], sprites[16], sprites[17], sprites[18], sprites[19], sprites[20], sprites[21], sprites[22], sprites[23] };
                    ZeroToFourWays(ways, upSideIsOpen, downSideIsOpen, leftSideIsOpen, rightSideIsOpen, image, spriteArrayPlayerConducterNotCharged);
                }
                else
                {
                    Sprite[] spriteArrayPlayerConducterCharged = { null, null, null, null, null, sprites[24], sprites[25], sprites[26], sprites[27], sprites[28], sprites[29], sprites[30], sprites[31], sprites[32], sprites[33], sprites[34] };
                    ZeroToFourWays(ways, upSideIsOpen, downSideIsOpen, leftSideIsOpen, rightSideIsOpen, image, spriteArrayPlayerConducterCharged);
                }
                break;
            case Types.TileTypes.Detonator:
                if (!isCharged)
                {
                    Sprite[] spriteArrayDetonatorNotCharged = { null, sprites[35], sprites[36], sprites[37], sprites[38] };
                    ZeroToFourWays(1, upSideIsOpen, downSideIsOpen, leftSideIsOpen, rightSideIsOpen, image, spriteArrayDetonatorNotCharged);
                }
                else
                {
                    Sprite[] spriteArrayDetonatorCharged = { null, sprites[39], sprites[40], sprites[41], sprites[42] };
                    ZeroToFourWays(1, upSideIsOpen, downSideIsOpen, leftSideIsOpen, rightSideIsOpen, image, spriteArrayDetonatorCharged);
                }
                break;
            case Types.TileTypes.BreakableBlock:
                Sprite[] spriteArrayBreakableBlockTile = { sprites[43] };
                ZeroToFourWays(0, false, false, false, false, image, spriteArrayBreakableBlockTile);
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
