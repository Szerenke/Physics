using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject plyaer;
    [SerializeField] private Vector3 offset = new Vector3(0, 1, 4.2f);

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = plyaer.transform.position + offset;
    }
}
