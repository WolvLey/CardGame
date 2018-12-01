using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draggable : MonoBehaviour
{
    private new Rigidbody rigidbody;

    private Vector3 sourceLocation;

    // TODO: Rename variable
    private bool bTrue = true;

    private void OnMouseDrag()
    {
        rigidbody = GetComponent<Rigidbody>();

        if (bTrue)
        {
            sourceLocation = rigidbody.position;
            bTrue = false;
        }

        Vector2 mousePos = Input.mousePosition;
        Vector2 mouseWorldPos = Camera.main.ScreenToWorldPoint(mousePos);

        rigidbody.position = new Vector3(mouseWorldPos.x, mouseWorldPos.y, rigidbody.position.z);
    }

    private void OnMouseUp()
    {
        var colliders = Physics.OverlapSphere(rigidbody.position, 1f);

        if (colliders.Length > 1)
            foreach (var collider in colliders)
            {
                if (collider.gameObject.tag == "Playground") Debug.Log("hello");

            }

        rigidbody.position = sourceLocation;
        bTrue = true;
    }
}