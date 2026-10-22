using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemonController : EnemyBase
{
    public override void OnDeath()
    {
        animator.Play("DemonDeath");
        base.OnDeath();
    }
}
