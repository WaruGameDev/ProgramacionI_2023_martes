using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] fruits;
    public float actualTime;
    public float expectedTime = 2;
    // Update is called once per frame
    void Update()
    {
        if(actualTime< expectedTime) 
        {
            actualTime += 1 * Time.deltaTime;
            if(actualTime >= expectedTime ) 
            {
                //spawnear objeto
                Instantiate(fruits[Random.Range(0, fruits.Length)], 
                    transform.position, Quaternion.identity );
                actualTime = Random.Range(0,0.5f);
            }
        }
    }
}
