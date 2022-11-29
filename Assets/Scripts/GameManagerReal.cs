using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerReal : MonoBehaviour
{
    public bool hasWon;
    public bool hasLost;
    bool hasWon1 = true;
    bool hasLost1 = true;

    public GameObject[] objectsToDiable;
    public GameObject lostUI;

    public GameObject explosionEffect;
    public GameObject fireEffect;

    public GameObject firstText;

    public Transform Player;

    public GameObject VirtualCamera;

    public Rigidbody PlayerRb;

    private void Start()
    {
        StartCoroutine(CameraChange());
        StartCoroutine(EnableFirstText());
    }

    // Update is called once per frame
    void Update()
    {
        if (hasWon && hasWon1)
        {
            SceneManager.LoadScene("Ending");
            hasWon1 = false;
        }

        if (hasLost && hasLost1)
        {
            PlayerRb.constraints = RigidbodyConstraints.FreezePosition;

            foreach (var item in objectsToDiable)
            {
                item.SetActive(false);
            }

            lostUI.SetActive(true);

            Instantiate(explosionEffect, Player.position, Player.rotation);
            Instantiate(explosionEffect, Player.position, Player.rotation);
            Instantiate(explosionEffect, Player.position, Player.rotation);
            Instantiate(explosionEffect, Player.position, Player.rotation);
            Instantiate(explosionEffect, Player.position, Player.rotation);
            Instantiate(explosionEffect, Player.position, Player.rotation);
            Instantiate(fireEffect, Player.position, Player.rotation);

            hasLost1 = false;
        }
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu_Scene");
    }

    IEnumerator EnableFirstText()
    {
        yield return new WaitForSeconds(3f);
        firstText.SetActive(true);
    }

    IEnumerator CameraChange()
    {
        yield return new WaitForSeconds(1f);
        VirtualCamera.SetActive(true);
    }
}
