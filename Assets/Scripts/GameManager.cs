using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject karutaPrefab;

    public List<KuData> KuList = new();

    void Start()
    {
        SetUp();
    }

    void SetUp()
    {
        KuData text1 = SenryuData.GetRandomSentence(5);
        KuData text2 = SenryuData.GetRandomSentence(7);
        KuData text3 = SenryuData.GetRandomSentence(5);

        GameObject prefab = Instantiate(karutaPrefab);
        prefab.GetComponent<KarutaManager>().Init(text1.name,text2.name,text3.name);

        KuList = new List<KuData>{text1,text2,text3};
    }
}
