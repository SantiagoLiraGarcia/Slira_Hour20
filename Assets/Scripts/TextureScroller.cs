using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureScroller : MonoBehaviour
{
    public float speed = 0.5f;

    Renderer rend;
    float offset = 0;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        offset = offset + Time.deltaTime + speed;
        if (offset > 1) ;
        {
            offset -= 1;
        }
        rend.material.mainTextureOffset = new Vector2(0, offset);
    }

}
