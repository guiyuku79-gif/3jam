using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject karutaPrefab;
    [SerializeField] GameObject OneKuPrefab;
    [SerializeField] GameObject MyKarutaPrefab;

    List<KuData> KuList = new();

    Dictionary<int,KuData> choiceDict = new Dictionary<int, KuData>();

    KarutaManager karutaManager;
    MyKarutaManager myKarutaManager;

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
        karutaManager = prefab.GetComponent<KarutaManager>();
        karutaManager.Init(text1.name,text2.name,text3.name);

        KuList = new List<KuData>{text1,text2,text3};

        var choiceList = SenryuData.GetRandomSentences(11);
        //選択肢を生成
        for (int i = 0; i < 11; i++)
        {
            KuData text = choiceList[i];
            
            GameObject oneKuPrefab = Instantiate(OneKuPrefab);
            oneKuPrefab.GetComponent<OneKuManager>().Init(text.name,i,OnObjectClicked);
            choiceDict.Add(i,text);
        }

        //プレイヤーが作るカルタを生成
        GameObject myKarutaPrefab = Instantiate(MyKarutaPrefab);
        myKarutaManager = myKarutaPrefab.GetComponent<MyKarutaManager>();
        myKarutaManager.Init();
        
    }

    void OnObjectClicked(int id)
    {
        Debug.Log("クリックされたオブジェクトのID：" + id);
    }
}
