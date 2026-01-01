using Scripts.DragDrop.Items;
using System;
using UnityEngine;

namespace Scripts.DragDrop.Cells {
    public class InventoryCellUI : MonoBehaviour {
        [SerializeField] private Item _ItemCurrent;
        [SerializeField] private int _Count;

        public void SetItem(Item item, int _Count) { }
        public void DeleteItem(Item item, int _Count) { }

        public Item GetItemCurrent() => _ItemCurrent;

        public Action ItemDelete;
    }
}