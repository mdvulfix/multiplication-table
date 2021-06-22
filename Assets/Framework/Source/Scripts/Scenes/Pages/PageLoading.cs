﻿using UnityEngine;
using Core.Scene.Page;

namespace Source.Scene.Page
{

    public class PageLoading : APage
    {
        private readonly string OBJECT_NAME = "Page: Loading";
        
    
        protected override void OnAwake()
        {
            var dataAnimation = new DataAnimation();
            
            dataAnimation.UseAnimation = true;
            dataAnimation.CurrentState = ANIMATOR_STATE_NONE;
            dataAnimation.TargetState = ANIMATOR_STATE_NONE;
            dataAnimation.Animator = GetComponent<Animator>();

            var pageParams = new PageInitializationParams(dataAnimation);
            
            Initialize(pageParams);

        }
        
        protected override void OnStart()
        {
            
        }
        
        
        
        

    }
}
