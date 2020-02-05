using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGround : MonoBehaviour
{
    public float scrollSpeed = 0.8f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= -15.12f)
            transform.position = new Vector2(8.922f, transform.position.y);
        transform.Translate(new Vector3(-scrollSpeed,0,0) *Time.deltaTime);
    }
}
