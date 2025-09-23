using UnityEngine;
using UnityEngine.SceneManagement; // Para trocar de cena

public class CheckpointType : MonoBehaviour
{
    public enum CheckType { Start, End }
    public CheckType checkpointType;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player")) return;

        if (checkpointType == CheckType.Start)
        {
            // Posiciona o player no checkpoint de início
            other.transform.position = transform.position;

        }
        else if (checkpointType == CheckType.End)
        {
            int currentIndex = SceneManager.GetActiveScene().buildIndex;

            // Se for a última fase, mostra tela de vitória
            if (currentIndex == SceneManager.sceneCountInBuildSettings - 1)
            {
                // Chama vitória (ou Game Over / créditos)
                if (GameController.instance != null)
                {
                    GameController.instance.ShowWinGame();
                }
            }
            else
            {
                // Carrega a próxima fase
                SceneManager.LoadScene(currentIndex + 1);
            }
        }
    }
}
