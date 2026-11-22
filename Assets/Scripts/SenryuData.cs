using System.Collections.Generic;

[System.Serializable]
public class KuData
{
    public string name;

    public int nameLen;
    public bool isContainPredicate = false;
}



public static class GameDatabase
{
    public static List<KuData> sentences = new List<KuData>
    {
        new KuData
        {
            name = "奥山に",
            nameLen = 5,
        },
        new KuData
        {
            name = "サンタクロース",
            nameLen = 7,
        },
        new KuData
        {
            name = "出遅れる",
            nameLen = 5,
            isContainPredicate = true
        },
    };
}