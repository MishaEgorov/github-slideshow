using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Indicator : MonoBehaviour
{
    public float StandartSize;
    public GameObject TrackedObj;
    public Vector3 StartPoint;

    private bool Track=true;
    private Camera cam;

    private void Start()
    {
        cam = Camera.main;
    }

    private void Update()
    {        
        if (Track)
        {
            if (TrackedObj.gameObject == null)
            {
                Destroy(gameObject);
                return;
            }

            var hit = Physics2D.Raycast(StartPoint, TrackedObj.transform.position - StartPoint, 200000, 1 << 8);

            if (hit.collider == null)
            { 
                return;            
            }

            switch (hit.collider.name)
            {
                case "Up":
                    transform.position = hit.point + new Vector2(0, -0.1f);
                    break;

                case "Right":
                    transform.position = hit.point + new Vector2(-0.1f, 0);
                    break;

                case "Left":
                    transform.position = hit.point + new Vector2(0.1f, 0);
                    break;

                case "Down":
                    transform.position = hit.point + new Vector2(0, 0.1f);
                    break;
            }

        /*    var size = StandartSize - Vector2.Distance(hit.point, TrackedObj.transform.position)/40;

            if (size <= 1f)
            { 
                size = 1f;
            }

            transform.localScale = new Vector2(size, size);
        */
        }
    }

    public void Switch(bool enabled)
    {
        Track = enabled;
        GetComponent<SpriteRenderer>().enabled = enabled;
    }

}
