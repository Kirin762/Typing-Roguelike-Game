using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum Scene
{
    GameScene = 1,
    SettingScene = 2
}

public class TransitionButton<T> : MonoBehaviour, IButton where T : MonoBehaviour, IButton
{
    public Scene scene;

    public TransitionButton(Scene scene) { this.scene = scene; }

    public virtual void OnClick()
    {
        SceneManager.LoadScene((int)scene);
    }
}
