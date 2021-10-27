using UnityEngine;
using UnityEngine.UI;

public class MoneyManager : MonoBehaviour
{
    public static MoneyManager instance;
    private Text _moneyText;
    [SerializeField] private int _money;

    private int MoneySystem
    {
        get=>_money;
        set{ _money = value; }
    }

    private void Awake()
    {
        instance = this;
        _moneyText = transform.GetChild(1).GetComponent<Text>();
        UpdateUiText();
    }
    
    ///<summary>Adds some amount of money</summary>
    public void AddMoney(int moneyToAdd)
    {
        _money+=moneyToAdd;
        UpdateUiText();
    }

    ///<summary>Removes some amount of money</summary>
    public void MinusMoney(int moneyToMinus)
    {
        _money-=moneyToMinus;
        UpdateUiText();
    }

    private void UpdateUiText()
    {
        _moneyText.text = _money.ToString();
    }
}