using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITakeDamaged<T> where T : BaseUnitSystem // ���׸� Ÿ������ ������ Ÿ���� �Ǵ� �ϰ� ������ ȣ���ϴ� �������̽�
{
    void TakeDamage(T unit);
}

public interface ITakeRepair<T> where T : BaseUnitSystem
{

}
