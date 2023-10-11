using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

[System.Serializable]
public class PlayerInputManager 
{


    public ButtonManager LeftButton;
    public ButtonManager RightButton;
    

    public PlayerInputManager(ButtonManager Left, ButtonManager Right)
    {
        LeftButton = Left;
        RightButton = Right;
        
    }

}


public enum Direction
{
    Left,
    Right
}