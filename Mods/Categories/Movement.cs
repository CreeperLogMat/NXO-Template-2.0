using System;
using System.Collections.Generic;
using System.Text;
using static NXOTemplate.Utilities.GunLib;
using static NXOTemplate.Menu.Main;
using static NXOTemplate.Utilities.Variables;
using static NXOTemplate.Utilities.ColorLib;
using static NXOTemplate.Menu.ButtonHandler;
using static NXOTemplate.Mods.ModButtons;
using static NXOTemplate.Mods.Categories.Settings;
using UnityEngine;
using Valve.VR;
using System.Reflection;
using BepInEx;
using Photon.Voice;

namespace NXOTemplate.Mods.Categories
{
    public class Movement
    {
        public static void Noclip()
        {
            bool enableColliders = pollerInstance.rightControllerIndexFloat <= 0.1f;

            foreach (MeshCollider meshCollider in Resources.FindObjectsOfTypeAll<MeshCollider>())
            {
                meshCollider.enabled = enableColliders;
            }
        }

        public static void FlyMonke(bool useVelocity, float speed, float velocityMultiplier = 3f)
        {
            Rigidbody playerRigidbody = playerInstance.GetComponent<Rigidbody>();

            if (pollerInstance.rightControllerPrimaryButton)
            {
                if (useVelocity)
                {
                    playerRigidbody.velocity += playerInstance.headCollider.transform.forward * Time.deltaTime * speed * 3;
                }
                else
                {
                    playerInstance.transform.position += playerInstance.headCollider.transform.forward * Time.deltaTime * speed;
                    playerRigidbody.velocity = Vector3.zero;
                }
            }
        }

        public static void SpeedBoost(float speed, float multiplier)
        {
            playerInstance.maxJumpSpeed = speed;
            playerInstance.jumpMultiplier = multiplier;
        }
    }
}
