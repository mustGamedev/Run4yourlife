using System.Collections;
using UnityEngine;

public class CoinPickUp : MonoBehaviour
{
    private ParticleSystem _particleCoin;
    private GameObject _coinPrefabChild;
    private bool isTouched;

    private void Awake()
    {
        _particleCoin = GetComponent<ParticleSystem>();
        _coinPrefabChild = transform.GetChild(0).gameObject;
    }
    
    private void OnTriggerEnter(Collider collider) 
    {
        if(collider.gameObject.tag == "Player" && isTouched == false)
        {
            MoneyManager.instance.AddMoney(1);
            StartCoroutine(EmittUntillDestroy());
            isTouched = true;
        }
    }

    IEnumerator EmittUntillDestroy()
    {
        _coinPrefabChild.SetActive(false);
        _particleCoin.Play();
        yield return new WaitForSeconds(1.5f);
        Destroy(this.gameObject);
    } 
}
