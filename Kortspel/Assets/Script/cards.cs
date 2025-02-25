using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using System;


public class Cards
{
    //these variables are case sensitive and must match the strings in the JSON.
    [JsonProperty("name")]
    private string name;

    [JsonProperty("type")]
    private string type;

    [JsonProperty("mana")]
    private int mana;

    [JsonProperty("hp")]
    private int hp;

    [JsonProperty("attack")]
    private int attack;

    [JsonProperty("tribe")]
    private string tribe;

    [JsonProperty("description")]
    private string description;

    [JsonProperty("keywords")]
    private string keywords;

    [JsonProperty("path")]
    private string path;

    private bool hasAttacked;

    public Cards(string Name, string Type, int Mana, int Hp, int Attack, string Tribe, string Description, string Keywords, string Path)
    {
        name = Name;
        type = Type;
        mana = Mana;
        hp = Hp;
        attack = Attack;
        tribe = Tribe;
        description = Description;
        hasAttacked = false;
        keywords = Keywords;
        path = Path;
    }

    public Cards()
    {
        name = "";
        type = "";
        mana = -1;
        hp = -1;
        attack = -1;
        tribe = "";
        description = "";
        hasAttacked = false;
        keywords = "";
        path = "";
    }

    public string getName() { return name; }
    public string getType() { return type; }
    public int getMana() { return mana; }
    public int getHp() { return hp; }
    public int getAttack() { return attack; }
    public string getTribe() { return tribe; }
    public string getDescription() { return description; }
    public bool getHasAttacked() { return hasAttacked; }
    public string getKeywords() { return keywords; }
    public string getPath() { return path; }

    public void setValues(string Name, string Type, int Mana, int Hp, int Attack, string Tribe, string Description, string Keywords, string Path)
    {
        name = Name;
        type = Type;
        mana = Mana;
        hp = Hp;
        attack = Attack;
        tribe = Tribe;
        description = Description;
        keywords = Keywords;
        path = Path;
    }

    public void setAttack(int arg)
    {
        attack = arg;
    }
    public void setHp(int arg)
    {
        hp = arg;
    }

    public void setHasAttacked()
    {
        if (hasAttacked)
        {
            hasAttacked = false;
        }
        else hasAttacked = true;
    }
}
