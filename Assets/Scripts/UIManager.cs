using UnityEngine;
using TMPro;
using System.Collections;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject result;
    [SerializeField] TextMeshProUGUI pointUI;
    [SerializeField] TextMeshProUGUI textUI;

    public void ShowResult(int point,string comment)
    {
        pointUI.text = "";
        textUI.text = "";
        StartCoroutine(MoveCoroutine(result.transform,new Vector3(-18,0,0),new Vector3(0,0,0),0.5f,point,comment));


    }
    IEnumerator MoveCoroutine(Transform obj,Vector3 initPos ,Vector3 target, float smoothTime,int point,string comment)
    {
        Vector3 velocity = Vector3.zero;

        while (obj != null &&
               Vector3.Distance(obj.position, target) > 0.01f)
        {
            obj.position = Vector3.SmoothDamp(
                obj.position,
                target,
                ref velocity,
                smoothTime
            );

            yield return null;
        }


        float timer = 0f;

        while (timer < 0.5f)
        {
            // ランダムな数字を表示
            pointUI.text =  $"{Random.Range(0, 100)}点";

            timer += Time.deltaTime;

            yield return null;
        }

        pointUI.text = $"{point}点";
        textUI.text = comment;
    }
}
