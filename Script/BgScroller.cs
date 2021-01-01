using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgScroller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    public float scrollSpeed = 1.0f;
    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z = Mathf.Repeat(-Time.time * scrollSpeed, transform.localScale.y);
        transform.position = newPosition;
    }
}
