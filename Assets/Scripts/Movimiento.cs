using UnityEngine;
using UnityEngine.InputSystem;

public class personagecontrolador : MonoBehaviour
{
    private Rigidbody2D rb;
    public float velocidadmovimiento;
    private Vector2 inputMovimiento;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        procesarMovimiento();
    }
    void procesarMovimiento()
    {
        float movex = Input.GetAxis("Horizontal");
        float movey = Input.GetAxis("Vertical");
        inputMovimiento = new Vector2(movex, movey).normalized;

        rb.position = (rb.position + inputMovimiento * velocidadmovimiento * Time.deltaTime);
    }
}
