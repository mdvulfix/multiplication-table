﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Framework.Core;
using Framework.Core.Handlers;

namespace Framework
{
    public class PageScore : APage
    {
        public static readonly string OBJECT_NAME = "Page: Score";
        
        public override void Initialize()
        {
            SetParams(OBJECT_NAME);
            
            DataStats.GUID = 4;
            DataStats.IsInitialized = true;

            Log(Label, "was sucsessfully initialized");
            //return this;

        }

        public override IConfigurable Configure()
        {
            DataAnimation.UseAnimation = true;
            DataAnimation.Animator = GetComponent<Animator>();
            DataAnimation.CurrentState = ANIMATOR_STATE_NONE;
            DataAnimation.TargetState = ANIMATOR_STATE_NONE;
            
            //Activate(false);

            DataStats.IsConfigerd = true;
            Log(Label, "was sucsessfully configured");
            return this;
        }
    }
}