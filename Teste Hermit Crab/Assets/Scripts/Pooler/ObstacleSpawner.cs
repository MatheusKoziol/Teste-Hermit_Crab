using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{

    public float timeBetweenSpawns;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnObstacle());
    }

    /// <summary>
    /// Function that spawns the obstacles in the pool
    /// </summary>
    /// <returns></returns>
    public IEnumerator SpawnObstacle()
    {
        GameObject obj = ObjectPooler.instance.GetPooledObject();

        if (obj != null)
        {
            float posY = Random.Range(-1f ,2.8f);

            obj.transform.position = new Vector3(10f, posY, 21.0289f);
            obj.SetActive(true);
        }

        yield return new WaitForSeconds(timeBetweenSpawns);
        StartCoroutine(SpawnObstacle());
    }
}
