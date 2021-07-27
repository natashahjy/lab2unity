using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private const float SPEED = 5.0F;

    // Update is called once per frame
    void Update()
    {
        float mvX = Input.GetAxis("Horizontal") * Time.deltaTime * SPEED;
        float mvZ = Input.GetAxis("Vertical") * Time.deltaTime * SPEED;

        transform.Translate(mvX, 0, mvZ);
    }
}
