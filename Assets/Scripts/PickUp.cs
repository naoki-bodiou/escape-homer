using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Include the namespace required to use Unity UI and Input System
using UnityEngine.InputSystem;
using TMPro;

public class PickUp : MonoBehaviour
{

    public TextMeshProUGUI countText;
    public TextMeshProUGUI keyText;
    public TextMeshProUGUI winText;

    private Rigidbody rb;
    private int count;

    private bool key = false;



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

    void Update()
    {
        {


        }
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

        // ..and if the GameObject you intersect has the tag 'Pick Up' assigned to it..
        if (other.gameObject.CompareTag("KeyPickUp"))
        {
            other.gameObject.SetActive(false);
            
            key = true;

            // Run the 'SetCountText()' function (see below)
            SetKeyText();
        }
        
        if (other.gameObject.CompareTag("End"))
        {
            if(key)
            {
                Debug.Log(key);
                winText.text = "Game finished with " + count.ToString() + " donuts";
            }
        }
    }


    void SetCountText()
    {
        // Update the text field of our 'countText' variable
        countText.text = "Donut: " + count.ToString();
    }

    void SetKeyText()
    {
        // Update the text field of our 'countText' variable
        keyText.text = "You have the key!";
    }
}
