using UnityEngine;

public class RotateBehaviour : MonoBehaviour, IAnimateBehaviour
{
    public void Animate()
    {
        transform.Rotate(Time.deltaTime * Vector3.one * 35f);
    }
}
