using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    int stable2Dcamera = -10;
    [SerializeField] GameObject thingToFollow;
        void Update()
    {
        transform.position = thingToFollow.transform.position + new Vector3(0,0,stable2Dcamera);
    }
}
