using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Fungsi ini akan dipanggil oleh tombol saat diklik
    public void LoadGameScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    // Pindah ke Menu Utama
    public void GoToMainMenu()
    {
        Time.timeScale = 1f; // Pastikan waktu kembali normal
        SceneManager.LoadScene("main_menu"); // Ganti dengan nama scene menu kamu
    }

    // Keluar dari Game
    public void QuitGame()
    {
        Application.Quit();
    }
}