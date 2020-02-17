using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HPTempo : MonoBehaviour
{
    public int maxHealth = 10;
    public int currentHealth;
    //public GameObject deathObj = null;
    //public AudioClip deathSound = null;
    //public Transform respawnMarker = null;
    //public bool triggerExplosion = false;
    [SerializeField] string currentSceneName;
    [SerializeField] Vector3 startPosition;
    
    void Start()
    {
        currentHealth = maxHealth;
        startPosition = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ApplyDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            Debug.Log("Death");
            //gameObject.transform.position = startPosition;
            SceneManager.LoadScene(currentSceneName);
            Debug.Log("Restted");

            //if (deathObj)
            //{
            //    Instantiate(deathObj, transform.position, transform.rotation);
            //}

            //if (deathSound)
            //{
            //    GetComponent<AudioSource>().clip = deathSound;
            //    GetComponent<AudioSource>().Play();
            //}

            //if (triggerExplosion)
            //{
            //    SendMessage("DoDamage", SendMessageOptions.DontRequireReceiver);
            //}

            //if (respawnMarker)
            //{
            //    transform.position = respawnMarker.position;
            //    currentHealth = maxHealth;
            //}
            //else
            //{
            //    gameObject.SetActive(false);
            //}
        }
    }
}
