using UnityEngine;
using UnityEngine.UI;

public class MoneyManager : MonoBehaviour
{
    public static MoneyManager instance;
    private Text _moneyText;
    [SerializeField] private int _money;

    private int Money
    {
        get=>_money;
        set
        {
            _money = value;
            _moneyText.text = _money.ToString();
        }
    }

    private void Awake()
    {
        instance = this;
        _moneyText = transform.GetChild(1).GetComponent<Text>();
        _moneyText.text = _money.ToString();
    }
    
    ///<summary>Adds some amount of money</summary>
    public void AddMoney(int moneyToAdd)
    {
        Money+=moneyToAdd;
    }

    ///<summary>Removes some amount of money</summary>
    public void MinusMoney(int moneyToMinus)
    {
        Money-=moneyToMinus;
    }

}