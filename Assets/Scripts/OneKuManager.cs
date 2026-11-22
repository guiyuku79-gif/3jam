using TMPro;
using UnityEngine;
using System;

public class OneKuManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textUI;

    int id;

    Action<int> onClicked;

    public void Init(string text,int id,Action<int> callback)
    {
        textUI.text = text;
        this.id = id;
        transform.position = new Vector3(-7.5f + 1.5f*id,-2.86f,0);
        onClicked = callback;
    }

    void OnMouseDown()
    {
        onClicked?.Invoke(id);
    }

    void OnDestroy()
    {
        onClicked = null;
    }
}
