using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IWordHolder
{
    public WordController word { get; set; }
    public Vector3 wordOffset { get; set; }

    void SpawnWord();
}
