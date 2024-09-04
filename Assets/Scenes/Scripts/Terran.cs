using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Terran : BaseUnitSystem, ITakeDamaged<BaseUnitSystem>
{

    public Terran(int health, int damage, int defensive, float attackSpeed, float range, float createTime, int moveSpeed, UnitType unitType, AttackType attackType) : base(health, damage, defensive, attackSpeed, range, createTime, moveSpeed, unitType, attackType)
    {

    }

    public Terran(int health, int damage, int defensive, float attackSpeed, float range, float createTime, int moveSpeed, UnitType unitType, AttackType attackType, AttackType2 attackType2) : base(health, damage, defensive, attackSpeed, range, createTime, moveSpeed, unitType, attackType, attackType2)
    {

    }
}
