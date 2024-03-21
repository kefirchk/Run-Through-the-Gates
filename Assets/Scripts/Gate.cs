using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    [SerializeField] int value;
    [SerializeField] DeformationType deformationType;
    [SerializeField] GateAppearance gateAppearance;

    private void OnValidate()
    {
        gateAppearance.UpdateVisual(deformationType, value);
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerModifier playerModifier = other.attachedRigidbody.GetComponent<PlayerModifier>();
        if (playerModifier)
        {
            switch (deformationType)
            {
                case DeformationType.Width: 
                    playerModifier.AddWidth(value); break;
                case DeformationType.Height:
                    playerModifier.AddHeight(value); break;
            }
            Destroy(gameObject);
        }
    }
}
