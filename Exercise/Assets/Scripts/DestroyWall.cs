using UnityEngine;

public class DestroyWall : MonoBehaviour
{
    [SerializeField] private GameObject particleEffect;
    
    void OnCollisionEnter(Collision collision){
        if (collision.gameObject.CompareTag("Projectile")) {
            Instantiate(particleEffect, transform.position, transform.rotation).transform.localScale = new Vector3(3f,3f,3f);
            Destroy(gameObject);
        }
    }
}
