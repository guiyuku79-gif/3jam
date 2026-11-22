using UnityEngine;
using TMPro;

public class KarutaManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textUI1; 
    [SerializeField] TextMeshProUGUI textUI2; 
    [SerializeField] TextMeshProUGUI textUI3;
    [SerializeField] Vector3 initPos;

    public void Init(string text1, string text2, string text3)
    {
        textUI1.text = text1;
        textUI2.text = text2;
        textUI3.text = text3;

        transform.position = initPos;
    } 
}
