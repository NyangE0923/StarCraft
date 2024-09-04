using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

#region 유닛의 타입과 공격 가능 타입
public enum UnitType { GROUND, AIR}
public enum AttackType { GROUND, AIR}
public enum AttackType2 { GROUND, AIR}
#endregion

public abstract class BaseUnitSystem : MonoBehaviour // 추상클래스 : 베이스 유닛 시스템은 해당 클래스만으로 생성이 안되도록 막는다.
{
    protected int health;             // 유닛의 체력
    protected int damage;             // 유닛의 공격력
    protected int defensive;          // 유닛의 방어력
    protected int moveSpeed;          // 유닛의 이동속도
    protected float attackSpeed;      // 유닛의 공격속도
    protected float range;            // 유닛의 사거리
    protected float createTime;       // 유닛의 생산 시간
    protected UnitType unitType;      // 유닛의 타입
    protected AttackType attackType;  // 유닛의 공격 타입
    protected AttackType2 attackType2;// 유닛의 공격 타입 2

    #region 베이스 유닛 생성자
    // 오버로드를 통한 공격타입이 1개인 유닛과 2개인 유닛을 구분
    public BaseUnitSystem(int health, int damage, int defensive, float attackSpeed, float range, float createTime, int moveSpeed, UnitType unitType, AttackType attackType)
    {
        Health = health;
        Damage = damage;
        Defensive = defensive;
        AttackSpeed = attackSpeed;
        Range = range;
        CreateTime = createTime;
        MoveSpeed = moveSpeed;

        this.unitType = unitType;
        this.attackType = attackType;
    }
    public BaseUnitSystem(int health, int damage, int defensive, float attackSpeed, float range, float createTime, int moveSpeed, UnitType unitType, AttackType attackType, AttackType2 attackType2)
    {
        Health = health;
        Damage = damage;
        Defensive = defensive;
        AttackSpeed = attackSpeed;
        Range = range;
        CreateTime = createTime;
        MoveSpeed = moveSpeed;

        this.unitType = unitType;
        this.attackType = attackType;
        this.attackType2 = attackType2;
    }
    #endregion

    #region 프로퍼티
    public int Health { get => health; set => health = value; }
    public int Damage { get => damage; set => damage = value; }
    public int Defensive { get => defensive; set => defensive = value; }
    public int MoveSpeed { get => moveSpeed; set => moveSpeed = value; }
    public float AttackSpeed { get => attackSpeed; set => attackSpeed = value; }
    public float Range { get => range; set => range = value;  }
    public float CreateTime { get => createTime; set => createTime = value; }
    #endregion

    public void TakeDamage(BaseUnitSystem unit)
    {
        if (Health > 0)
        {
            int totalDamage = damage - unit.Defensive;
            unit.Health -= totalDamage;
        }
        else
        {
            // 사망 메소드 호출
            Destroy(gameObject);
        }
    }

    //인터페이스?, ENUM타입을 제네릭으로 설정한뒤 인터페이스를 구현하고 판정에 따라 GetDamage를 호출 할 수 있는지에 대한 여부(공중 공격 판정은 공중만, 지상 공격 타입은 지상만)
}
