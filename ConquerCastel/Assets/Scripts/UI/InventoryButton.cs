using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems; // Required when using Event data.

namespace UI
{
    public class InventoryButton : MonoBehaviour, ISelectHandler , IDeselectHandler
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
        //Do this when the selectable UI object is selected.
        public void OnSelect(BaseEventData eventData)
        {
            Debug.Log(this.gameObject.name + " was selected");
            selected = true;
        }

        public void OnDeselect(BaseEventData eventData)
        {
            Debug.Log(this.gameObject.name + " was  deselected");
            selected = false;
        }
        
        
    }
}
