using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public Gaddar nightRunner;

    public GameObject trees;
    public GameObject thorn;

    public float x;

    public float treetime;
    public float thorntime;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnObject(treetime));
        StartCoroutine(spawnThorn(thorntime));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator spawnThorn(float time)
    {
        while (!nightRunner.isDead)
        {
            Instantiate(thorn, new Vector3(Random.Range(-6, -10), -4, 0), Quaternion.identity);
            yield return new WaitForSeconds(time);
        }
        
    }


    public IEnumerator SpawnObject(float time)
    {
        while (!nightRunner.isDead) {

            Instantiate(trees, new Vector3(Random.Range(-7, -14), -1, 0), Quaternion.identity);
            yield return new WaitForSeconds(time);
        }
        
    }
}
