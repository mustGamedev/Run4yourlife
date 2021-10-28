using UnityEngine;

public class InputController : MonoBehaviour
{
    [Header("Movement settings")]
    [Range(1f,20f)] [SerializeField] private float _movementSpeed = 7f;
    [Range(40f,200f)] [SerializeField] private float _mouseDragSpeed = 100f;

    [Header("Touch settings")]
    [SerializeField] private bool isTouching;
    private float _touchPositionX;
    private Animator _playerAnimator;

    private void Awake()
    {
        _playerAnimator = GetComponent<Animator>();
    }

    private void Update()
    {
        GetInput();
    }

    private void FixedUpdate()
    {
        if(isTouching == true)
        {
            _touchPositionX += Input.GetAxis("Mouse X") * _mouseDragSpeed *Time.fixedDeltaTime;
            transform.position += Vector3.forward * _movementSpeed * Time.fixedDeltaTime;
            _playerAnimator.SetBool("isRunning",true);
        }
        else
        {
            _playerAnimator.SetBool("isRunning",false);
        }
        transform.position = new Vector3(_touchPositionX, transform.position.y, transform.position.z);
    }

    private void GetInput()
    {
        if(Input.GetMouseButton(0))
        {
            isTouching=true;
        }
        else
        {
            isTouching=false;
        }
    }
}
