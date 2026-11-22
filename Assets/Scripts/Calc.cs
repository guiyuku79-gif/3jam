using System.Collections.Generic;
using UnityEngine;

public static class Calc
{
    public static (int point,string comment) CalcPoint(List<KuData> KuList,List<KuData> MyKuList,int time)
    {
        List<string> kuNameList = new();
        foreach (KuData ku in KuList)
        {
            kuNameList.Add(ku.name);    
        }
        List<string> myKuNameList = new();
        foreach (KuData ku in MyKuList)
        {
            myKuNameList.Add(ku.name); 
        }

        if( kuNameList.Contains(myKuNameList[0]) && kuNameList.Contains(myKuNameList[1]) ||
            kuNameList.Contains(myKuNameList[0]) && kuNameList.Contains(myKuNameList[2]) ||
            kuNameList.Contains(myKuNameList[1]) && kuNameList.Contains(myKuNameList[2]))
        {
            return (0,"これは本歌取りというよりただのパクリじゃな");
        }

        if( ! kuNameList.Contains(myKuNameList[0]) &&  ! kuNameList.Contains(myKuNameList[1]) && !kuNameList.Contains(myKuNameList[2]))
        {
            return (10,"先人の句をもっと学んだほうがよい");
        }


        int score = 0;
        string comment = "完璧な本歌取りじゃ！";

        //述語を考える
        if( ! MyKuList[0].isContainDo &&  ! MyKuList[1].isContainDo&& ! MyKuList[2].isContainDo)
        {
            score += 10;
            comment = "なにをしたのかを書くともっとよいぞ";
        }
        else if (  MyKuList[0].isContainDo &&  MyKuList[1].isContainDo&& MyKuList[2].isContainDo)
        {
            score += 5;
            comment = "述語が多すぎるぞ";
        }
        else
        {
            score += 25;
        }

        //時間をカウント
        score += Mathf.Max(0,25 - time);
        
        if( ! MyKuList[0].isContainWho &&  ! MyKuList[1].isContainWho && ! MyKuList[2].isContainWho)
        {
            score += 10;
            comment = "誰をしたのかを書くともっとよいぞ";
        }
        else if (  MyKuList[0].isContainWho &&  MyKuList[1].isContainWho&& MyKuList[2].isContainWho)
        {
            score += 5;
            comment = "主語が多すぎるぞ";
        }
        else
        {
            score += 25;
        }

        score += 25;

        return (score,comment);
    }
}