using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollows : MonoBehaviour
{
    [SerializeField]
    private GameObject objectToFollow;
    private bool Follow = false;
    private Vector3 distacne;
    // Use this for initialization
    void Start()
    {
        distacne = this.transform.position - objectToFollow.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Follow == true)
        {
            this.transform.position = distacne + objectToFollow.transform.position;
        }
    }
    public void Trigger()
    {
        Follow = true;
    }
}