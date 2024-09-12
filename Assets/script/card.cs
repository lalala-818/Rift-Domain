using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Card : MonoBehaviour
{
    public int cardID; // 卡牌ID
    public string cardType; // 卡牌类型
    public string cardName; // 卡牌名称
    public string description; // 卡牌描述
    public int manaCost; // 法力消耗
    public int attack; // 攻击力
    public int health; // 生命值
    public Sprite artwork; // 卡牌图像

}
