using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Star star;
    public float spread;
    public float rate;
    public float speed;

    private void Start()
    {
        StartCoroutine(Spawn());
    }
    IEnumerator Spawn()
    {
        Star newStar = Instantiate(star, transform.parent);
        newStar.transform.localPosition = new Vector3(Random.Range(-spread, spread), Random.Range(-spread, spread), 0)*10;
        newStar.transform.right = (transform.TransformPoint(Vector3.zero) - newStar.transform.position)*-1;
        newStar.speed = speed;
        newStar.transform.localScale *= Random.Range(0.1f, 0.5f);

        yield return new WaitForSeconds(1/rate);
        StartCoroutine(Spawn());
    }
}
