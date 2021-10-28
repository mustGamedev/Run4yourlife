using UnityEngine;

public class FinishTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.TryGetComponent(out InputController input))
        {
            input.enabled = false;
            UIManager.instance.CheckGameState(true);
        }
    }
}
