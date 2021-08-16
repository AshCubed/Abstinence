using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform SpawnPoint1;
    public Transform SpawnPoint2;
    public Transform SpawnPoint3;

    public GameObject lemon;
    public GameObject orange;
    public GameObject grapeFruit;

    public GameObject iceCube1;
    public GameObject iceCube2;
    public GameObject iceCube3;

    public GameObject Alcohol;

    float spawnSelector;
    float itemSelector;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnFruit());
    }

    IEnumerator spawnFruit()
    {
        yield return new WaitForSeconds(0.5f);

        spawnSelector = Random.Range(0, 4);
        itemSelector = Random.Range(0, 8);

        switch (itemSelector)
        {
            case 1:
                switch (spawnSelector)
                {
                    case 1:
                        Instantiate(lemon, SpawnPoint1.transform.position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(lemon, SpawnPoint2.transform.position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(lemon, SpawnPoint3.transform.position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                break;

            case 2:
                switch (spawnSelector)
                {
                    case 1:
                        Instantiate(orange, SpawnPoint1.transform.position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(orange, SpawnPoint2.transform.position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(orange, SpawnPoint3.transform.position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                break;

            case 3:
                switch (spawnSelector)
                {
                    case 1:
                        Instantiate(grapeFruit, SpawnPoint1.transform.position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(grapeFruit, SpawnPoint2.transform.position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(grapeFruit, SpawnPoint3.transform.position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                break;

            case 4:
                switch (spawnSelector)
                {
                    case 1:
                        Instantiate(iceCube1, SpawnPoint1.transform.position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(iceCube1, SpawnPoint2.transform.position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(iceCube1, SpawnPoint3.transform.position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                break;

            case 5:
                switch (spawnSelector)
                {
                    case 1:
                        Instantiate(iceCube2, SpawnPoint1.transform.position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(iceCube2, SpawnPoint2.transform.position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(iceCube2, SpawnPoint3.transform.position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                break;

            case 6:
                switch (spawnSelector)
                {
                    case 1:
                        Instantiate(iceCube3, SpawnPoint1.transform.position, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(iceCube3, SpawnPoint2.transform.position, Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(iceCube3, SpawnPoint3.transform.position, Quaternion.identity);
                        break;
                    default:
                        break;
                }
                break;

            case 7:
                int count = Random.Range(0, 1000);
                if (count % 2 == 0)
                {
                    switch (spawnSelector)
                    {
                        case 1:
                            Instantiate(Alcohol, SpawnPoint1.transform.position, Quaternion.identity);
                            break;
                        case 2:
                            Instantiate(Alcohol, SpawnPoint2.transform.position, Quaternion.identity);
                            break;
                        case 3:
                            Instantiate(Alcohol, SpawnPoint3.transform.position, Quaternion.identity);
                            break;
                        default:
                            break;
                    }
                }
            break;

            default:
                break;
        }

        StartCoroutine(spawnFruit());
    }
}
