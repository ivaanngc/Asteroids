using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoAleatorio : MonoBehaviour
{
    public Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Vector2 randomForce = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
        float randIntensity = Random.Range(1f, 3.5f);
        rb.AddForce(randomForce * randIntensity, ForceMode2D.Impulse);

        transform.rotation = Quaternion.Euler(0f, 0f, Random.Range(0f, 360f));
    }
}