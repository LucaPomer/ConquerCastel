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
        // Start is called before the first frame update
        void Start()
        {
            buttonOfItemSlot = GetComponent<Button>();
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        

        public void SetItemImage(Sprite toSet)
        {
            itemImage.sprite = toSet;
        }

        public void SetPrefabToSpawn(GameObject toSpawn)
        {
            prefabToBeSpawned = toSpawn;
        }

        public bool GetSelectedStatus()
        {
            return selected;
        }

        public void ChangeSelectStatus()
        {
            selected = !selected;
            Debug.Log("select status "+ selected);
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
