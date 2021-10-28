using UnityEngine;

public class FinishTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.TryGetComponent(out InputController input))
        {
            input.enabled = false;
            LevelProgressManager.instance.DisableUIBar();
            UIManager.instance.CheckGameState(true);
        }
    }
}
