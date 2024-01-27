using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BarController : MonoBehaviour
{
    public AnimationCurve rotationCurve = AnimationCurve.Linear(0, 0, 10, 10);
    public float rotationSpeed;

    private void Update()
    {
        // Input: Puoi utilizzare Input.GetAxis("Horizontal") o altri metodi per ottenere l'input desiderato
        float input = -Input.GetAxis("Horizontal");

        // Calcola l'angolo di rotazione basato sulla curva e sulla velocità
        float rotationAngle = rotationCurve.Evaluate(Mathf.Abs(input)) * rotationSpeed * Mathf.Sign(input);

        // Ruota la barra
        transform.Rotate(Vector3.forward, rotationAngle * Time.deltaTime);
    }
}