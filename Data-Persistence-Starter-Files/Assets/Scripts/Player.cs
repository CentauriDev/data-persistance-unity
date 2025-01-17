using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Player 
{
    public string name ;// Start is called before the first frame update
    public int score;

    public Player(string name, int score)
    {
        this.name = name;
        this.score = score;
    }
}
