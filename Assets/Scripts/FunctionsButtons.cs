using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FunctionsButtons : MonoBehaviour
{
    
    public bool lineSelected;
    public bool isUpDown;
    public bool isLeftRight;
    public bool cornerSelected;
    public bool isUpLeft;
    public bool isUpRight;
    public bool isDownLeft;
    public bool isDownRight;
    public bool tSelected;
    public bool isUpDownLeft;
    public bool isUpLeftRight;
    public bool isUpDownRight;
    public bool isDownLeftRight;
    public bool crossSelected;

    [Header("Images")]
    public Image buttonLine;
    public Image buttonCorner;
    public Image buttonT;
    public Image buttonCross;

    [Header("Sprites")]
    public Sprite lineSpriteUpDown;
    public Sprite lineSpriteLeftRight;
    public Sprite cornerSpriteUpLeft;
    public Sprite cornerSpriteUpRight;
    public Sprite cornerSpriteDownLeft;
    public Sprite cornerSpriteDownRight;
    public Sprite tSpriteUpDownLeft;
    public Sprite tSpriteUpLeftRight;
    public Sprite tSpriteUpDownRight;
    public Sprite tSpriteDownLeftRight;

    public void FunctionsButtonLine()
    {
        if (lineSelected)
        {
            if (isUpDown)
            {
                isUpDown = false;
                isLeftRight = true;
                buttonLine.sprite = lineSpriteLeftRight;
            }
            else if (isLeftRight)
            {
                isLeftRight = false;
                isUpDown = true;
                buttonLine.sprite = lineSpriteUpDown;
            }
        }
        else if (!lineSelected)
        {
            //Setting Button Sprite
            buttonLine.sprite = lineSpriteUpDown;
            buttonCorner.sprite = cornerSpriteUpRight;
            buttonT.sprite = tSpriteUpDownLeft;

            //Setting Button Bools
            lineSelected = true;
            cornerSelected = false;
            tSelected = false;
            crossSelected = false;

            //Setting Button Rotation Bools
            isUpDown = true;
            isUpLeft = false;
            isUpRight = false;
            isDownRight = false;
            isDownLeft = false;
            isUpDownLeft = false;
            isUpLeftRight = false;
            isUpDownRight = false;
            isDownLeftRight = false;

            
            //Setting Button Highlight
            buttonLine.color = Color.white;
            buttonCorner.color = Color.gray;
            buttonT.color = Color.gray;
            buttonCross.color = Color.gray;
        }
    }

    public void FunctionsButtonCorner()
    {
        if (cornerSelected)
        {
            if (isUpLeft)
            {
                isUpLeft = false;
                isUpRight = true;
                buttonCorner.sprite = cornerSpriteUpRight;
            }
            else if (isUpRight)
            {
                isUpRight = false;
                isDownRight = true;
                buttonCorner.sprite = cornerSpriteDownRight;
            }
            else if (isDownRight)
            {
                isDownRight = false;
                isDownLeft = true;
                buttonCorner.sprite = cornerSpriteDownLeft;
            }
            else if (isDownLeft)
            {
                isDownLeft = false;
                isUpLeft = true;
                buttonCorner.sprite = cornerSpriteUpLeft;
            }
        }
        else if (!cornerSelected)
        {
            //Setting Button Sprite
            buttonLine.sprite = lineSpriteUpDown;
            buttonCorner.sprite = cornerSpriteUpRight;
            buttonT.sprite = tSpriteUpDownLeft;

            // setting Button Bools
            lineSelected = false;
            tSelected = false;
            crossSelected = false;
            cornerSelected = true;
            
            // setting Button Rotation Bools
            isUpDown = false;
            isLeftRight = false;
            isUpLeft = true;
            
            //setting Button Highlight
            buttonLine.color = Color.gray;
            buttonCorner.color = Color.white;
            buttonT.color = Color.gray;
            buttonCross.color = Color.gray;
        }
    }

    public void FunctionsButtonT()
    {
        if (tSelected)
        {
            if (isUpDownLeft)
            {
                isUpDownLeft = false;
                isUpLeftRight = true;
                buttonT.sprite = tSpriteUpLeftRight;
            }
            else if (isUpLeftRight)
            {
                isUpLeftRight = false;
                isUpDownRight = true;
                buttonT.sprite = tSpriteUpDownRight;
            }
            else if (isUpDownRight)
            {
                isUpDownRight = false;
                isDownLeftRight = true;
                buttonT.sprite = tSpriteDownLeftRight;
            }
            else if (isDownLeftRight)
            {
                isDownLeftRight = false;
                isUpDownLeft = true;
                buttonT.sprite = tSpriteUpDownLeft;
            }
        }
        else if (!tSelected)
        {
            //Setting Button Sprite
            buttonLine.sprite = lineSpriteUpDown;
            buttonCorner.sprite = cornerSpriteUpRight;
            buttonT.sprite = tSpriteUpDownLeft;
            
            //Setting Button Bools
            lineSelected = false;
            cornerSelected = false;
            tSelected = true;
            crossSelected = false;

            //Setting Button Rotation Bools
            isUpDown = false;
            isLeftRight = false;
            isUpLeft = false;
            isUpRight = false;
            isDownRight = false;
            isDownLeft = false;
            isUpDownLeft = true;

            //Setting Button Highlight
            buttonLine.color = Color.grey;
            buttonCorner.color = Color.gray;
            buttonT.color = Color.white;
            buttonCross.color = Color.gray;
        }
    }

    public void FunctionsButtonCross()
    {
        if (!crossSelected)
        {
            //Setting Button Sprite
            buttonLine.sprite = lineSpriteUpDown;
            buttonCorner.sprite = cornerSpriteUpRight;
            buttonT.sprite = tSpriteUpDownLeft;

            //Setting Button Bools
            lineSelected = false;
            cornerSelected = false;
            tSelected = false;
            crossSelected = true;

            //Setting Button Rotation Bools
            isUpDown = false;
            isLeftRight = false;
            isUpLeft = false;
            isUpRight = false;
            isDownRight = false;
            isDownLeft = false;
            isUpDownLeft = false;
            isUpLeftRight = false;
            isUpDownRight = false;
            isDownLeftRight = false;

            //Setting Button Highlight
            buttonLine.color = Color.grey;
            buttonCorner.color = Color.gray;
            buttonT.color = Color.gray;
            buttonCross.color = Color.white;
        }
    }

}
