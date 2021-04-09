using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class SetupLocalPlayer : NetworkBehaviour
{
    [SerializeField] GameObject FpsCam;
    [SerializeField] Transform camPlace;
    PlayerController playerController;

    Canvas canvas;
    Camera camera;
    // Start is called before the first frame update
    void Start()
    {
        playerController = GetComponent<PlayerController>();

        if (isLocalPlayer)
        {
            playerController.rb = GetComponent<Rigidbody>();

            gameObject.GetComponent<PlayerController>().enabled = true;
            Instantiate(FpsCam, camPlace);
        }
        else
        {
            gameObject.GetComponent<PlayerController>().enabled = false;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
