using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class TileManager : MonoBehaviour
{
    public Tiles[] tiles;
    System.Random random = new System.Random();
    
    // Start is called before the first frame update
    void Start()
    {
        BuildField();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (tiles[detonatorId].isCharged && tiles[breakableBlockId].tileType != Types.TileTypes.Goal)
        {
            tiles[breakableBlockId].tileType = Types.TileTypes.Goal;
        }
        */
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

        int breakableBlockId = startId;

        while (breakableBlockId == startId || breakableBlockId == detonatorId)
        {
            breakableBlockId = random.Next(0, 44);
        }
        tiles[breakableBlockId].tileType = Types.TileTypes.BreakableBlock;

        SpriteManager.BuildSprite(tiles[breakableBlockId].tileType, 0, false, false, false, false, tiles[breakableBlockId].sprites, tiles[breakableBlockId].image, false);
    }
}
