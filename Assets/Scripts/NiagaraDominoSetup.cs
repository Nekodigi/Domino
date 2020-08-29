using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NiagaraDominoSetup : MonoBehaviour
{
    public int nI;
    public int nJ;
    public GameObject kaplaObj;

    // Start is called before the first frame update
    void Start()
    {
        float xspace = 0.36f;//x spacing
        float zspace = 0.14f;//z spacing
        Camera.main.transform.position = new Vector3(xspace*nI/2f, 0.03f*nJ, -xspace * nI / 4f * Mathf.Sqrt(3));
        for (int j = 0; j < nJ; j++)
        {
            for (int i = 0; i < nI; i++)
            {
                float ry = 90;
                float px = i * xspace;
                float pz = 0;
                if (j % 2 == 0)
                {
                    ry = 20 - i % 2 * 40;
                }
                else
                {
                    if (i == nI - 1) continue;
                    px += xspace/2;
                    pz = zspace - zspace*2 * (i % 2);
                    if (i == 0)
                    {
                        Instantiate(kaplaObj, new Vector3(-0.03f, 0.03f + j * 0.06f, -0.0823f), Quaternion.Euler(0, 20, 0));
                    }
                    if (i == nI-2)
                    {
                        Instantiate(kaplaObj, new Vector3((i+1) * xspace + 0.03f, 0.03f + j * 0.06f, -0.0823f), Quaternion.Euler(0, -20, 0));
                    }
                }
                Quaternion angle = Quaternion.Euler(0, ry, 0);
                Instantiate(kaplaObj, new Vector3(px, 0.03f + j * 0.06f, pz), angle);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
