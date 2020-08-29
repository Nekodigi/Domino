using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageDominoSetup : MonoBehaviour
{
    public GameObject dominoObj;
    public Texture2D targetImg;


    // Start is called before the first frame update
    void Start()
    {
        Color[] pixels = targetImg.GetPixels();
        int iwidth = targetImg.width;
        int iheight = targetImg.height;Debug.Log(iwidth +""+ iheight);
        Camera.main.transform.position = new Vector3(iwidth/2*1.1f, iheight/2f*1.1f*Mathf.Sqrt(3)+2, iheight/2*1.1f);
        for (int i = 0; i < iwidth; i++)
        {
            for (int j = 0; j < iheight; j++)
            {
                Color pixel = pixels[i + j * iwidth];
                GameObject obj = Instantiate(dominoObj, new Vector3(i*1.1f, 1, j*1.1f), Quaternion.identity) as GameObject;
                obj.GetComponent<Renderer>().material.color = pixel;
                if (i == iwidth - 1) obj.transform.eulerAngles = new Vector3(0, 0, 10);//start domino

            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
