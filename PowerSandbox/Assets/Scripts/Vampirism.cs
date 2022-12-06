using UnityEngine;

public class Vampirism : Superpower
{

    [SerializeField]
   private float health;

   private float damage;

   public override void Activate()
    {
        Heal(health);
        DealDamage(damage);
    }
}
