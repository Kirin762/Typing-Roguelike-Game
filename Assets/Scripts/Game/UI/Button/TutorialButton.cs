using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialButton : TransitionButton<TutorialButton>
{
    TutorialButton(Scene scene) : base(scene) { }

    private void Awake()
    {
        this.scene = Scene.TutorialScene;
    }
}
