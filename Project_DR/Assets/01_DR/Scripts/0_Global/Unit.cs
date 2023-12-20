using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 플레이어에게 특정한 명령을 실행하는 클래스
public static class Unit
{
    /*************************************************
     *                 Public Methods
     *************************************************/
    // 인벤토리에 아이템을 추가
    public static void AddInventoryItem(int id, int amount = 1)
    {
        ItemManager.instance.InventoryCreateItem(Vector3.zero, id, amount);
    }

    // 필드에 아이템을 생성
    public static void AddFieldItem(Vector3 pos, int id, int amount = 1)
    {
        ItemManager.instance.CreateItem(pos, id, amount);
    }
}
