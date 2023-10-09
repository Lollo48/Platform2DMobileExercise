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
    public ButtonManager AttackButton;

    public PlayerInputManager(ButtonManager Left, ButtonManager Right, ButtonManager Attack)
    {
        LeftButton = Left;
        RightButton = Right;
        AttackButton = Attack;
    }

}
