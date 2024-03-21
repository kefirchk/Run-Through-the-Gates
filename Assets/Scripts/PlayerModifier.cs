using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModifier : MonoBehaviour
{
    [SerializeField] int width;
    [SerializeField] int height;

    float widthMultiplier = 0.0005f;
    float heightMultiplier = 0.01f;

    [SerializeField] Renderer renderer;

    [SerializeField] Transform topSpine;
    [SerializeField] Transform bottomSpine;

    [SerializeField] Transform colliderTransform;

    [SerializeField] AudioSource increaseSound;
    private void Start()
    {
        SetWidth(Progress.Instance.Width);
        SetHeight(Progress.Instance.Height);
    }

    void Update()
    {
        float offsetY = height * heightMultiplier + 0.17f;
        topSpine.position = bottomSpine.position + new Vector3(0, offsetY, 0);
        colliderTransform.localScale = new Vector3(1, 1 + height * 0.0055f, 1); //(1, 1.0f + height * heightMultiplier, 1);
    }

    public void AddWidth(int value)
    {
        width += value;
        UpdateWidth();
        increaseSound.Play();
    }

    public void AddHeight(int value)
    {
        height += value;
        increaseSound.Play();
    }

    public void SetWidth(int value)
    {
        width = value;
        UpdateWidth();
    }

    public void SetHeight(int value)
    {
        height = value;
    }

    public void HitBarrier(int damage)
    {
        if (height > 0)
            height -= damage;
        else if (width > 0) {
            width -= damage;
            UpdateWidth();
        } else {
            Die();
        }
    }

    void UpdateWidth()
    {
        renderer.material.SetFloat("_PushValue", width * widthMultiplier);
    }

    void Die()
    {
        FindObjectOfType<GameManager>().ShowFinishWindow();
        Destroy(gameObject);
    }
}
