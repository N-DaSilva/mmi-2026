using UnityEngine;

public class FireballController : MonoBehaviour
{

    [SerializeField] private float projectileSpeed;
    [SerializeField] private GameObject particleEffect;
    private Rigidbody rigidbody;

    void Start() {
        rigidbody = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision collision){
        ContactPoint contact = collision.contacts[0];
        Quaternion rotation = Quaternion.FromToRotation(Vector3.up, contact.normal);
        Vector3 position = contact.point;
        Instantiate(particleEffect, position, rotation);
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.linearVelocity = transform.forward * projectileSpeed;
    }
}
