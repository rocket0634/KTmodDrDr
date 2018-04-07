﻿using System;
using System.Collections.Generic;
using System.Linq;
using BlindAlley;
using UnityEngine;
using Rnd = UnityEngine.Random;

/// <summary>
/// On the Subject of Dr. Doctor
/// Created by ligio90
/// </summary>
public class DrDoctorModule : MonoBehaviour
{
    public KMBombInfo Bomb;
    public KMBombModule Module;
    public KMAudio Audio;

    public KMSelectable CubeSolveButton;
    public KMSelectable Caduceus;

    private static int _moduleIdCounter = 1;
    private int _moduleId;

    private bool _isCaduceusShown;

    void Start()
    {
        _moduleId = _moduleIdCounter++;

        Module.OnActivate += ActivateModule;
        CubeSolveButton.OnInteract += ButtonPressed;
        Caduceus.OnInteract += CaduceusPressed;
    }

    private bool CaduceusPressed()
    {
        LogMessage("You clicked on the wrong button aka. the caduceus. You're welcome!");
        Module.HandleStrike();


        return false;
    }

    private bool ButtonPressed()
    {
        LogMessage("You clicked on the button.");
        Module.HandlePass();


        return false;
    }

    void ActivateModule()
    {
    }

    void LogMessage(string message)
    {
        Debug.LogFormat("[Dr. Doctor #{0}] {1}", _moduleId, message);
    }

    //#pragma warning disable 414
    //    private string TwitchHelpMessage = @"Hit the correct spots with “!{0} press bl mm tm tl”. (Locations are tl, tm, ml, mm, mr, bl, bm, br.)";
    //#pragma warning restore 414

    //    KMSelectable[] ProcessTwitchCommand(string command)
    //    {
    //    }
}