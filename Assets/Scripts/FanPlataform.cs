using UnityEngine;

public class FanPlataform : MonoBehaviour
{
    [Header("Configurações do Ventilador")]
    public float forcaDoVento = 350f;        // Intensidade do vento
    public Vector2 direcao = Vector2.up;    // Direção do vento (por padrão para cima)

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Rigidbody2D rb = collision.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                // Aplica uma força constante enquanto o player está dentro do fan
                rb.AddForce(direcao.normalized * forcaDoVento, ForceMode2D.Force);
            }
        }
    }
}
