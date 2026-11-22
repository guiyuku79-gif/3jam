using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject karutaPrefab;
    [SerializeField] GameObject OneKuPrefab;
    [SerializeField] GameObject MyKarutaPrefab;
    [SerializeField] UIManager uIManager;

    List<KuData> KuList = new();
    List<KuData> MyKuList = new();

    Dictionary<int,KuData> choiceDict = new Dictionary<int, KuData>();
    List<OneKuManager> oneKuManagers = new();

    KarutaManager karutaManager;
    MyKarutaManager myKarutaManager;

    int currentPos = 0;

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
            oneKuManagers.Add(oneKuPrefab.GetComponent<OneKuManager>());
            choiceDict.Add(i,text);
        }

        //プレイヤーが作るカルタを生成
        GameObject myKarutaPrefab = Instantiate(MyKarutaPrefab);
        myKarutaManager = myKarutaPrefab.GetComponent<MyKarutaManager>();
        myKarutaManager.Init();
        
        currentPos = 0;
    }

    void OnObjectClicked(int id)
    {
        Debug.Log("クリックされたオブジェクトのID：" + id);
        if( currentPos == 0 || currentPos == 2)
        {
            if(choiceDict[id].nameLen == 5)
            {
                myKarutaManager.SetKu(currentPos,choiceDict[id].name);
                MyKuList.Add(choiceDict[id]);
            }
            else
            {
                return;
            }
        }
        else
        {
            if(choiceDict[id].nameLen == 7)
            {
                myKarutaManager.SetKu(currentPos,choiceDict[id].name);
                MyKuList.Add(choiceDict[id]);
            }
            else
            {
                return;
            }
        }

        if (currentPos == 2)
        {
            CompletedHaiku();
        }
        else
        {
            currentPos += 1;
        }
    }

    void CompletedHaiku(){
        Debug.Log("完成");
        var result = Calc.CalcPoint(KuList,MyKuList,0);
        uIManager.ShowResult(result.point,result.comment);

    }
}
