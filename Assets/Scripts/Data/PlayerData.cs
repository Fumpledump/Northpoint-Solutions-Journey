using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData
{
    public string issue;
    public int health;
    public int score;

    public PlayerData(string issue, int health, int score)
    {
        this.issue = issue;
        this.health = health;
        this.score = score;
    }

    public override string ToString()
    {
        return $"The goal is {issue} with {health} HP and {score} points";
    }
}
