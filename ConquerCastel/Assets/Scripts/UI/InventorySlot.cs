using enums;
using TMPro;
using UniRx;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems; // Required when using Event data.

namespace UI
{
    public class InventorySlot : MonoBehaviour
    {
        public GameObject prefabToBeSpawned;

        public Image itemImage;

        public int amountAvailible;

        private Button buttonOfItemSlot;

        private bool selected;

        private InventoryItemsEnum itemType;

        private InventoryParent inventoryParentOfSlot;

        private TMP_Text amountText;

        // Start is called before the first frame update
        void Start()
        {
            amountText = GetComponentInChildren<TMP_Text>();
            buttonOfItemSlot = GetComponent<Button>();

            inventoryParentOfSlot.SelectedItem
                .Where(newValue => newValue != itemType)
                .Subscribe(newValue =>
            {
                selected = false;
                ChangeItemColor();
            });
        }

        // Update is called once per frame
        void Update()
        {
            amountText.text = amountAvailible.ToString();
        }


        public void SetItemImage(Sprite toSet)
        {
            itemImage.sprite = toSet;
        }

        public void SetPrefabToSpawn(GameObject toSpawn)
        {
            prefabToBeSpawned = toSpawn;
        }

        public void SetItemType(InventoryItemsEnum toSet)
        {
            itemType = toSet;
        }

        public InventoryItemsEnum GetItemTypeEnum()
        {
            return itemType;
        }

        public void SetInventoryParent(InventoryParent parent)
        {
            inventoryParentOfSlot = parent;
        }


        public void ChangeSelectStatus()
        {
            selected = !selected;
            if (selected)
            {
                inventoryParentOfSlot.ChangeSelectedItem(itemType);
            }
            else
            {
                inventoryParentOfSlot.ChangeSelectedItem(InventoryItemsEnum.None);
            }

            ChangeItemColor();
        }

        private void ChangeItemColor()
        {
            if (selected)
            {
                buttonOfItemSlot.GetComponent<Image>().color = Color.blue;
            }
            else
            {
                buttonOfItemSlot.GetComponent<Image>().color = Color.white;
            }
        }
    }
}