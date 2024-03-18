using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraSelection : MonoBehaviour
{

    [SerializeField] private CinemachineVirtualCamera virtualCamera1;
    [SerializeField] private CinemachineVirtualCamera virtualCamera2;
    [SerializeField] private CinemachineVirtualCamera virtualCamera3;

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetKeyUp(KeyCode.Keypad1))
        // {
        //     virtualCamera1.enabled = true;
        //     virtualCamera2.enabled = false;
        //     virtualCamera3.enabled = false;
        // }

        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            virtualCamera1.enabled = false;
            virtualCamera2.enabled = true;
            virtualCamera3.enabled = false;
        }

        if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            virtualCamera1.enabled = false;
            virtualCamera2.enabled = false;
            virtualCamera3.enabled = true;
        }
    }
}
