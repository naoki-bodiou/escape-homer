using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Include the namespace required to use Unity UI and Input System
using UnityEngine.InputSystem;
using TMPro;

public class PickUp : MonoBehaviour
{

    public TextMeshProUGUI countText;

    private Rigidbody rb;
    private int count;



    // Start is called before the first frame update
    void Start()
    {

        // Assign the Rigidbody component to our private rb variable
        rb = GetComponent<Rigidbody>();

        // Set the count to zero
        count = 0;

        // Run the SetCountText function (see below)
        SetCountText();

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {



        // ..and if the GameObject you intersect has the tag 'Pick Up' assigned to it..
        if (other.gameObject.CompareTag("DonutPickUp"))
        {
            other.gameObject.SetActive(false);

            // Add one to the score variable 'count'
            count = count + 1;

            // Run the 'SetCountText()' function (see below)
            SetCountText();
        }

    }

    void SetCountText()
    {
        // Update the text field of our 'countText' variable
        countText.text = "Donut: " + count.ToString();
    }
}
