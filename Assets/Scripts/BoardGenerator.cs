using UnityEngine;

public class BoardGenerator : MonoBehaviour
{
    public GameObject cellPrefab; // Chỗ để nhét cái ô mẫu vào
    public int width = 10;
    public int height = 10;

    void Start()
    {
        CreateBoard();
        AdjustCamera();
    }

    void CreateBoard()
    {
        // Căn giữa bàn cờ
        Vector3 offset = new Vector3((width - 1) / 2f, (height - 1) / 2f, 0);

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                // Tạo ô mới
                GameObject cell = Instantiate(cellPrefab);
                cell.transform.position = new Vector3(x, y, 0) - offset;
                cell.transform.parent = transform; // Làm con của BoardManager
                cell.name = $"Cell {x},{y}";
            }
        }
    }

    void AdjustCamera()
    {
        // Tự chỉnh camera bao trọn bàn cờ
        Camera.main.transform.position = new Vector3(0, -2f, -10);
        Camera.main.orthographicSize = 6; // Độ zoom vừa phải
    }
}