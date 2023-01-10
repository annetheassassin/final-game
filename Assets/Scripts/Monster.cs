using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{

    static Vector2 tempPos;
    static bool isActive;

    // Start is called before the first frame update
    void FixedUpdate()
    {
        tempPos = transform.position;

        if (Input.GetKey(KeyCode.W)) { tempPos.y += 0.05f; }
        if (Input.GetKey(KeyCode.S)) { tempPos.y -= 0.05f; }
        if (Input.GetKey(KeyCode.D)) { tempPos.x += 0.05f; }
        if (Input.GetKey(KeyCode.A)) { tempPos.x -= 0.05f; }


        transform.position = tempPos;
    }

    public static Vector2 GivePosMonster()
    {
        Vector2 MonsterPos = tempPos;
        return MonsterPos;
    }
}
