using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] GameObject collectCoinEffectPrefab;
    [SerializeField] private float rotateSpeedY = 180;
    
    void Update()
    {
        transform.Rotate(0, rotateSpeedY * Time.deltaTime, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<CoinManager>().AddOne();
        Destroy(gameObject);
        Instantiate(collectCoinEffectPrefab, transform.position, transform.rotation);
    }
}
