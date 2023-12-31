using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowManager : MonoBehaviour
{
    public float speed;
    public Vector3 dir;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * dir * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Hand"))
        {
            GameManager.instance.KillPlayer();
        }
    }
}
