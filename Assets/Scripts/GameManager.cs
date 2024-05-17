using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField] PotionsSO[] potions;
    
    private int numberOfPotion;
    private UIManager uiManager;

    // Start is called before the first frame update
    void Start()
    {
        uiManager = FindObjectOfType<UIManager>();
        numberOfPotion = 0;
        ChangePotion();
    }

    public void GoLeft()
    {
        numberOfPotion--;
        if (numberOfPotion < 0) numberOfPotion = potions.Length-1;
        ChangePotion();
    }

    public void GoRight()
    {
        numberOfPotion++;
        if (numberOfPotion >= potions.Length) numberOfPotion = 0;
        ChangePotion();
    }

    private void ChangePotion()
    {
        uiManager.ChangeTo(potions[numberOfPotion].name, potions[numberOfPotion].type, potions[numberOfPotion].image, potions[numberOfPotion].color);
    }

}
