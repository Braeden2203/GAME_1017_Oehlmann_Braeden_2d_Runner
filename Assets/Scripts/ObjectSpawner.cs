using TMPro;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject PlayerPrefab;
    public GameObject Ground;
    public GameObject Spike;
    GameObject CurrentPlayer;

    public float SpikeSpawnTimer = 10f;

    Vector2 PlayerSpawnPoint = new Vector2(-3, -3);
    Vector2 GroundSpawnPointStart = new Vector2(0, -4);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CurrentPlayer = GameObject.FindWithTag("Player");

    }

    // Update is called once per frame
    void Update()
    {
        SpikeSpawnTimer -= Time.deltaTime;
        if (SpikeSpawnTimer <= 0)
        {
            SpawnSpike();
        }
    }

    private void Awake()
    {
        GameObject CurrentGround = Instantiate(Ground, GroundSpawnPointStart, Quaternion.identity);
        GameObject Player = Instantiate(PlayerPrefab, PlayerSpawnPoint, Quaternion.identity);
    }

    void SpawnSpike()
    {
        GameObject CurrentSpike = Instantiate(Spike, new Vector2(CurrentPlayer.transform.position.x + 45, -3), Quaternion.identity);
        SpikeSpawnTimer = Random.Range(5f, 15f);
        Destroy(CurrentSpike, 30f);
    }
}
