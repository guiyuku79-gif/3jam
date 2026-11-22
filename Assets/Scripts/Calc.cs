using System.Collections.Generic;

public static class Calc
{
    public static (int,string) CalcPoint(List<KuData> KuList,List<KuData> MyKuList,int time)
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

        if( ! kuNameList.Contains(myKuNameList[0]) &&  ! kuNameList.Contains(myKuNameList[1]) && kuNameList.Contains(myKuNameList[2]))
        {
            return (10,"オリジナリティーを出すことも必要だが先人の句を学んだほうがよい");
        }

        return (100,"完璧な本歌取りである!");
    }
}