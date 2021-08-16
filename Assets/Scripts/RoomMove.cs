using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomMove : MonoBehaviour
{
    public Vector2 cameraChange;
    public Vector3 playerChange;
    private CameraMovment camera;

    // Start is called before the first frame update
    void Start()
    {
        camera = Camera.main.GetComponent<CameraMovment>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            camera.minPos += cameraChange;
            camera.maxPos += cameraChange;
            other.transform.position += playerChange;
        }
    }
}
