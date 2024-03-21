using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public enum DeformationType {
    Width,
    Height
}


public class GateAppearance : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;

    [SerializeField] Image topImage;
    [SerializeField] Image glassImage;

    [SerializeField] Color colorPositive;
    [SerializeField] Color colorNegative;

    // »конки увеличени€/уменьшени€ ширины
    [SerializeField] GameObject expandLabel;
    [SerializeField] GameObject shrinkLabel;

    // »конки увеличени€/уменьшени€ высоты
    [SerializeField] GameObject upLabel;
    [SerializeField] GameObject downLabel;

    public void UpdateVisual(DeformationType deformationType, int value)
    {
        string prefix = "";

        if (value > 0) {
            prefix = "+";
            SetColor(colorPositive);
        } else if (value == 0) {
            SetColor(Color.grey);
        } else {
            SetColor(colorNegative);
        }
        text.text = prefix + value.ToString();

        expandLabel.SetActive(false);
        shrinkLabel.SetActive(false);
        upLabel.SetActive(false);
        downLabel.SetActive(false);

        switch(deformationType)
        {
            case DeformationType.Width:
                expandLabel.SetActive(value > 0);
                shrinkLabel.SetActive(value < 0);
                break;
            case DeformationType.Height:
                upLabel.SetActive(value > 0);
                downLabel.SetActive(value < 0);
            break;
        }
    }

    void SetColor(Color color)
    {
        topImage.color = color;
        glassImage.color = new Color(color.r, color.g, color.b, 0.5f);
    }
}
