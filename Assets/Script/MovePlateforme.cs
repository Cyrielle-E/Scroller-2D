
using UnityEngine;

namespace Prebab
{
    
}

public class MovePlateforme : MonoBehaviour
{
    public float Vitesse = 3;
    public Vector2 Offset = new Vector2(-3, 3);

    private int direction = 1;


    void Update()
    {

        if (transform.position.y > Offset.y)
            direction = -1;
        else if (transform.position.y < Offset.x)
            direction = 1;


        transform.position = transform.position + new Vector3(0, Vitesse * direction * Time.deltaTime, 0);
    }
}    