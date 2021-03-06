﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jimi.Lobby
{
    public class MainMenu : MonoBehaviour
    {
        [SerializeField] private NetworkManagerLobby networkManager = null;

        [Header("UI")]
        [SerializeField] private GameObject landingPagePanel = null;

        //Host Lobby
        public void HostLobby()
        {
            networkManager.StartHost();

            landingPagePanel.SetActive(false);
        }

    }
}

