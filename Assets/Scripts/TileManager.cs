using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class TileManager : MonoBehaviour
{
    public Tiles[] tiles;
    System.Random random = new System.Random();

    public SceneSwitch sceneSwitch;

    int breakableBlockId;

    // Start is called before the first frame update
    void Start()
    {
        BuildField();
    }

    // Update is called once per frame
    void Update()
    {
        int width = 11;
        int height = tiles.Length / width;

        for (int i = 0; i < tiles.Length; i++)
        {
            if (tiles[i].tileType != Types.TileTypes.Empty)
            {
                bool shouldCharge = false;

                if (tiles[i].upSideIsOpen && (i - width) >= 0 && tiles[i - width].isCharged && tiles[i - width].downSideIsOpen)
                    shouldCharge = true;

                if (tiles[i].rightSideIsOpen && (i + 1) % width != 0 && tiles[i + 1].isCharged && tiles[i + 1].leftSideIsOpen)
                    shouldCharge = true;

                if (tiles[i].downSideIsOpen && (i + width) < tiles.Length && tiles[i + width].isCharged && tiles[i + width].upSideIsOpen)
                    shouldCharge = true;

                if (tiles[i].leftSideIsOpen && i % width != 0 && tiles[i - 1].isCharged && tiles[i - 1].rightSideIsOpen)
                    shouldCharge = true;

                if (shouldCharge)
                {
                    tiles[i].isCharged = true;
                    SpriteManager.BuildSprite(tiles[i].tileType, tiles[i].ways, tiles[i].upSideIsOpen, tiles[i].downSideIsOpen, tiles[i].leftSideIsOpen, tiles[i].rightSideIsOpen, tiles[i].sprites, tiles[i].image, tiles[i].isCharged);
                }
            }

            bool upSideIsValid = false;
            bool downSideIsValid = false;
            bool leftSideIsValid = false;
            bool rightSideIsValid = false;

            if (tiles[i].tileType == Types.TileTypes.Detonator && tiles[i].isCharged)
            {
                tiles[breakableBlockId].tileType = Types.TileTypes.Goal;

                if (breakableBlockId - 11 >= 0)
                {
                    upSideIsValid = true;
                }
                if (breakableBlockId + 11 <= 43)
                {
                    downSideIsValid = true;
                }
                if (breakableBlockId != 0 || breakableBlockId != 11 || breakableBlockId != 22 || breakableBlockId != 33)
                {
                    leftSideIsValid = true;
                }
                if (breakableBlockId != 10 || breakableBlockId != 21 || breakableBlockId != 32 || breakableBlockId != 43)
                {
                    rightSideIsValid = true;
                }

                
                while (!tiles[breakableBlockId].upSideIsOpen && !tiles[breakableBlockId].downSideIsOpen && !tiles[breakableBlockId].leftSideIsOpen && !tiles[breakableBlockId].rightSideIsOpen)
                {
                    int sideToOpen = random.Next(0, 4);

                    switch (sideToOpen)
                    {
                        case 0:
                            if (upSideIsValid)
                            {
                                tiles[breakableBlockId].upSideIsOpen = true;
                            }
                            break;
                        case 1:
                            if (downSideIsValid)
                            {
                                tiles[breakableBlockId].downSideIsOpen = true;
                            }
                            break;
                        case 2:
                            if (leftSideIsValid)
                            {
                                tiles[breakableBlockId].leftSideIsOpen = true;
                            }
                            break;
                        case 3:
                            if (rightSideIsValid)
                            {
                                tiles[breakableBlockId].rightSideIsOpen = true;
                            }
                            break;
                    }
                }

                SpriteManager.BuildSprite(tiles[breakableBlockId].tileType, 1, tiles[breakableBlockId].upSideIsOpen, tiles[breakableBlockId].downSideIsOpen, tiles[breakableBlockId].leftSideIsOpen, tiles[breakableBlockId].rightSideIsOpen, tiles[breakableBlockId].sprites, tiles[breakableBlockId].image, tiles[breakableBlockId].isCharged);
            }

            if (tiles[i].tileType == Types.TileTypes.Goal && tiles[i].isCharged)
            {
                sceneSwitch.switchToEnd();
            }
        }
    }

    public void BuildField()
    {
        foreach (Tiles tile in tiles)
        {
            tile.tileType = Types.TileTypes.Empty;
            SpriteManager.BuildSprite(tile.tileType, 0, false, false, false, false, tile.sprites, tile.image, false);
        }

        int startId = random.Next(0, 44);
        tiles[startId].tileType = Types.TileTypes.Start;
        tiles[startId].isCharged = true;

        int openSideOfStart = random.Next(0, 4);

        switch (openSideOfStart)
        {
            case 0:
                tiles[startId].upSideIsOpen = true;
                break;
            case 1:
                tiles[startId].downSideIsOpen = true;
                break;
            case 2:
                tiles[startId].leftSideIsOpen = true;
                break;
            case 3:
                tiles[startId].rightSideIsOpen = true;
                break;

        }

        SpriteManager.BuildSprite(tiles[startId].tileType, 1, tiles[startId].upSideIsOpen, tiles[startId].downSideIsOpen, tiles[startId].leftSideIsOpen, tiles[startId].rightSideIsOpen, tiles[startId].sprites, tiles[startId].image, true);

        int detonatorId = startId;

        while (detonatorId == startId)
        {
            detonatorId = random.Next(0, 44);
        }
        tiles[detonatorId].tileType = Types.TileTypes.Detonator;

        int openSideOfDetonator = random.Next(0, 4);


        switch (openSideOfDetonator)
        {
            case 0:
                tiles[detonatorId].upSideIsOpen = true;
                break;
            case 1:
                tiles[detonatorId].downSideIsOpen = true;
                break;
            case 2:
                tiles[detonatorId].leftSideIsOpen = true;
                break;
            case 3:
                tiles[detonatorId].rightSideIsOpen = true;
                break;

        }

        SpriteManager.BuildSprite(tiles[detonatorId].tileType, 1, tiles[detonatorId].upSideIsOpen, tiles[detonatorId].downSideIsOpen, tiles[detonatorId].leftSideIsOpen, tiles[detonatorId].rightSideIsOpen, tiles[detonatorId].sprites, tiles[detonatorId].image, false);

        breakableBlockId = startId;

        while (breakableBlockId == startId || breakableBlockId == detonatorId)
        {
            breakableBlockId = random.Next(0, 44);
        }
        tiles[breakableBlockId].tileType = Types.TileTypes.BreakableBlock;

        SpriteManager.BuildSprite(tiles[breakableBlockId].tileType, 0, false, false, false, false, tiles[breakableBlockId].sprites, tiles[breakableBlockId].image, false);
    }
}
