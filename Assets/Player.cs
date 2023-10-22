using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D myRigidbody;

    // playerはx軸だけ
    public float playerSpeed = 10;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // UpdateをFixedUpdateに変更（物理エンジンを直接触るため）
    void FixedUpdate()
    {
        // 何も入力されていない時は0
        Vector2 force = Vector2.zero;

        // 左カーソルが押された時
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            force = new Vector2(playerSpeed * -1, 0);
        }

        // 右カーソルが押された時
        if (Input.GetKey(KeyCode.RightArrow))
        {
            force = new Vector2(playerSpeed, 0);
        }

        // 変数を設定　
        // Time.fixedDeltaTimeをつけることでマシンスペックに合わせることができる
        myRigidbody.MovePosition(myRigidbody.position + force * Time.fixedDeltaTime);
    }
}
