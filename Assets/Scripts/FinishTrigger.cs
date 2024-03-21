using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishTrigger : MonoBehaviour
{
    [SerializeField] AudioSource finishSound;
    private void OnTriggerEnter(Collider other)
    {
        PlayerBehaviour playerBehaviour = other.attachedRigidbody.GetComponent<PlayerBehaviour>();
        if (playerBehaviour)
        {
            playerBehaviour.StartFinishBehaviour();
            FindObjectOfType<GameManager>().ShowFinishWindow();
            finishSound.Play();
        }
    }
}
