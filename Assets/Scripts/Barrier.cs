using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour
{
    [SerializeField] GameObject bricksEffectPrefab;
    private void OnTriggerEnter(Collider other)
    {
        PlayerModifier playerModifier = other.attachedRigidbody.GetComponent<PlayerModifier>();
        if (playerModifier)
        {
            playerModifier.HitBarrier(50);
            Destroy(gameObject);
            Instantiate(bricksEffectPrefab, transform.position, transform.rotation);
        }
    }
}
