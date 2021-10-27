using UnityEngine;

public class TouchController : MonoBehaviour
{
    private Touch _touch;
    private readonly float _dragTouchSpeed = 0.01f;
    [SerializeField] private float _playerSpeed;
    
    private void Update()
    {
        if(Input.touchCount > 0)
        {
            _touch = Input.GetTouch(0);

            switch (_touch.phase)
            {
                case TouchPhase.Stationary:
                //Бежим вперед
                transform.position += Vector3.forward * Time.deltaTime * _playerSpeed;
                Debug.Log("st");
                break;
                case TouchPhase.Moved:
                //Свайпаем управление
                transform.position = new Vector3(transform.position.x + _touch.deltaPosition.x * _dragTouchSpeed,transform.position.y,transform.position.z);
                Debug.Log("mv");
                break;
                case TouchPhase.Ended:
                //Стоим на месте
                //transform.position = Vector3.zero;
                Debug.Log("end");
                break;
            }

        }
    }
}
