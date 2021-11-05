using UnityEngine;

public class ObjectRotator : MonoBehaviour
{
    [Header("Set rotation speed here")]
    [Range(1f,50f)] [SerializeField] private float _rotationSpeed = 10f;

    private void FixedUpdate()
    {
        transform.Rotate(0, _rotationSpeed*10 * Time.fixedDeltaTime, 0 ,Space.World);
    }
}
