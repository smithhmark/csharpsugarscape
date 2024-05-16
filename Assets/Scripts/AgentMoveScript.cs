using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentMoveScript : MonoBehaviour
{
    public float maxMoveSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {
    }


    // Update is called once per frame
    void Update()
    {
        MoveRandomly();
    }

    void MoveRandomly()
    {
        Vector3 dir;
        int sign;
        float moveSpeed = Random.Range(0.0f, maxMoveSpeed);

        switch (Random.Range(0.0f, 1.0f))
        {
            case > 0.75f:
                dir = transform.up;
                sign = 1;
                break;
            case > 0.5f:
                dir = transform.up;
                sign = -1;
                break;
            case > 0.25f:
                dir = transform.right;
                sign = -1;
                break;
            default:
                dir = transform.right;
                sign = 1;
                break;
        }
        transform.position = transform.position + moveSpeed * sign * dir * Time.deltaTime;
    }
}
