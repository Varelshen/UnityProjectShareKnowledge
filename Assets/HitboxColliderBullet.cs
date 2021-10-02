using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class HitboxColliderBullet : MonoBehaviour
{

    public GameObject objectdestroyed;

    public AudioSource Source;
    public AudioClip Clip;

    public AudioSource HitSource;
    public AudioClip HitClip;

    public GameObject PuntoCoin;
    public Transform VirusPosition;

    public int health = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Destroy(objectdestroyed);
            
            Die();

        }
    }

    void Die()
    {
        PuntoCoin.SetActive(true);
        GameObject bullet = Instantiate(PuntoCoin, VirusPosition.position, VirusPosition.rotation);
        Source.PlayOneShot(Clip);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Bullet"))
        {

            HitSource.PlayOneShot(HitClip);
            health = health - 1;
            Debug.Log("healt");
            
        }
    }
}
