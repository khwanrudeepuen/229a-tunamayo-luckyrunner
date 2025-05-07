using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    
    public  void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    
    public void ExitGame()
    {
        Application.Quit();
    }

    public void GoToCredit()
    {
        SceneManager.LoadScene("Credit"); // ต้องตั้งชื่อ Scene เครดิตว่า Credit
    }
}