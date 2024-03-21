using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float speed;
    private float oldMousePositionX;
    private float eulerY; // ���� ��������
    [SerializeField] private Animator animator;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            oldMousePositionX = Input.mousePosition.x;
            animator.SetBool("Running", true);   // ��������� �������� ����
        }

        if (Input.GetMouseButton(0))
        {
            Vector3 newPosition = transform.position + transform.forward * speed * Time.deltaTime;
            newPosition.x = Mathf.Clamp(newPosition.x, -2.5f, 2.5f); // ����������� ������
            transform.position = newPosition;

            float deltaX = Input.mousePosition.x - oldMousePositionX;
            oldMousePositionX = Input.mousePosition.x;

            eulerY += deltaX;
            eulerY = Mathf.Clamp(eulerY, -70, 70);   // ����������� �������� ��������� (�� -70 � �� 70 ��������)
            transform.eulerAngles = new Vector3(0, eulerY, 0);
        }

        if (Input.GetMouseButtonUp(0))
        {
            animator.SetBool("Running", false);      // ���������� �������� ����
        }
        
    }
}
