using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using UnityEngine.InputSystem;
using UnityEngine;
using Object = UnityEngine.Object;
using static NXOTemplate.Utilities.ColorLib;
using static NXOTemplate.Utilities.Variables;
using static NXOTemplate.Menu.Main;
using static NXOTemplate.Menu.ButtonHandler;
using static NXOTemplate.Menu.Optimizations;
using NXOTemplate.Utilities;
using NXOTemplate.Menu;
using static NXOTemplate.Mods.Categories.Movement;
using static NXOTemplate.Utilities.Patches.OtherPatches;
using static NXOTemplate.Utilities.GunLib;
using System.Linq;

namespace NXOTemplate.Mods.Categories
{
    public class Settings
    {
        public static void SwitchHands(bool setActive)
        {
            rightHandedMenu = setActive;
        }

        public static void ClearNotifications()
        {
            NotificationLib.ClearAllNotifications();
        }

        public static void ToggleNotifications(bool setActive)
        {
            toggleNotifications = setActive;
        }

        public static void ToggleDisconnectButton(bool setActive)
        {
            toggledisconnectButton = setActive;
        }
    }
}
