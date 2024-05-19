using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

using UnityEngine.SceneManagement;

public class GameBehavior : MonoBehaviour
{
    //Establishes max number of items in game
    public int MaxItems = 4;
    //creates variables for the TMP Text GUI used
    public TMP_Text HealthText;
    public TMP_Text ItemText;
    public TMP_Text ProgressText;
    
    void Start()
    {
        ItemText.text += _itemsCollected;
        HealthText.text += _playerHP;
    }
    public Button WinButton;
    private int _itemsCollected = 0;
    public int Items
    {
        // 2
        get { return _itemsCollected; }
        // 3
        set
        {
            _itemsCollected = value;
            // 5
            ItemText.text = "Items Collected: " + Items;
            // 6
            if (_itemsCollected >= MaxItems)
            {
                ProgressText.text = "You've found all the items!";
                WinButton.gameObject.SetActive(true);
                
            }
            else
            {
                ProgressText.text = "Item found, only " + (MaxItems - _itemsCollected) + " left!";
                
            }
        }
    }
 
    // 4
    private int _playerHP = 10;
    public int HP
    {
        get { return _playerHP; }
        set
        {
            _playerHP = value;
            HealthText.text = "Player Health: " + HP;
            Debug.LogFormat("Lives: {0}", _playerHP);

        }
    }

}
