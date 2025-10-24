using UnityEngine;

public class SpikeMovement : MonoBehaviour
{
    public float startY;   
    public bool up = true;
    void Start()
    {
        startY = transform.position.y;
    }

    void Update()
    {
       

            if (up) transform.position += new Vector3(0, 0.002f, 0);
        else transform.position -= new Vector3(0, 0.002f, 0);

        if (transform.position.y > startY +0.08f ) up = false;
        if (transform.position.y < startY -0.9f) up = true;
    }
}
