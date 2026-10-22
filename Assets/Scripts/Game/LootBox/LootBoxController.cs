using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class LootBoxController : MonoBehaviour, IDamageable, IWordHolder
{
    private Animator animator;
    public WordController word { get; set; }
    public Vector3 wordOffset { get; set; }

    #region IDamageable

    public void OnHit()
    {
        animator.Play("OrkDeath");
    }

    public void SpawnWord()
    {
        word.text.text = WordList.Instance.RandomizeWord(this);                                 // Choose a word from the word pool using its index   
    }

    #endregion
}
