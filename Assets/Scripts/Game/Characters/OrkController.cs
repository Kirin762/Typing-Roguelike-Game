using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrkController : EnemyBase
{
    public override void OnDeath()
    {
        animator.Play("OrkDeath");
        base.OnDeath();
    }
}
