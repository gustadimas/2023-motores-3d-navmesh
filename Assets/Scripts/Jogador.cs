using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Jogador : MonoBehaviour
{
    [SerializeField] float velocidade;
    Rigidbody rb;
    Vector2 direcaoMovimento;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        direcaoMovimento = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        rb.MovePosition(rb.position + new Vector3(direcaoMovimento.x, 0, direcaoMovimento.y) * velocidade * Time.fixedDeltaTime);
    }
}
