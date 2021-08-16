using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuSpawner : MonoBehaviour
{
    public GameObject lemon;
    public GameObject orange;
    public GameObject grapeFruit;
    public GameObject iceCube1;
    public GameObject spawnLocation;

    private List<GameObject> mainMenuFruit = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(fruitSpawner());
    }

    private void OnEnable()
    {
        StartCoroutine(fruitSpawner());
    }

    private void OnDisable()
    {
        DestroyFruit();
        Debug.Log("destory");
    }

    int itemNum = 0;
    IEnumerator fruitSpawner()
    {
        yield return new WaitForSeconds(0.4f);

        int itemSelector = Random.Range(0, 8);

        switch (itemSelector)
        {
            case 1:
                var instantiatedPrefab = Instantiate(lemon, spawnLocation.transform.position, Quaternion.identity);
                instantiatedPrefab.transform.localScale = new Vector3(0.0346687f, 0.0346687f, 0.0346687f);
                mainMenuFruit.Add(instantiatedPrefab);
                itemNum++;
                break;
            case 2:
                var instantiatedPrefab1 = Instantiate(orange, spawnLocation.transform.position, Quaternion.identity);
                instantiatedPrefab1.transform.localScale = new Vector3(0.0346687f, 0.0346687f, 0.0346687f);
                mainMenuFruit.Add(instantiatedPrefab1);
                itemNum++;
                break;
            case 3:
                var instantiatedPrefab2 = Instantiate(grapeFruit, spawnLocation.transform.position, Quaternion.identity);
                instantiatedPrefab2.transform.localScale = new Vector3(0.0346687f, 0.0346687f, 0.0346687f);
                mainMenuFruit.Add(instantiatedPrefab2);
                itemNum++;
                break;
            case 4:
                var instantiatedPrefab3 = Instantiate(iceCube1, spawnLocation.transform.position, Quaternion.identity);
                itemNum++;
                instantiatedPrefab3.transform.localScale = new Vector3(0.0346687f, 0.0346687f, 0.0346687f);
                mainMenuFruit.Add(instantiatedPrefab3);
                break;
            default:
                break;
        }

        if (itemNum < 7)
        {
            StartCoroutine(fruitSpawner());
        }
        else if (itemNum >= 7)
        {
            DestroyFruit();
            StartCoroutine(fruitSpawner());
        }
    }

    void DestroyFruit()
    {
        for (int i = 0; i < mainMenuFruit.Count; i++)
        {
            Destroy(mainMenuFruit[i]);
            mainMenuFruit.RemoveAt(i);
            itemNum = 0;
        }
    }
}
