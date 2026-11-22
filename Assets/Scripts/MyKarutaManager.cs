using UnityEngine;
using TMPro;
using System.Diagnostics.Tracing;
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

    public void SetKu(int pos, string text)
    {
        if(pos == 0)
        {
            textUI1.text = text;
        }
        else if(pos == 1)
        {
            textUI2.text = text;
        }
        else
        {
            textUI3.text = text;
        }
    }
}
