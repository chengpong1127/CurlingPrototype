// using UnityEngine;
// using UnityEngine.UI;
// using System.Collections;
// using TMPro;
// public class TextAnimation : MonoBehaviour
// {
//     public TextMeshProUGUI textObject;

//     void Start()
//     {
//         textObject.rectTransform.anchoredPosition = new Vector2(0, 100);
//         LeanTween.move(textObject.rectTransform, new Vector2(0, 25), 0.5f)
//             .setEase(LeanTweenType.easeOutQuad);
//     }
// }