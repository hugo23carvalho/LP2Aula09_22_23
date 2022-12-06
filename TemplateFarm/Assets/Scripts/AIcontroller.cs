using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIcontroller : MonoBehaviour
{
   private IEnumerable<AnimalsAI> animalsAIs;

    private IEnumerator TakeTurns()
    {
        YieldInstruction wfs = new WaitForSeconds(2);

        while (true)
        {
            foreach (AnimalsAI ai in animalsAIs)
            {
                ai.TakeTurn();
            }
            yield return wfs;
        }
    }

    private void Awake()
    {
        animalsAIs = new List<AnimalsAI>() { new SheepsAI(), new WolvesAI() };
    }

    private void Start()
    {
        StartCoroutine(TakeTurns());
    }
}
