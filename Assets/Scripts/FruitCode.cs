using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitCode : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        //transform.position += speed;
        transform.Rotate(new Vector3(0, 0, 1), 2f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "deadZone")
        {
            Destroy(this.gameObject);
        }
    }
}
