using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{

    public SpriteRenderer Background;

    public void RandomShow()
    {
        Background.color = RandomColor();
    }

    Color RandomColor()
    {
        //随机颜色的RGB值。即刻得到一个随机的颜色  
        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);
        Color color = new Color(r, g, b);
        return color;
    }

}
