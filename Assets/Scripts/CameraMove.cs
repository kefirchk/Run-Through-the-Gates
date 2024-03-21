using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] private Transform target;  // цель, за которой следует камера (игрок)

    private void Start()
    {
        transform.parent = null;
    }
    void LateUpdate()
    {
        if (target)
            transform.position = target.position;
    }
}
