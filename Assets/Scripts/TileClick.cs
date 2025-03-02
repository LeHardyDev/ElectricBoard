using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileClick : MonoBehaviour
{
    public Tiles tile;
    public void CreateConducter()
    {
        if (tile.tileType == Types.TileTypes.Empty)
        {
            if (FunctionsButtons.instance.lineSelected)
            {
                if (FunctionsButtons.instance.isUpDown)
                {
                    tile.tileType = Types.TileTypes.PlayerConducter;
                    tile.ways = 2;
                    tile.upSideIsOpen = true;
                    tile.downSideIsOpen = true;
                    SpriteManager.BuildSprite(tile.tileType, 2, true, true, false, false, tile.sprites, tile.image, false);
                }
                else if (FunctionsButtons.instance.isLeftRight)
                {
                    tile.tileType = Types.TileTypes.PlayerConducter;
                    tile.ways = 2;
                    tile.leftSideIsOpen = true;
                    tile.rightSideIsOpen = true;
                    SpriteManager.BuildSprite(tile.tileType, 2, false, false, true, true, tile.sprites, tile.image, false);
                }
            }
            else if (FunctionsButtons.instance.cornerSelected) 
            {
                if (FunctionsButtons.instance.isUpLeft)
                {
                    tile.tileType = Types.TileTypes.PlayerConducter;
                    tile.ways = 2;
                    tile.upSideIsOpen = true;
                    tile.leftSideIsOpen = true;
                    SpriteManager.BuildSprite(tile.tileType, 2, true, false, true, false, tile.sprites, tile.image, false);
                }
                else if (FunctionsButtons.instance.isUpRight)
                {
                    tile.tileType = Types.TileTypes.PlayerConducter;
                    tile.ways = 2;
                    tile.upSideIsOpen = true;
                    tile.rightSideIsOpen = true;
                    SpriteManager.BuildSprite(tile.tileType, 2, true, false, false, true, tile.sprites, tile.image, false);
                }
                else if (FunctionsButtons.instance.isDownRight)
                {
                    tile.tileType = Types.TileTypes.PlayerConducter;
                    tile.ways = 2;
                    tile.downSideIsOpen = true;
                    tile.rightSideIsOpen = true;
                    SpriteManager.BuildSprite(tile.tileType, 2, false, true, false, true, tile.sprites, tile.image, false);
                }
                else if (FunctionsButtons.instance.isDownLeft)
                {
                    tile.tileType = Types.TileTypes.PlayerConducter;
                    tile.ways = 2;
                    tile.downSideIsOpen = true;
                    tile.leftSideIsOpen = true;
                    SpriteManager.BuildSprite(tile.tileType, 2, false, true, true, false, tile.sprites, tile.image, false);
                }
            }
            else if (FunctionsButtons.instance.tSelected)
            {
                if (FunctionsButtons.instance.isUpDownLeft)
                {
                    tile.tileType = Types.TileTypes.PlayerConducter;
                    tile.ways = 3;
                    tile.upSideIsOpen = true;
                    tile.downSideIsOpen = true;
                    tile.leftSideIsOpen = true;
                    SpriteManager.BuildSprite(tile.tileType, 3, true, true, true, false, tile.sprites, tile.image, false);
                }
                else if (FunctionsButtons.instance.isUpLeftRight)
                {
                    tile.tileType = Types.TileTypes.PlayerConducter;
                    tile.ways = 3;
                    tile.upSideIsOpen = true;
                    tile.leftSideIsOpen = true;
                    tile.rightSideIsOpen = true;
                    SpriteManager.BuildSprite(tile.tileType, 3, true, false, true, true, tile.sprites, tile.image, false);
                }
                else if (FunctionsButtons.instance.isUpDownRight)
                {
                    tile.tileType = Types.TileTypes.PlayerConducter;
                    tile.ways = 3;
                    tile.upSideIsOpen = true;
                    tile.downSideIsOpen = true;
                    tile.rightSideIsOpen = true;
                    SpriteManager.BuildSprite(tile.tileType, 3, true, true, false, true, tile.sprites, tile.image, false);
                }
                else if (FunctionsButtons.instance.isDownLeftRight)
                {
                    tile.tileType = Types.TileTypes.PlayerConducter;
                    tile.ways = 3;
                    tile.downSideIsOpen = true;
                    tile.leftSideIsOpen = true;
                    tile.rightSideIsOpen = true;
                    SpriteManager.BuildSprite(tile.tileType, 3, false, true, true, true, tile.sprites, tile.image, false);
                }
            }
            else if (FunctionsButtons.instance.crossSelected) 
            {
                tile.tileType = Types.TileTypes.PlayerConducter;
                tile.ways = 4;
                tile.upSideIsOpen = true;
                tile.downSideIsOpen = true;
                tile.leftSideIsOpen = true;
                tile.rightSideIsOpen = true;
                SpriteManager.BuildSprite(tile.tileType, 4, true, true, true, true, tile.sprites, tile.image, false);
            }
        }
    }
}
