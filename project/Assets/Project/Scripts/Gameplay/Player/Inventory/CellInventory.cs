using System;
using Scripts.Items;
using UnityEngine;

namespace Scripts.Player {
    [Serializable]
    public sealed class CellInventory {
        [SerializeField] private Item ItemCurrent;
        [SerializeField] private int CoustItem;

        public void SetItem(Item TypeItem,int Coust) {

        }
        public void RemoveItem() { }

        public void AddCoust(int Coust) { }
        public void RemoveCoust(int Coust) { }

    }
}