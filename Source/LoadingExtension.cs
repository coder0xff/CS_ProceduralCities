using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ColossalFramework.Plugins;
using ColossalFramework.UI;
using ICities;
using UnityEngine;
using Object = UnityEngine.Object;

namespace ProceduralCities {
    public class LoadingExtension : LoadingExtensionBase {
        private GenerateButton button; 

        public override void OnCreated(ILoading loading) {
            base.OnCreated(loading);
            DebugOutputPanel.AddMessage(PluginManager.MessageType.Message, "LoadingExtension.OnCreated");
        }

        public override void OnLevelLoaded(LoadMode mode) {
            base.OnLevelLoaded(mode);
            DebugOutputPanel.AddMessage(PluginManager.MessageType.Message, "LoadingExtension.OnLevelLoad");
            button = (GenerateButton)UIView.GetAView().AddUIComponent(typeof(GenerateButton));
            var go = new GameObject("procedural_cities");
        }

        public override void OnReleased() {
            DebugOutputPanel.AddMessage(PluginManager.MessageType.Message, "LoadingExtension.OnReleased");
            var go = GameObject.Find("procedural_cities");
            Object.Destroy(go);
            base.OnReleased();
        }
    }
}