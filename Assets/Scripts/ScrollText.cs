using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollText : MonoBehaviour
{
    [SerializeField] RectTransform txtRT;
    [SerializeField] RectTransform contentRt;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var size = contentRt.sizeDelta;
        size.y = txtRT.sizeDelta.y;
        contentRt.sizeDelta = size;
    }
}
