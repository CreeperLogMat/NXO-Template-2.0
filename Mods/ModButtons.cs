using static NXOTemplate.Utilities.GunLib;
using static NXOTemplate.Utilities.Variables;
using static NXOTemplate.Utilities.ColorLib;
using static NXOTemplate.Mods.Categories.Movement;
using static NXOTemplate.Mods.Categories.Player;
using static NXOTemplate.Mods.Categories.Room;
using static NXOTemplate.Mods.Categories.Settings;
using static NXOTemplate.Menu.ButtonHandler;
using static NXOTemplate.Menu.Optimizations;
using static NXOTemplate.Menu.Optimizations.ResourceLoader;
using static NXOTemplate.Menu.Main;
using UnityEngine;
using Fusion;
using System;
using ExitGames.Client.Photon;
using Photon.Pun;
using System.Collections.Generic;
using NXOTemplate.Utilities;
using NXOTemplate.Mods.Categories;

namespace NXOTemplate.Mods
{
    public enum Category
    {
        // Starting Page
        Home,

        // Mod Categories
        Settings,
        Room,
        Player,
        Movement,
    }
    public class ModButtons
    {
        public static Button[] buttons =
        {
            #region Starting Page
            new Button("Settings", Category.Home, false, false, ()=>ChangePage(Category.Settings)),
            new Button("Room Mods", Category.Home, false, false, ()=>ChangePage(Category.Room)),
            new Button("Player Mods", Category.Home, false, false, ()=>ChangePage(Category.Player)),
            new Button("Movement Mods", Category.Home, false, false, ()=>ChangePage(Category.Movement)),
            #endregion

            #region Settings
            new Button("Switch Hands", Category.Settings, true, false, ()=>SwitchHands(true), ()=>SwitchHands(false)),
            new Button("Disconnect Button", Category.Settings, true, true, ()=>ToggleDisconnectButton(true), ()=>ToggleDisconnectButton(false)),
            new Button("Toggle Notifications", Category.Settings, true, true, ()=>ToggleNotifications(true), ()=>ToggleNotifications(false)),
            new Button("Clear Notifications", Category.Settings, false, false, ()=>ClearNotifications()),
            new Button("Disable All Mods", Category.Settings, false, false, ()=>DisableAllMods()),

            #endregion

            #region Room
            new Button("Quit Game", Category.Room, false, false, ()=>QuitGTAG()),
            new Button("Disconnect", Category.Room, false, false, ()=>Disconnect()),
            new Button("Join Random", Category.Room, false, false, ()=>JoinRandomPublic()),
            #endregion

            #region Player
            new Button("Ghost Monke (A)", Category.Player, true, false, ()=>GhostMonke()),
            new Button("Invisible Monke (A)", Category.Player, true, false, ()=>InvisibleMonke()),
            new Button("Long Arms", Category.Player, true, false, ()=>LongArms(true, new Vector3(1.3f, 1.3f, 1.3f)), ()=>LongArms(false, Vector3.zero)),
            #endregion

            #region Movement
            new Button("Flight (A)", Category.Movement, true, false, ()=>FlyMonke(false, 10)),
            new Button("Speed Boost", Category.Movement, true, false, ()=>SpeedBoost(10, 2)),
            new Button("Noclip (RT)", Category.Movement, true, false, ()=>Noclip()),
            #endregion
        };
    }
}
