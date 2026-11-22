using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[System.Serializable]
public class KuData
{
    public string name;

    public int nameLen;
    public bool isContainDo = false;
    public bool isContainWho = false;
}



public static class SenryuData
{
    public static List<KuData> sentences = new List<KuData>
    {
        new KuData
        {
            name = "夕暮れ時に",
            nameLen = 7,
        },
        new KuData
        {
            name = "奥山に",
            nameLen = 5,
        },
        new KuData
        {
            name = "最大級に",
            nameLen = 7,
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
            isContainWho = true,
        },
        new KuData
        {
            name = "たかしくん",
            nameLen = 5,
            isContainWho = true,
        },
        new KuData
        {
            name = "スズメバチ",
            nameLen = 5,
            isContainWho = true,
        },
        new KuData
        {
            name = "出遅れる",
            nameLen = 5,
            isContainDo = true
        },
        new KuData
        {
            name = "返り討ち",
            nameLen = 5,
            isContainDo = true
        },
        new KuData
        {
            name = "だまし討ち",
            nameLen = 5,
            isContainDo = true
        },
        new KuData
        {
            name = "道に迷う",
            nameLen = 5,
            isContainDo = true
        },
        new KuData
        {
            name = "息ひそめる",
            nameLen = 5,
            isContainDo = true
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

    public static List<KuData> GetRandomSentences(int count)
    {
        var candidates = sentences
            .OrderBy(s => Random.value)
            .Take(count)
            .ToList();

        return candidates;
    }
}