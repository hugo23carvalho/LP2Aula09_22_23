using UnityEngine;

public class SheepsAI : AnimalsAI
{
    protected override void Move()
    {
        Debug.Log("Sheep moved");
    }
    protected override void TryEat()
    {
        Debug.Log("Wolves tried to eat");
    }
    protected override void TryReproduce()
    {
        Debug.Log("Wolves tried to reproduce");
    }
}
