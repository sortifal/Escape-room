using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControll : MonoBehaviour
{
    // Start is called before the first frame update
    private string MoveInputAxis = "Vertical";
    private string TurnInputAxis = "Horizontal";

    // rotation that occurs in angles per second holding down input
    public float rotationRate = 360;

    // units moved per second holding down move input
    public float moveSpeed = 2;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        float moveAxis = Input.GetAxis(MoveInputAxis);
        float turnAxis = Input.GetAxis(TurnInputAxis);

        ApplyInput(moveAxis, turnAxis);
    }

    private void ApplyInput(float moveInput,
                            float turnInput)
    {
        Move(moveInput);
        Turn(turnInput);
    }

    private void Move(float input)
    {
        rb.AddForce(transform.forward * input * moveSpeed, ForceMode.Force);
    }

    private void Turn(float input)
    {
        if (Input.GetAxis("Mouse X") < 0)
            transform.Rotate(Vector3.up * rotationRate * Input.GetAxis("Mouse X"));
        if (Input.GetAxis("Mouse X") > 0)
            transform.Rotate(Vector3.up * rotationRate * Input.GetAxis("Mouse X"));
    }
}
