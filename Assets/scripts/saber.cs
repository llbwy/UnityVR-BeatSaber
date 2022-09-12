using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saber : MonoBehaviour
{
    public AudioSource boom;
    public Material sliceM;
    private void OnTriggerEnter(Collider other)
    {
        var hitPos = other.bounds.ClosestPoint(transform.position);
        var result = SliceUtil.slice(other.gameObject, hitPos, transform.right, sliceM);
        Destroy(other.gameObject);
        boom.Play();
        for (int i = 0; i < result.Length; i++)
        {
           
            result[i].AddComponent<Rigidbody>();
        }
        result[0].GetComponent<Rigidbody>().drag = 10;
    }
}
