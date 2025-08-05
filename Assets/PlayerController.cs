using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    public void LButtonDown()
    {
        transform.Translate(-1, 0, 0);
    }

    public void RButtonDown()
    {
        transform.Translate(1, 0, 0);
    }


    void Update()
    {
        // 左矢印をおしたら
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-1, 0, 0);  // 左に3うごく
        }

        // 右矢印をおしたら
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(1, 0, 0);  // 右に3うごく
        }
    }
}
