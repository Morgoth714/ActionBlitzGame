﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Game.Interface;

namespace Game.UI
{
    public class RestartLevelButton : EventButton
    {
        /// <summary>
        /// Button down
        /// </summary>
        private bool _ButtonDown = false;

        /// <summary>
        /// Awake this instance
        /// </summary>
        public override void Awake()
        {
            base.Awake();
        }

        /// <summary>
        /// On Pointer Down
        /// </summary>
        public override void OnPointerDown()
        {
            base.OnPointerDown();
            this._ButtonDown = true;
        }

        /// <summary>
        /// On pointer Up
        /// </summary>
        public override void OnPointerUp()
        {
            base.OnPointerUp();
            if (!this._ButtonDown)
                return;
            this._ButtonDown = false;
            Manager.Instance.RestartLevel();
        }

        /// <summary>
        /// On Pointer Exit
        /// </summary>
        public override void OnPointerExit()
        {
            base.OnPointerExit();
            this._ButtonDown = false;
        }
    }
}