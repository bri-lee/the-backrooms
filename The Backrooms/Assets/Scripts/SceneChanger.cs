using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public Button button;
    void Start()
    {
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(goToGame);
    }

    // Start is called before the first frame update
    void goToGame()
    {
        SceneManager.LoadScene("Game Scene");
    }
}
