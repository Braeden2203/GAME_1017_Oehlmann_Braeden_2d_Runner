using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public BoxCollider2D SpikeHurtBox;

    public GameManager GameManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager.Die();
        Destroy(collision.gameObject);
        //Debug.Log("A");
    }

}
