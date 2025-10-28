using UnityEngine;

public class SpikeMovementTop : MonoBehaviour
{
    public float startY;
    public bool up = true;
    void Start()
    {
        startY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (up) transform.position += new Vector3(0, 2f, 0);
        else transform.position -= new Vector3(0, 2f, 0);

        if (transform.position.y > startY + 0.9f) up = false;
        if (transform.position.y < startY- 0.08f) up = true;
    }
}
