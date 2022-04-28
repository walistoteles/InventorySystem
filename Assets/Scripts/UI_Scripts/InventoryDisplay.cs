using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class InventoryDisplay : MonoBehaviour
{
    [SerializeField] MouseItemData mouseInventoryItem;
    protected InventorySystem inventorySystem;
    protected Dictionary<InventorySlot_UI, InventorySlot> slotDictionary;
    public InventorySystem InventorySystem => inventorySystem;
    public Dictionary<InventorySlot_UI, InventorySlot> SlotDctionary => slotDictionary;

    protected virtual void Start()
    {

    }

    public abstract void AssignSlot(InventorySystem invToDisplay);

    protected virtual void UpdateSlot(InventorySlot updateSlot) 
    {
        foreach (var slo in SlotDctionary)
        {
            if(slo.Value == updateSlot) // slot value - the "under the hood" inventory slot.
            {
                slo.Key.UpdateUISlot(updateSlot); // slot key - the UI representation of the value.
            }
        }
    }


    public void SlotClicked(InventorySlot_UI clickedSlot)
    {
        Debug.Log("sLOT Clicked");
    }
}
