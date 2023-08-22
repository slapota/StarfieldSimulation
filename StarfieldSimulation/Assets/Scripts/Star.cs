using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    public float speed;
    public float despawnDistance;
    public float stretch;

    private void Update()
    {
        float distance = Vector3.Distance(transform.localPosition, Vector3.zero);
        transform.localPosition += transform.right * speed * Time.deltaTime * distance;

        transform.localScale = new Vector2(1*distance*stretch, 1);

        if (distance > despawnDistance)Destroy(gameObject);
    }
}
