using UnityEngine;

public class ScaleBehaviour : MonoBehaviour, IAnimateBehaviour
{
    private float angle;
    public void Animate()
    {
        transform.localScale = 
            Mathf.Abs(Mathf.Cos(angle)) * Vector3.one;
        angle += 5f * Time.deltaTime;
    }
   
}
