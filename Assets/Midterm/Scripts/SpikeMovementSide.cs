using UnityEngine;

public class SpikeMovementSide : MonoBehaviour
{
    public float startX;
    public bool up = true;
    void Start()
    {
        startX = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (up) transform.position += new Vector3(0.002f, 0, 0);
        else transform.position -= new Vector3(0.002f, 0, 0);

        if (transform.position.y > startX + 0.9f) up = false;
        if (transform.position.y < startX - 0.08f) up = true;
    }
}