using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.XR;

public class DrumstickController : MonoBehaviour
{
    public GameObject drumstickPrefab;

    void Update()
    {
        List<InputDevice> devices = new List<InputDevice>();
        InputDevices.GetDevices(devices);

        foreach (var device in devices)
        {
            if (device.characteristics.HasFlag(InputDeviceCharacteristics.Controller))
            {
                drumstickPrefab.SetActive(true);
            }
            if (!device.characteristics.HasFlag(InputDeviceCharacteristics.Controller))
            {
                drumstickPrefab.SetActive(false);
            }
        }
    }
}

