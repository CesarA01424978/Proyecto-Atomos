using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrastraAtomo : MonoBehaviour
{
    private Vector3 offset;
    private bool isDragging = false;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true; // Desactiva la física mientras se arrastra.
    }

    private void OnMouseDown()
    {
        isDragging = true;
        offset = transform.position - GetMouseWorldPos();
    }

    private void OnMouseUp()
    {
        isDragging = false;
        //rb.isKinematic = false; // Reactiva la física cuando se suelta el objeto.
    }

    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = -Camera.main.transform.position.z;
        //return mousePosition;
        return Camera.main.ScreenToWorldPoint(mousePosition);
    }

    private void Update()
    {
        if (isDragging)
        {
            Vector3 targetPos = GetMouseWorldPos() + offset;
            targetPos.z = transform.position.z; // Mantén la posición Z original
            rb.MovePosition(targetPos);
        }
    }
}
