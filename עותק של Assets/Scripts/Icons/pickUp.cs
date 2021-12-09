using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class pickUp : MonoBehaviour
{
    [SerializeField]
    private GameObject prefab;
    [SerializeField]
    private float minTime = 1;
    [SerializeField]
    private float maxTime = 2;
    [SerializeField]
    private float minPos;
    [SerializeField]
    private float maxPos;

   
    private void Start()
    {
        StartCoroutine(pickUpRandom());
    }

    private IEnumerator pickUpRandom()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(minTime, maxTime));
            pickUpShow();
        }
    }

    private void pickUpShow()
    {
        transform.parent.localPosition = new Vector3(0, 0, Random.Range(minPos, maxPos));
        GameObject game = Instantiate(prefab, transform.position, Quaternion.identity);

       
        
        
    }
   
}
