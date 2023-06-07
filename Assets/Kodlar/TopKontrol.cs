using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;


public class TopKontrol : MonoBehaviour
{
    Rigidbody rb;
    public int hiz;
    int puan = 0;
    
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {

    }

    void FixedUpdate()
    {
        float yatay = Input.GetAxis("Horizontal");
        float dikey = Input.GetAxis("Vertical");
        Vector3 v = new Vector3(yatay, 0, dikey);
        rb.AddForce(v * hiz);

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "yenecekNesne")
        {
            Destroy(other.gameObject);
            puan++;
            
            Debug.Log(puan);
            if (puan == 11)
            {
                
                Debug.Log(puan);
            }

        }
        else if (other.gameObject.tag == "yem2")
        {
            Destroy(other.gameObject);
            UnityEditor.EditorApplication.isPlaying = false;

        }
    }
}