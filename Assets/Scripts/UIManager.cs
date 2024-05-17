using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private GameManager gameManager;
    [SerializeField] private Button left;
    [SerializeField] private Button right;
    [SerializeField] private TextMeshProUGUI name;
    [SerializeField] private TextMeshProUGUI description;
    [SerializeField] private Image image;
    [SerializeField] private Image color;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        left.onClick.AddListener(gameManager.GoLeft);
        right.onClick.AddListener(gameManager.GoRight);
    }

    public void ChangeTo(string name, string type, Sprite sprite, Color color)
    {
        this.name.text = name;
        description.text = type;
        image.sprite = sprite;
        this.color.color = color;
    }
}
