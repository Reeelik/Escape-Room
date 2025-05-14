using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour
{

    public float TheDistance;
    public GameObject ThePlayer;
    public GameObject Pick_Up_Text;
    public GameObject Key;

    // Start is called before the first frame update
    void Update()
    {
        TheDistance = Vector3.Distance(this.transform.position, ThePlayer.transform.position);
    }

    // Update is called once per frame
    private void OnMouseOver()
    {
        if (TheDistance <= 4)
        {
            Pick_Up_Text.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (TheDistance <= 4)
            {
                Key.SetActive(true);
                Destroy(gameObject);
                Pick_Up_Text.SetActive(false);
            }
        }
        if (TheDistance > 3)
        {
            Pick_Up_Text.SetActive(false);
        }

    }
    void OnMouseExit()
    {
        Pick_Up_Text.SetActive(false);
    }

    private void OnTriggerExit(Collider other)
    {
        Pick_Up_Text.SetActive(false);
    }
}
