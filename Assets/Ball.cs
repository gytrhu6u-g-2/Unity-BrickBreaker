using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D myRigidBody;

    public float speedX = 10;
    public float speedY = 10;

    // Start is called before the first frame update
    void Start()
    {
        // 物理エンジンのコンポーネント取得
        myRigidBody = this.gameObject.GetComponent<Rigidbody2D>();

        //　x,yの方向に力を加える 
        Vector2 force = new Vector2(speedX, speedY);

        // 物理エンジンに力を加える
        myRigidBody.AddForce(force);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
