using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;

namespace YergoScripts.InputSystem
{
    [CreateAssetMenu(menuName = "YergoScripts/InputSystem/InputHandler", fileName = "New InputHandler")]
    public class InputHandler : ScriptableObject
    {
        [SerializeField]
        InputActionAsset _InputActionAsset;

        Dictionary<InputAction, InputActionEvent> _InputActionEvents = new Dictionary<InputAction, InputActionEvent>();

        List<InputAction> _InputActionList = new List<InputAction>();
        
        public InputAction this[string actionMapName, string actionName]
        {
            get 
            {
                //InputActionEvent inputActionEvent = null;
                InputAction inputAction = GetInputAction(actionMapName, actionName);

                if(inputAction != null)
                {
                    // if(_InputActionEvents.ContainsKey(inputAction))
                    //     inputActionEvent = _InputActionEvents[inputAction];

                    // else
                    // {
                    //     inputActionEvent = new InputActionEvent(inputAction);

                    //     _InputActionEvents.Add(inputAction, inputActionEvent);
                    // }

                    if(!_InputActionList.Contains(inputAction))
                        _InputActionList.Add(inputAction);

                }

                //return inputActionEvent;

                return inputAction;
            }
        }

        public class InputActionEvent
        {
            InputAction _InputAction;
            
            public event Action<InputAction.CallbackContext> started;
            public event Action<InputAction.CallbackContext> performed;
            public event Action<InputAction.CallbackContext> canceled;

            public InputActionEvent(InputAction inputAction)
            {
                _InputAction = inputAction;

                _InputAction.started += started;
                _InputAction.performed += performed;
                _InputAction.canceled += canceled;
            }
        }

        void OnDisable() 
        {
            _InputActionEvents.Clear();

            _InputActionList.Clear();
        }

        InputActionMap GetInputActionMap(string actionMapName)
        {
            InputActionMap actionMap = null;

            try
            {
                actionMap = _InputActionAsset.actionMaps.First(m => m.name == actionMapName);
                
            }

            catch
            {
                Debug.LogError("InputHandlerError: Action Map Name " + actionMapName + " does not exist!");
            }

            return actionMap;
        }

        InputAction GetInputAction(string actionMapName, string actionName)
        {
            InputAction action = null;
            InputActionMap actionmap = GetInputActionMap(actionMapName);

            if(actionmap == null)
                return null;

            try 
            {
                action = actionmap.actions.First(a => a.name == actionName);
            }

            catch
            {
                Debug.LogError("InputHandlerError: Action Name \"" + actionName + "\" does not exist!");
            }

            return action;
        }

        public void Enable(string actionMapName) => GetInputActionMap(actionMapName)?.Enable();
        public void Enable(string actionMapName, string actionName) => GetInputAction(actionMapName, actionName)?.Enable();
        
        public void Disable(string actionMapName) => GetInputActionMap(actionMapName)?.Disable();
        public void Disable(string actionMapName, string actionName) => GetInputAction(actionMapName, actionName)?.Disable();
    }
}