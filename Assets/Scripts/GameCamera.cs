using UnityEngine;

public class GameCamera : MonoBehaviour
{
    //public ObjectSpawner ObjectSpawner;

    GameObject PlayerPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayerPrefab = GameObject.FindWithTag("Player");


        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(PlayerPrefab.transform.position.x + 3, transform.position.y, transform.position.z);
    }
}
