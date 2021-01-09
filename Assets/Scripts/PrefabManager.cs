using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabManager : MonoBehaviour
{
    ObjectPooler objectPooler;
    public GameManager gm;
    
    int rnd = 0;
    float difficulty = 1.5f;
    bool diffhelp = true;
    int duplicate;

    
    
    private void Start()
    {
        objectPooler = ObjectPooler.Instance;
        duplicate = rnd;
        
    }

    private void Update()
    {
        bool hardcore = gm.hardcore;
        switch (gm.score)
        {
            case 150:
                difficulty = 1.25f;
                break;
            case 300:
                difficulty = 1f;
                break;
            case 450:
                difficulty = 0.9f;
                break;
            case 600:
                difficulty = 0.8f;
                break;
            case 750:
                difficulty = 0.7f;
                break;
            case 900:
                difficulty = 0.6f;
                break;
        }
        if (diffhelp)
        {
            if (hardcore == false)
            {
                Invoke("spawn", difficulty);
                diffhelp = false;
            }
            else
            {
                Invoke("spawn", 0.6f);
                diffhelp = false;
            }
            
        }

    }

    private void spawn()
    {
        while (duplicate == rnd)
        {
            rnd = Random.Range(0, 7);
        }
        duplicate = rnd;
        diffhelp = true;
        objectPooler.SpawnFromPool(rnd.ToString(), new Vector3(0,1,100), Quaternion.identity);
    }
}
