using UnityEngine;

public class HealingFire : Superpower
{
    [SerializeField]

    private float health;

    public override void Activate()
    {
        Heal(health);
        LightMyFire();
    }
}
