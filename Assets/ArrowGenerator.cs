using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab;  // プレハブを指定
    float span = 0.5f;  // 矢を生成する待ち時間
    float delta = 0;    // 経過時間

    void Update()
    {
        this.delta += Time.deltaTime;  // 1/60秒づつ加算されていく
        if (this.delta > this.span)  // spanを超えたら
        {
            this.delta = 0;  // deltaをリセット
            GameObject go = Instantiate(arrowPrefab);  // インスタンスを作成
            int px = Random.Range(-6, 7);  // x座標をランダムに決める
            go.transform.position = new Vector3(px, 7, 0);
        }
    }
}
