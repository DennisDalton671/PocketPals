﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleManager : MonoBehaviour
{
    public BattleMenu currentMenu;
    [Header("Selection")]
    public GameObject SelectionMenu;
    public GameObject SelectionInfo;
    public Text SelectionInfoText;
    public Text fight;
    private string fightT;
    public Text bag;
    private string bagT;
    public Text pokemon;
    private string pokemonT;
    public Text run;
    private string runT;

    [Header("Moves")]
    public GameObject movesMenu;
    public GameObject movesDetails;
    public Text PP;
    
    public Text pType;
    public Text Move1;
    private string Move1T;
    public Text Move2;
    private string Move2T;
    public Text Move3;
    private string Move3T;
    public Text Move4;
    private string Move4T;

    [Header("Info")]
    public GameObject InfoMenu;
    public Text InfoText;

    [Header("Misc")]
    public int currentSelection;


    // Start is called before the first frame update
    void Start()
    {
       fightT = fight.text;
       bagT = bag.text; 
       pokemonT = pokemon.text;
       runT = run.text;

       Move1T = Move1.text;
       Move2T = Move2.text;
       Move3T = Move3.text;
       Move4T = Move4.text;
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.DownArrow)) {
            if(currentSelection<4) {
                currentSelection++;
            }
       } 
       if(Input.GetKeyDown(KeyCode.UpArrow)) {
            if(currentSelection>0) {
                currentSelection--;
            }
       }
       if(currentSelection == 0)
       currentSelection = 1;

       switch(currentMenu) {
            case BattleMenu.Fight:
                switch(currentSelection) {
                    case 1:
                        Move1T = "> " + Move1.text;
                        Move2T = Move2.text;
                        Move3T = Move3.text;
                        Move4T = Move4.text;
                        break;
                    case 2:
                        Move1T = Move1.text;
                        Move2T = "> " + Move2.text;
                        Move3T = Move3.text;
                        Move4T = Move4.text;
                        break;
                    case 3:
                        Move1T = Move1.text;
                        Move2T = Move2.text;
                        Move3T = "> " + Move3.text;
                        Move4T = Move4.text;
                        break;
                    case 4:
                        Move1T = Move1.text;
                        Move2T = Move2.text;
                        Move3T = Move3.text;
                        Move4T = "> " + Move4.text;
                        break;               
                }
                break;
            case BattleMenu.Selection:
                switch(currentSelection) {
                    case 1:
                        fightT = "> " + fight.text;
                        bagT = bag.text;
                        pokemonT = pokemon.text;
                        runT = run.text;
                        break;
                    case 2:
                        fightT = fight.text;
                        bagT = "> " + bag.text;
                        pokemonT = pokemon.text;
                        runT = run.text;
                        break;
                    case 3:
                        fightT = fight.text;
                        bagT = bag.text;
                        pokemonT = "> " + pokemon.text;
                        runT = run.text;
                        break;
                    case 4:
                        fightT = fight.text;
                        bagT = bag.text;
                        pokemonT = pokemon.text;
                        runT = "> " + run.text;
                        break;               
                }
                break;    
       }
    }

    public void changeMenu(BattleMenu m) {
        currentMenu = m;
        currentSelection = 1;
        switch(m) {
            case BattleMenu.Selection:
                SelectionMenu.gameObject.SetActive(true);
                SelectionInfo.gameObject.SetActive(true);
                movesMenu.gameObject.SetActive(false);
                movesDetails.gameObject.SetActive(false);
                InfoMenu.gameObject.SetActive(false);
                break;
            case BattleMenu.Fight:
                SelectionMenu.gameObject.SetActive(false);
                SelectionInfo.gameObject.SetActive(false);
                movesMenu.gameObject.SetActive(true);
                movesDetails.gameObject.SetActive(true);
                InfoMenu.gameObject.SetActive(false);
                break;    
            case BattleMenu.Info:
                SelectionMenu.gameObject.SetActive(true);
                SelectionInfo.gameObject.SetActive(true);
                movesMenu.gameObject.SetActive(false);
                movesDetails.gameObject.SetActive(false);
                InfoMenu.gameObject.SetActive(true);
                break;    
        }
    }
}
public enum BattleMenu {
    Selection,
    Pokemon,
    Bag,
    Fight,
    Info
}