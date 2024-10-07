using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ObjectPooler : MonoBehaviour
{
    //using singleton
    public static ObjectPooler instace;
    
    public void Awake()
    {
        instace = this;
    }
    // to this

    public List<Pool> pools;    //we made this list to store the properties of all the pools if we are using more than one pool

    [System.Serializable]    //this line of code is to show the class in inspector that is within a class 
    public class Pool   // this class is made to stored the properties of the pool e.g pool name or tag, the prefab pool holding and its limit after which its reusing its old prefabs in scene 
    {
     public string tag;
     public GameObject prefab;
     public int size;
        
    }

    public Dictionary<string, Queue<GameObject>> poolDictionary;      // we made dictionary here so to give the pool a name and queue so that we can store prefabs in it 

    void Start()
    {
        poolDictionary = new Dictionary<string, Queue<GameObject>>();  // we are initializing the instance of the poolDictionay

        foreach (Pool pool in pools)  //we looped through all the list of pools 
        {
            Queue<GameObject> objectPool = new Queue<GameObject>(); //making a new queue to store the gameobject in the queue
            for (int i = 0; i < pool.size; i++)   //looping for desired number of size we declared up
            {
                GameObject obj = Instantiate(pool.prefab);     // each time we instantiate an gameobject and named it as obj
                obj.SetActive(false);                   // making them inactive at start  so to store them 
                objectPool.Enqueue(obj);                 // putting them in the queue we made up 
            }

            poolDictionary.Add(pool.tag, objectPool);     //we declaring the dictionay instane by giving it the specifed tag of that iteration list and the queue of the iteration list
        }

    }
  
  //now as we have the dictionay made we can go further

  public GameObject SpawnFromPool(string tag, Vector3 position, Quaternion rot)
  {

    if (!poolDictionary.ContainsKey(tag))
    {
        Debug.LogError("pool with tag" + tag + "not found");
        return null;
    }


    GameObject objToSpawn = poolDictionary[tag].Dequeue();

    objToSpawn.SetActive(true);

    objToSpawn.transform.position = position;
    objToSpawn.transform.rotation = rot;

    poolDictionary[tag].Enqueue(objToSpawn);
    return objToSpawn;
  }
    
}
