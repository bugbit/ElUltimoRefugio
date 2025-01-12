using UnityEngine;

public class controlador : MonoBehaviour
{
    public float velocidad;
    private Rigidbody2D rb;
    private Vector2 inputSistema;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float movex = Input.GetAxis("Horizontal");
        float movey = Input.GetAxis("Vertical");
        inputSistema = new Vector2(movex, movey);
    }
    private void FixedUpdate()
    {
        rb.position = (rb.position + inputSistema * velocidad * Time.deltaTime);
    }
}
