using UnityEngine;


[CreateAssetMenu(fileName = "New Dialogue", menuName = "Dialogue")]
public class Dialogue: ScriptableObject{
    [TextArea(3, 10)]
    public string[] paragraphs;
}