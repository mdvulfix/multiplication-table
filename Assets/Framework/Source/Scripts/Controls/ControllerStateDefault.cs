﻿using System.Collections.Generic;
using Framework.Core;

namespace Framework
{   
    public class ControllerStateDefault : AControllerState
    {
        
    public static readonly string OBJECT_NAME = "Controller: State";
    public override void Initialize()
        {
            SetSceneObject(OBJECT_NAME);
            Log(Label, "was sucsessfully initialized");
            //return this;
        } 
        
        
        public override IConfigurable Configure() 
        {                                     
            StateActive = Cache.Get<StateBuilding>();
            Log(Label, "was successfully configured.");
            return this;
        }
        
        public override void OnStateEnter(IState state)
        {

        }

        public override void OnStateExit(IState state)
        {

        }
    }
}
