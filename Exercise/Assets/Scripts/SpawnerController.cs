using UnityEngine;
using UnityEngine.InputSystem;

public class SpawnerController : MonoBehaviour
{
    private static readonly string ATTACK_ACTION = "Attack";

    private InputAction attackAction;

    [SerializeField] private GameObject projectile;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        attackAction = InputSystem.actions.FindAction(ATTACK_ACTION);
    }

    // Update is called once per frame
    void Update()
    {
        if (attackAction.WasPressedThisFrame()){
            Instantiate(projectile, transform.position, transform.rotation);
        }
    }
}
