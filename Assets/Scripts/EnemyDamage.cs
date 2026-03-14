using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public BoxCollider2D SpikeHurtBox;

    GameObject GameManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameManager = GameObject.FindWithTag("GameManager");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameManager.GetComponent<GameManager>().Die();
            Destroy(collision.gameObject);
            Debug.Log("DamageTrigger");
        }


        
    }

}
