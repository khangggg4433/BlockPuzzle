using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // Phương thức này sẽ được gọi bởi nút "New Game"
    public void StartNewGame()
    {
        // Tải scene game chính.
        // Hãy chắc chắn rằng "SampleScene" đã được thêm vào Build Settings.
        SceneManager.LoadScene("SampleScene");
    }

    // Phương thức này sẽ được gọi bởi nút "Continue"
    public void ContinueGame()
    {
        // Hiện tại, chức năng này sẽ bắt đầu một game mới.
        // Bạn có thể thêm logic để tải lại game đã lưu ở đây.
        Debug.Log("Nút Continue đã được nhấn. Tạm thời sẽ bắt đầu game mới.");
        SceneManager.LoadScene("SampleScene");
    }

    // Phương thức này sẽ được gọi bởi nút "High Score"
    public void ShowHighScore()
    {
        // Đây là chức năng chờ. Bạn có thể tạo một scene mới hoặc một UI panel để hiển thị điểm cao.
        Debug.Log("Nút High Score đã được nhấn. Cần cài đặt màn hình điểm cao.");
    }

    // Phương thức này sẽ được gọi bởi nút "Instructions"
    public void ShowInstructions()
    {
        // Đây là chức năng chờ. Bạn có thể tạo một scene mới hoặc một UI panel để hiển thị hướng dẫn.
        Debug.Log("Nút Instructions đã được nhấn. Cần cài đặt màn hình hướng dẫn.");
    }

    // Phương thức này sẽ được gọi bởi nút "Exit"
    public void QuitGame()
    {
        // Thoát ứng dụng.
        // Chức năng này chỉ hoạt động khi game đã được build, không hoạt động trong Unity Editor.
        Debug.Log("Nút Quit đã được nhấn.");
        Application.Quit();
    }
}
