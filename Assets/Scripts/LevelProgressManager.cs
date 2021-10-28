using UnityEngine;
using UnityEngine.UI;

public class LevelProgressManager : MonoBehaviour
{
   public static LevelProgressManager instance;

   private Slider _sliderFillBar;

   [Header ("Player & Endline transform")]
   [SerializeField] private Transform _playerTransform;
   [SerializeField] private Transform _endLineTransform;
   private Vector3 _endLinePosition; //Vector3 of Endline transform
   private float _fullDistance; //distance between the player & finish line

   private void Awake()
   {
      instance = this;

      _sliderFillBar = transform.GetChild(0).GetComponent<Slider>();

      _endLinePosition = _endLineTransform.position;
      _fullDistance = GetDistance();
   }

   private void Update()
   {
      // check if the player doesn't pass the End Line
      if(_playerTransform.position.z <= _endLinePosition.z)
      {
         float newDistance = GetDistance();
         float progressValue = Mathf.InverseLerp(_fullDistance, 0f, newDistance);

         UpdateProgressFill(progressValue);
      }
   }

   private float GetDistance()
   {
      //return Vector3.Distance(playerTransform.position, endLinePosition); // Slow
      return (_endLinePosition - _playerTransform.position).sqrMagnitude;   // Fast
   }

   private void UpdateProgressFill(float fillValue)
   {
      _sliderFillBar.value = fillValue;
   }

   ///<summary>Disables game progress UI bar</summary>
   public void DisableUIBar()
   {
      _sliderFillBar.gameObject.SetActive(false);
   }
}