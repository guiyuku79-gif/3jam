using UnityEngine;
using TMPro;
public class MyKarutaManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textUI1; 
    [SerializeField] TextMeshProUGUI textUI2; 
    [SerializeField] TextMeshProUGUI textUI3;
    [SerializeField] Vector3 initPos;

    public void Init()
    {
        textUI1.text = "";
        textUI2.text = "";
        textUI3.text = "";

        transform.position = initPos;
    } 
}
