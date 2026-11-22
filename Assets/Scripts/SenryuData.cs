using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[System.Serializable]
public class KuData
{
    public string name;

    public int nameLen;
    public bool isContainPredicate = false;
}



public static class SenryuData
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
            name = "アフリカに",
            nameLen = 5,
        },
        new KuData
        {
            name = "サンタ三名",
            nameLen = 7,
        },
        new KuData
        {
            name = "出遅れる",
            nameLen = 5,
            isContainPredicate = true
        },
        new KuData
        {
            name = "返り討ち",
            nameLen = 5,
            isContainPredicate = true
        },
    };

    public static KuData GetRandomSentence(int nameLen)
    {
        var candidates = sentences
            .Where(s => s.nameLen == nameLen)
            .ToList();

        if (candidates.Count == 0)
        {
            return null;
        }

        int index = Random.Range(0, candidates.Count);

        return candidates[index];
    }
}