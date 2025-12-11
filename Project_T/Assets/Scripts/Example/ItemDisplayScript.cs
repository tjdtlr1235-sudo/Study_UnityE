using UnityEngine;

public class ItemDisplayScript : MonoBehaviour
{
    private void Start()
    {
        Table<int, ItemTableData> itemTable = TableManager.Instance.GetTable<int, ItemTableData>();

        if (itemTable == null)
        {
            Debug.LogError("TableManager가 초기화되지 않았거나 ItemTable 로드에 실패했습니다.");
            return;
        }

        foreach (int targetId in TableManager.Instance.GetAllIds(itemTable))
        {
            ItemTableData itemData = itemTable[targetId];

            if (itemData != null)
            {
                string imgResource = itemData.itemImgresource;

                Debug.Log($"ID {targetId}의 itemImgresource 값: {imgResource}");
            }
        }
    }
}