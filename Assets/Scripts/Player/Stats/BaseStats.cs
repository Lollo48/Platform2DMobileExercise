using UnityEngine;

public abstract class BaseStats
{


    protected abstract void UpdateHealtPoint(float pointToAdd);
    protected abstract float GetHealtPoint();
    protected abstract float GetDefaultHealtPoint();

    protected abstract void GetDamage(float pointToAdd);
}
