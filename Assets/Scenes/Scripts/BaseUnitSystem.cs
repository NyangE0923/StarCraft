using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

#region ������ Ÿ�԰� ���� ���� Ÿ��
public enum UnitType { GROUND, AIR}
public enum AttackType { GROUND, AIR}
public enum AttackType2 { GROUND, AIR}
#endregion

public abstract class BaseUnitSystem : MonoBehaviour // �߻�Ŭ���� : ���̽� ���� �ý����� �ش� Ŭ���������� ������ �ȵǵ��� ���´�.
{
    protected int health;             // ������ ü��
    protected int damage;             // ������ ���ݷ�
    protected int defensive;          // ������ ����
    protected int moveSpeed;          // ������ �̵��ӵ�
    protected float attackSpeed;      // ������ ���ݼӵ�
    protected float range;            // ������ ��Ÿ�
    protected float createTime;       // ������ ���� �ð�
    protected UnitType unitType;      // ������ Ÿ��
    protected AttackType attackType;  // ������ ���� Ÿ��
    protected AttackType2 attackType2;// ������ ���� Ÿ�� 2

    #region ���̽� ���� ������
    // �����ε带 ���� ����Ÿ���� 1���� ���ְ� 2���� ������ ����
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

    #region ������Ƽ
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
            // ��� �޼ҵ� ȣ��
            Destroy(gameObject);
        }
    }

    //�������̽�?, ENUMŸ���� ���׸����� �����ѵ� �������̽��� �����ϰ� ������ ���� GetDamage�� ȣ�� �� �� �ִ����� ���� ����(���� ���� ������ ���߸�, ���� ���� Ÿ���� ����)
}
