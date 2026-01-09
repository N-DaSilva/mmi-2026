using UnityEngine;

public class DestroyWall : MonoBehaviour
{
    [SerializeField] private GameObject particleEffect;
    
    void OnCollisionEnter(Collision collision){
        Debug.Log("collision detected");

        if (collision.gameObject.CompareTag("Projectile")) {
            Instantiate(particleEffect, transform.position, transform.rotation).transform.localScale = new Vector3(5f,5f,5f);
            Destroy(gameObject);
        }
    }
}
