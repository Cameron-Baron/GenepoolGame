using UnityEngine;
using System.Collections;

public class EffectOnCollision : MonoBehaviour 
{
    public GameObject effect;
    public bool removeOnCollision;
    
    void OnCollisionEnter(Collision collision)
    {
        //foreach (ContactPoint contact in collision.contacts)
        //{
        //    Debug.DrawRay(contact.point, contact.normal, Color.white);
        //}
        if (collision.relativeVelocity.magnitude > 2)
        {
            GameObject proj = Instantiate(effect, transform.position, transform.rotation) as GameObject;
            if (removeOnCollision == true)
            {
                Destroy(gameObject);
            }
        }
    }
}
