using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class OpenTresureBox : MonoBehaviour
{

    public GameObject topBox;
    Vector3 TopPartOfBox;
    Vector3 KeyAfterColidingPos;
    Vector3 KeyAfterColidingRot;

    private int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "key_silver" && count == 0)
        {
            TopPartOfBox = new Vector3(-45.0f, 0.0f, 0.0f);
            KeyAfterColidingPos = new Vector3(-5.1722f, -3.066f, -11.4463f);
            KeyAfterColidingRot = new Vector3(177f, 23.2f, -71.32f);

            topBox.transform.Rotate(TopPartOfBox);

            Destroy(other.GetComponent<XRGrabInteractable>());

            other.transform.position = KeyAfterColidingPos;
            other.transform.Rotate(KeyAfterColidingRot);
            
            count = 1;
        }
    }
}
