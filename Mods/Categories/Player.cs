using System;
using System.Collections.Generic;
using System.Text;
using static NXOTemplate.Utilities.GunLib;
using static NXOTemplate.Utilities.ColorLib;
using static NXOTemplate.Utilities.Variables;
using static NXOTemplate.Menu.Main;
using static NXOTemplate.Mods.Categories.Settings;
using UnityEngine;
using UnityEngine.InputSystem;
using NXOTemplate.Utilities;
using UnityEngine.XR;
using UnityEngine.Animations.Rigging;
using UnityEngine.XR.Interaction.Toolkit;
using GorillaNetworking;
using NXOTemplate.Utilities.Patches;
using NXOTemplate.Menu;
using ExitGames.Client.Photon;
using Photon.Pun;
using Photon.Realtime;
using HarmonyLib;

namespace NXOTemplate.Mods.Categories
{
    public class Player
    {
        // General toggle and state variables
        private static bool isOn = false;
        private static bool wasButtonPressed = false;

        public static bool isOn2 = false;
        private static bool wasButtonPressed2 = false;

        public static void GhostMonke()
        {
            bool isButtonCurrentlyPressed = pollerInstance.rightControllerPrimaryButton;
            if (!wasButtonPressed && isButtonCurrentlyPressed)
            {
                isOn = !isOn;
            }

            wasButtonPressed = isButtonCurrentlyPressed;

            if (isOn)
            {
                taggerInstance.offlineVRRig.enabled = false;
            }
            else
            {
                taggerInstance.offlineVRRig.enabled = true;
            }
        }

        public static void InvisibleMonke()
        {
            bool isButtonCurrentlyPressed = pollerInstance.rightControllerPrimaryButton;
            if (!wasButtonPressed && isButtonCurrentlyPressed)
            {
                isOn = !isOn;
            }

            wasButtonPressed = isButtonCurrentlyPressed;

            if (isOn)
            {
                taggerInstance.offlineVRRig.enabled = false;
                taggerInstance.offlineVRRig.transform.position = new Vector3(999f, 999f, 999f);
            }
            else
            {
                taggerInstance.offlineVRRig.enabled = true;
            }
        }

        public static void LongArms(bool setActive, Vector3 armLength)
        {
            if (setActive)
            {
                playerInstance.transform.localScale = armLength;
            }
            else
            {
                playerInstance.transform.localScale = Vector3.one;
            }
        }
    }
}
