using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartButton : TransitionButton
{
    RestartButton(Scene scene) : base(scene) { }

    private void Awake()
    {
        this.scene = Scene.GameScene;
    }

    public override void OnClick()
    {
        base.OnClick();
        MenuController.Instance.OnRestart();
    }
}
