using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Assertions.Must;
using TMPro;
using UnityEngine.UI;


public class DisplayPropery : MonoBehaviour
{
    public ScripObj scripObj;



    public TextMeshProUGUI cardName;
    public TextMeshProUGUI cardDescription;
    public Image cardImage;
    public TextMeshProUGUI health;

    public TextMeshProUGUI manaCost;


    void Start()
    {
        cardName.text = scripObj.objectName;
        cardDescription.text = scripObj.descriptionOfCard;
        cardImage.sprite = scripObj.sprite;
        health.text = scripObj.health.ToString();
        manaCost.text = scripObj.manaCost.ToString();
    }
}
