﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StorageScrollList : MonoBehaviour
{

    public List<Item> itemList;
    public Transform contentPanel;
    public SimpleObjectPool simpleObjectPool;

    // Start is called before the first frame update
    void Start()
    {
        refreshDisplay();
    }

    public void refreshDisplay()
    {
        addButtons();
    }

    private void addButtons()
    {
        for (int i = 0; i < itemList.Count; i++)
        {
            Item item = itemList[i];
            GameObject newPlante = simpleObjectPool.GetObject();
            newPlante.transform.SetParent(contentPanel);
            InfoToShow infos = newPlante.GetComponent<InfoToShow>();
            infos.Setup(item, this);
        }
    }
}
