using UnityEngine;

public class ObjectRotator : MonoBehaviour
{
    [Header("Set rotation speed here")]
    [Range(0.05f,1f)] [SerializeField] private float _rotationSpeed = 0.5f;

    private void Update()
    {
        transform.Rotate(0, _rotationSpeed, 0 ,Space.World);
    }
}
