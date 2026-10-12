using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsButton : TransitionButton<OptionsButton>
{
    public OptionsButton(Scene scene) : base(scene) { }

    private void Awake()
    {
        scene = Scene.SettingScene;
    }
} 
