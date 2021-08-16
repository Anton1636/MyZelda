using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovment : MonoBehaviour
{
    public Transform target;
    public float smoothing;
    public Vector2 maxPos, minPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(transform.position != target.position)
        {
            Vector3 targePos = new Vector3(target.position.x, target.position.y, transform.position.z);

            targePos.x = Mathf.Clamp(targePos.x, minPos.x, maxPos.x);

            targePos.y = Mathf.Clamp(targePos.y, minPos.y, maxPos.y);

            transform.position = Vector3.Lerp(transform.position, targePos, smoothing);


        }
    }
}
