using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPools : MonoBehaviour
{
    [SerializeField] GameObject ram;
    [SerializeField] int pool = 5;
    [SerializeField] float delayTime = 1f;

    GameObject[] poolsize;
    // Start is called before the first frame update

    private void Awake()
    {
        PoolSize();
    }

    void Start()
    {
        StartCoroutine(RespawnEnemy());
    }

    void PoolSize()
    {
        poolsize = new GameObject[pool];
        for (int i = 0; i < poolsize.Length; i++)
        {
            poolsize[i] = Instantiate(ram, transform);
            poolsize[i].SetActive(false);
        }
    }
    void EnableObjectInPool()
    {
        for (int i = 0; i < poolsize.Length; i++)
        {
            if(poolsize[i].activeInHierarchy == false)
            {
                poolsize[i].SetActive(true);
                return;
            }
        }
    }
    IEnumerator RespawnEnemy()
    {
        while (true)
        {
            EnableObjectInPool();
            yield return new WaitForSeconds(delayTime);
        }
    }
}
