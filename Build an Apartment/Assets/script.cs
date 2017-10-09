using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{

    [Tooltip("How tall is the player, in meters?")]
    public float height = 1.75f;

    private GameObject cameraRig;
    private Transform waypoint;

    // Use this for initialization
    void Start()
    {

        cameraRig = Camera.main.transform.parent.gameObject;
        waypoint = transform;
    }

    // Update is called once per frame
    void Update() { }

    public void MoveHere()
    {
        var destinationPosition = waypoint.transform.position + Vector3.up * height;
        var originPosition = cameraRig.transform.position;

        cameraRig.transform.position = Vector3.Lerp(originPosition, destinationPosition, 1);
    }

}