using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    private GameObject _winPanel;
    private GameObject _losePanel;

    private void Awake()
    {
        instance = this;

        _winPanel = transform.GetChild(0).gameObject;
        _losePanel = transform.GetChild(1).gameObject;
    }
    
    ///<summary>Sets game core UI status. true - win, false - lost</summary>
    public void CheckGameState(bool canWin)
    {
        if(canWin == true)
        {
            _winPanel.SetActive(true);
        }
        else
        {
            _losePanel.SetActive(true);
        }
        
        Time.timeScale = 0;
    }

    #region UIButtons
    ///<summary>Reloads current game level</summary>
    public void RestartLevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    #endregion
}
