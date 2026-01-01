using Scripts.DragDrop.Cells;
using Scripts.DragDrop.Items;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Scripts.Architecture.Managers {
    public class ManagerDragDrop : MonoBehaviour, IDragHandler, IPointerDownHandler {
        [SerializeField] private InventoryCellUI[] _InventoryCell;
        [SerializeField] private GameObject[] GameObject;
        private Item _ItemCurrent;

        public void OnDrag(PointerEventData eventData) {}

        public void OnPointerDown(PointerEventData eventData) {
        }
    }
}