using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEnemy : MonoBehaviour
{
    public GameObject prefabEnemy;
    public Vector2 limitMin;
    public Vector2 limitMax;
    private float delay;
    private int count;

    void Start()
    {
        StartCoroutine(Create());
    }

    private IEnumerator Create()
    {
        while(true)
        {
            count++;

            float random = UnityEngine.Random.Range(limitMin.y, limitMax.y);
            Vector2 creatingPoint = new Vector2(limitMin.x, random);

            Instantiate(prefabEnemy, creatingPoint, Quaternion.identity);

            delay = 10.0f / (count + 4);
            yield return new WaitForSeconds(delay);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.white;
        Gizmos.DrawLine(limitMin, limitMax);
    }
}
