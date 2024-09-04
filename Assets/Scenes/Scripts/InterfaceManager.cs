using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITakeDamaged<T> where T : BaseUnitSystem // 제네릭 타입으로 유닛의 타입을 판단 하고 공격을 호출하는 인터페이스
{
    void TakeDamage(T unit);
}

public interface ITakeRepair<T> where T : BaseUnitSystem
{

}
