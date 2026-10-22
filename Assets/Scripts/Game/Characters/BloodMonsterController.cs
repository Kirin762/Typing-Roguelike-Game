using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodMonsterController : EnemyBase
{
    public override void OnDeath()
    {
        animator.Play("BloodMonsterDeath");
        base.OnDeath();
    }
}
