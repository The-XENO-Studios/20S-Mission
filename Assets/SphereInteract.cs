using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereInteract : MonoBehaviour
{

    public GameObject EquipText;

    public Transform LeftDoor;
    public Transform RightDoor;

    bool inRange;

    public GameObject Sphere;

    [SerializeField] private Vector3 LeftRotation;
    [SerializeField] private Vector3 RightRotation;

    public float time;

    private void OnTriggerEnter(Collider other)
    {
        EquipText.SetActive(true);

        if(other.tag == "Player")
        {
            inRange = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        EquipText.SetActive(false);

        inRange = false;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && inRange)
        {
            Destroy(Sphere);
            EquipText.SetActive(false);

            LeftDoor.rotation = Quaternion.Lerp(Quaternion.Euler(Vector3.zero), Quaternion.Euler(LeftRotation), time);
            RightDoor.rotation = Quaternion.Lerp(Quaternion.Euler(Vector3.zero), Quaternion.Euler(RightRotation), time);

            Destroy(gameObject);
        }
    }
}
