using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreFinishBehaviour : MonoBehaviour
{
    [SerializeField] float speedX = 2f;
    [SerializeField] float speedZ = 3f;
    [SerializeField] float rotSpeed = 60f;
    void Update()
    {
        // ѕозици€ X постепенно мен€етс€ от текущего значени€ до 0
        float x = Mathf.MoveTowards(transform.position.x, 0, Time.deltaTime * speedX);
        float z = transform.transform.position.z + speedZ * Time.deltaTime;
        transform.position = new Vector3(x, 0, z);

        // ѕоворот по Y постепенно мен€етс€ от текущего значени€ до 0
        float rot = Mathf.MoveTowardsAngle(transform.eulerAngles.y, 0, Time.deltaTime * rotSpeed);
        transform.localEulerAngles = new Vector3(0, rot, 0);
    }
}
