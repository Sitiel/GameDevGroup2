﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Resources : MonoBehaviour {
    public Text goldText;
    public Text foodText;
    public Text woodText;
    public Text stoneText;

    public int gold = 100;
    public int food = 0;
    public int wood = 0;
    public int stone = 0;

	// Use this for initialization
	void Start () {
        goldText.text = "Gold: " + gold.ToString();
        foodText.text = "Food: " + food.ToString();
        woodText.text = "Wood: " + wood.ToString();
        stoneText.text = "Stone: " + stone.ToString();
	}


    public void updateGold(int g){
        gold += g;
        goldText.text = "Gold: " + gold.ToString();
    }

    public void updateFood(int f){
        food += f;
        foodText.text = "Food: " + food.ToString();
    }

    public void updateWood(int w){
        wood += w;
        woodText.text = "Wood: " + wood.ToString();
    }

    public void updateStone(int s){
        stone += s;
        stoneText.text = "Stone: " + stone.ToString();
    }
}