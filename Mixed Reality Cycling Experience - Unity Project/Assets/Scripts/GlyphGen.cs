using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlyphGen : MonoBehaviour
{
    const string glyphs = "abcdefghijklmnopqrstuvwxyz0123456789";
    public static string code;
    //add the characters you w
    // Start is called before the first frame update
    //int charAmount = Random.Range(5, 5);
    public Text text;
    void Start()
    {
        glyphgen();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void glyphgen()
    {
        int charAmount = Random.Range(6, 6); //set those to the minimum and maximum length of your string
        for (int i = 0; i < charAmount; i++)
        {
            code += glyphs[Random.Range(0, glyphs.Length)];
        }
        Debug.Log(code);
        text.text = code;
    }
}
