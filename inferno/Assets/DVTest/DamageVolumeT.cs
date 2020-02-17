using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageVolumeT : MonoBehaviour
{
    public float damageInterval = 1;
    private float currentInterval = 0;
    private GameObject myTarget = null;
    private bool targetHere = false;
    //SerializeField[Damage] damageReference;
    //private Damage damageDragged;
    //private Health healthT;
    public DamageT dtDragged;
    public HPTempo healthDragged;
    
        
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (targetHere)
        {
            if (myTarget.GetComponent<HPTempo>().currentHealth > 0)
            {
                currentInterval += Time.deltaTime;
                if (currentInterval >= damageInterval)
                {
                    myTarget.GetComponent<HPTempo>().ApplyDamage(dtDragged.baseDamage);
                    Debug.Log("Ouch!");
                    //if (sound != null)
                    //{
                    //    GetComponent<AudioSource>().clip = sound;
                    //    GetComponent<AudioSource>().Play();
                    //}
                    currentInterval = 0;
                }
            }
        }
    }
    void OnTriggerEnter(Collider entity)
    {
        if (entity.GetComponent<HPTempo>() != null)
        {
            myTarget = entity.gameObject;
            targetHere = true;
            print(gameObject.name + " targeted " + myTarget.name + "!");
            //healthDragged.currentHealth -= 10;

           
        }
    }

    void OnTriggerExit(Collider entity)
    {
        if (entity.gameObject == myTarget)
        {
            targetHere = false;
            myTarget = null;
            print(gameObject.name + " lost its target.");
        }
    }

}
