using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public GameObject Ground;

    GameObject PlayerPrefab;
    public bool HasTriggered = false;
    public float DestroyTime = 15f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayerPrefab = GameObject.FindWithTag("Player");
        Destroy(gameObject, DestroyTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && !HasTriggered)
        {
            Debug.Log("trigger");
            GameObject CurrentGround = Instantiate(Ground, new Vector2(PlayerPrefab.transform.position.x + 100, -4), Quaternion.identity);
            HasTriggered = true;
        }

    }
}
