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

    public bool isContainWhen = false;
    public bool isContainWhere = false;

    public bool isContainWhy = false;
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

        // ===== 主語・人物・動物・物など =====

        new KuData { name = "誰かさん", nameLen = 5, isContainWho = true },
        new KuData { name = "おばあちゃん", nameLen = 5, isContainWho = true },
        new KuData { name = "警察官", nameLen = 5, isContainWho = true },
        new KuData { name = "消防士", nameLen = 5, isContainWho = true },
        new KuData { name = "宇宙飛行士", nameLen = 7, isContainWho = true },
        new KuData { name = "サッカー選手", nameLen = 7, isContainWho = true },
        new KuData { name = "野球少年", nameLen = 7, isContainWho = true },
        new KuData { name = "転校生", nameLen = 5, isContainWho = true },
        new KuData { name = "新入社員", nameLen = 7, isContainWho = true },
        new KuData { name = "お医者さん", nameLen = 5, isContainWho = true },
        new KuData { name = "スズメバチ", nameLen = 5, isContainWho = true },
        new KuData { name = "カブトムシ", nameLen = 5, isContainWho = true },
        new KuData { name = "アメリカザリガニ", nameLen = 7, isContainWho = true },
        new KuData { name = "チンパンジー", nameLen = 5, isContainWho = true },
        new KuData { name = "フラミンゴ", nameLen = 5, isContainWho = true },
        new KuData { name = "ハリネズミ", nameLen = 5, isContainWho = true },

        // ===== 動作・述語 =====

        new KuData { name = "出遅れる", nameLen = 5, isContainDo = true },
        new KuData { name = "走り回る", nameLen = 5, isContainDo = true },
        new KuData { name = "飛び上がる", nameLen = 5, isContainDo = true },
        new KuData { name = "転がり落ちる", nameLen = 7, isContainDo = true },
        new KuData { name = "駆け抜ける", nameLen = 5, isContainDo = true },
        new KuData { name = "飛び跳ねる", nameLen = 5, isContainDo = true },
        new KuData { name = "立ち上がる", nameLen = 5, isContainDo = true },
        new KuData { name = "振り返る", nameLen = 5, isContainDo = true },
        new KuData { name = "見つめ合う", nameLen = 5, isContainDo = true },
        new KuData { name = "笑い転げる", nameLen = 7, isContainDo = true },

        // ===== 主語と述語の両方を含む =====

        new KuData { name = "猫が鳴く", nameLen = 5, isContainWho = true, isContainDo = true },
        new KuData { name = "犬が走る", nameLen = 5, isContainWho = true, isContainDo = true },
        new KuData { name = "鳥が飛ぶ", nameLen = 5, isContainWho = true, isContainDo = true },     
        new KuData { name = "魚が泳ぐ", nameLen = 7, isContainWho = true, isContainDo = true },
        new KuData { name = "虫が飛び立つ", nameLen = 7, isContainWho = true, isContainDo = true },
        new KuData { name = "子供が笑う", nameLen = 7, isContainWho = true, isContainDo = true },
        new KuData { name = "忍者が走る", nameLen = 7, isContainWho = true, isContainDo = true },


// ===== 場所（どこで・どこへ） =====

new KuData { name = "校庭で", nameLen = 5, isContainWhere = true },
new KuData { name = "木の下で", nameLen = 5, isContainWhere = true },
new KuData { name = "東京タワー", nameLen = 7, isContainWhere = true },

new KuData { name = "屋上の上", nameLen = 7, isContainWhere = true },


// ===== 時間（いつ） =====

new KuData { name = "真夜中に", nameLen = 5, isContainWhen = true },
new KuData { name = "夏休み中", nameLen = 7, isContainWhen = true },
new KuData { name = "卒業式で", nameLen = 7, isContainWhen = true },
new KuData { name = "日曜の朝", nameLen = 7, isContainWhen = true },



// ===== 理由（なぜ） =====

new KuData { name = "お腹が空いて", nameLen = 7, isContainWhy = true },
new KuData { name = "寝坊したから", nameLen = 7, isContainWhy = true },
new KuData { name = "暇だったので", nameLen = 7, isContainWhy = true },
new KuData { name = "急いでいたから", nameLen = 7, isContainWhy = true },


// ===== 方法・様子（どのように） =====

new KuData { name = "こっそりと", nameLen = 5,  },
new KuData { name = "大急ぎで", nameLen = 5, },
new KuData { name = "泣きながら", nameLen = 5,  },
new KuData { name = "堂々として", nameLen = 7,  },



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