using UnityEngine;

public class WeaponController : MonoBehaviour
{
    public GameObject weapon;

    void Start()
    {
        weapon.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            weapon.SetActive(!weapon.activeSelf);
        }
    }
}
