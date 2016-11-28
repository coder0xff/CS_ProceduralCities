using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using ColossalFramework;
using ColossalFramework.Math;
using ColossalFramework.Plugins;
using ColossalFramework.UI;
using UnityEngine;
using UnityEngine.Networking.Types;

namespace ProceduralCities {

    class GenerateButton : UIButton {
        public override void Start() {
            base.Start();
            name = "Generate";
            size = new Vector2(50, 50);
            absolutePosition = new Vector2(50, 50);
            DebugOutputPanel.AddMessage(PluginManager.MessageType.Message, "Button started");
            normalBgSprite = "buttonclose";
            hoveredBgSprite = "buttonclosehover";
            pressedBgSprite = "buttonclosepressed";
            isInteractive = true;
            Show();

            eventClicked += OnEventClicked;
        }

        private void OnEventClicked(UIComponent component, UIMouseEventParameter param) {
            DebugOutputPanel.AddMessage(PluginManager.MessageType.Message, "clicked");
            try {
                new Builder();
            } catch (Exception exc) {
                DebugOutputPanel.AddMessage(PluginManager.MessageType.Warning, exc.ToString());
            }
        }

        public override void Update() {
            base.Update();
        }

        public void Destroy() {
            m_Parent.RemoveUIComponent(this);
        }
    }
}
