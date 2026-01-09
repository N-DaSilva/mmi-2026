using UnityEngine;
using UnityEngine.InputSystem;

public class SpawnerController : MonoBehaviour
{
    private static readonly string ATTACK_ACTION = "Attack";

    private InputAction attackAction;

    [SerializeField] private GameObject projectile;
    [SerializeField] private ItemController m_ItemController;

    private bool isEquipped = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        attackAction = InputSystem.actions.FindAction(ATTACK_ACTION);
    }

    private bool CheckEquip()
    {
        if (m_ItemController != null)
            {
                if (!InventorySystem.Instance.HasItem(m_ItemController.UniqueID))
                {
                    return false;
                }
            }

            isEquipped = true;
            return true;
    }

    // Update is called once per frame
    void Update()
    {
        if (attackAction.WasPressedThisFrame())
        {
            if (!isEquipped)
            {
                CheckEquip();
            } else
            {
                Instantiate(projectile, transform.position, transform.rotation);
            }
        }
    }
}
