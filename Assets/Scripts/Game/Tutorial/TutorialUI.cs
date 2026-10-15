using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialUI : MonoBehaviour
{
    public Transform trigger;
    private Vector3 pos => Camera.main.WorldToScreenPoint(trigger.position);
    public Vector3 offSet;
    private void Update()
    {
        transform.position = pos + offSet;
    }
}
