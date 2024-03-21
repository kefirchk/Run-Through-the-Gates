using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField] PlayerMove playerMove;
    [SerializeField] PreFinishBehaviour preFinishBehaviour;
    [SerializeField] Animator animator;
    void Start()
    {
        playerMove.enabled = false;
        preFinishBehaviour.enabled = false;
    }

    public void Play()
    {
        playerMove.enabled = true;
    }

    public void StartPreFinishBehaviour()
    {
        playerMove.enabled = false;
        preFinishBehaviour.enabled = true;
    }

    public void StartFinishBehaviour()
    {
        preFinishBehaviour.enabled = false;
        animator.SetTrigger("House Dancing");
    }
}
