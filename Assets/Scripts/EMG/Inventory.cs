using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
   private Canvas canvas;

	public GameObject player;

	public Transform inventorySlots;

	private Slot[] slots;

	void Start()
	{
		canvas = GetComponent<Canvas>();
		canvas.enabled = false;
		items = player.GetComponent<Items>();
		slots = inventorySlots.GetComponentsInChildren<Slot>();
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.I))
		{
			UpdateUI();
			canvas.enabled = !canvas.enabled;
		}


	}

	void UpdateUI()
	{
		for (int i = 0; i < slots.Length; i++)
		{
			bool active = false;
			if (items.hasItems[i])
			{
				active = true;
			}

			slots[i].UpdateSlot(active);
		}
	}
}
