using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueButton : MonoBehaviour, IButton
{
    public void OnClick()
    {
        MenuController.Instance.OnContinue();
    }
}
