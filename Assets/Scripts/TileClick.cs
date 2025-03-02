using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class TileClick : MonoBehaviour
{
    public FunctionsButtons buttonManager;
    public Tiles tile;
    public void CreateConducter()
    {
        if (tile.tileType == Types.TileTypes.Empty)
        {
            if (buttonManager.lineSelected)
            {
                if (buttonManager.isUpDown)
                {
                    tile.tileType = Types.TileTypes.PlayerConducter;
                    tile.upSideIsOpen = true;
                    tile.downSideIsOpen = true;
                    SpriteManager.BuildSprite(tile.tileType, 2, true, true, false, false, tile.sprites, tile.image, false);
                }
                else if (buttonManager.isLeftRight)
                {
                    tile.tileType = Types.TileTypes.PlayerConducter;
                    tile.leftSideIsOpen = true;
                    tile.rightSideIsOpen = true;
                    SpriteManager.BuildSprite(tile.tileType, 2, false, false, true, true, tile.sprites, tile.image, false);
                }
            }
            else if (buttonManager.cornerSelected) 
            {
                if (buttonManager.isUpLeft)
                {
                    tile.tileType = Types.TileTypes.PlayerConducter;
                    tile.upSideIsOpen = true;
                    tile.leftSideIsOpen = true;
                    SpriteManager.BuildSprite(tile.tileType, 2, true, false, true, false, tile.sprites, tile.image, false);
                }
                else if (buttonManager.isUpRight)
                {
                    tile.tileType = Types.TileTypes.PlayerConducter;
                    tile.upSideIsOpen = true;
                    tile.rightSideIsOpen = true;
                    SpriteManager.BuildSprite(tile.tileType, 2, true, false, false, true, tile.sprites, tile.image, false);
                }
                else if (buttonManager.isDownRight)
                {
                    tile.tileType = Types.TileTypes.PlayerConducter;
                    tile.downSideIsOpen = true;
                    tile.rightSideIsOpen = true;
                    SpriteManager.BuildSprite(tile.tileType, 2, false, true, false, true, tile.sprites, tile.image, false);
                }
                else if (buttonManager.isDownLeft)
                {
                    tile.tileType = Types.TileTypes.PlayerConducter;
                    tile.downSideIsOpen = true;
                    tile.leftSideIsOpen = true;
                    SpriteManager.BuildSprite(tile.tileType, 2, false, true, true, false, tile.sprites, tile.image, false);
                }
            }
            else if (buttonManager.tSelected)
            {
                if (buttonManager.isUpDownLeft)
                {
                    tile.tileType = Types.TileTypes.PlayerConducter;
                    tile.upSideIsOpen = true;
                    tile.downSideIsOpen = true;
                    tile.leftSideIsOpen = true;
                    SpriteManager.BuildSprite(tile.tileType, 3, true, true, true, false, tile.sprites, tile.image, false);
                }
                else if (buttonManager.isUpLeftRight)
                {
                    tile.tileType = Types.TileTypes.PlayerConducter;
                    tile.upSideIsOpen = true;
                    tile.leftSideIsOpen = true;
                    tile.rightSideIsOpen = true;
                    SpriteManager.BuildSprite(tile.tileType, 3, true, false, true, true, tile.sprites, tile.image, false);
                }
                else if (buttonManager.isUpDownRight)
                {
                    tile.tileType = Types.TileTypes.PlayerConducter;
                    tile.upSideIsOpen = true;
                    tile.downSideIsOpen = true;
                    tile.rightSideIsOpen = true;
                    SpriteManager.BuildSprite(tile.tileType, 3, true, true, false, true, tile.sprites, tile.image, false);
                }
                else if (buttonManager.isDownLeftRight)
                {
                    tile.tileType = Types.TileTypes.PlayerConducter;
                    tile.downSideIsOpen = true;
                    tile.leftSideIsOpen = true;
                    tile.rightSideIsOpen = true;
                    SpriteManager.BuildSprite(tile.tileType, 3, false, true, true, true, tile.sprites, tile.image, false);
                }
            }
            else if (buttonManager.crossSelected) 
            {
                tile.tileType = Types.TileTypes.PlayerConducter;
                tile.upSideIsOpen = true;
                tile.downSideIsOpen = true;
                tile.leftSideIsOpen = true;
                tile.rightSideIsOpen = true;
                SpriteManager.BuildSprite(tile.tileType, 4, true, true, true, true, tile.sprites, tile.image, false);
            }
        }
    }
}
