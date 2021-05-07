using System;
using System.Collections.Generic;
using System.Linq;

using UnityEngine;
using UnityEngine.InputSystem;

namespace ProjectAgileJet.Input
{
    [CreateAssetMenu(fileName = "InputHandler", menuName = "ProjectAgileJet/Input/InputHandler")]
    public class InputHandler : ScriptableObject
    {
        [SerializeField]
        InputActionAsset _InputActionAsset;

        Dictionary<InputAction, Action<InputAction.CallbackContext>> _StartedDictionary = new Dictionary<InputAction, Action<InputAction.CallbackContext>>();
        Dictionary<InputAction, Action<InputAction.CallbackContext>> _PerformedDictionary = new Dictionary<InputAction, Action<InputAction.CallbackContext>>();
        Dictionary<InputAction, Action<InputAction.CallbackContext>> _CanceledDictionary = new Dictionary<InputAction, Action<InputAction.CallbackContext>>();

        #region Unity Functions
        void OnDisable()
        {
            foreach(KeyValuePair<InputAction, Action<InputAction.CallbackContext>> keyValuePair in _StartedDictionary.ToArray())
                keyValuePair.Key.started -= keyValuePair.Value;

            foreach(KeyValuePair<InputAction, Action<InputAction.CallbackContext>> keyValuePair in _PerformedDictionary.ToArray())
                keyValuePair.Key.started -= keyValuePair.Value;

            foreach(KeyValuePair<InputAction, Action<InputAction.CallbackContext>> keyValuePair in _CanceledDictionary.ToArray())
                keyValuePair.Key.started -= keyValuePair.Value;

            _StartedDictionary.Clear();
            _PerformedDictionary.Clear();
            _CanceledDictionary.Clear();
        }
        #endregion

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
                Debug.LogError("InputHandlerError: Action Name " + actionName + " does not exist!");
            }

            return action;
        }

        public void Enable(string actionMapName) => GetInputActionMap(actionMapName)?.Enable();
        public void Enable(string actionMapName, string actionName) => GetInputAction(actionMapName, actionName)?.Enable();

        public void Disable(string actionMapName) => GetInputActionMap(actionMapName)?.Disable();
        public void Disable(string actionMapName, string actionName) => GetInputAction(actionMapName, actionName)?.Disable();

        public void AddStartedListener(string actionMapName, string actionName, Action<InputAction.CallbackContext> callbackEvent)
        {
            InputAction inputAction = GetInputAction(actionMapName, actionName);

            if(_StartedDictionary.ContainsKey(inputAction))
                _StartedDictionary[inputAction] += callbackEvent;

            else
            {
                inputAction.started += callbackEvent;

                _StartedDictionary.Add(inputAction, callbackEvent);
            }
        }   

        public void AddPerformedListener(string actionMapName, string actionName, Action<InputAction.CallbackContext> callbackEvent)
        {
            InputAction inputAction = GetInputAction(actionMapName, actionName);

            if(_PerformedDictionary.ContainsKey(inputAction))
                _PerformedDictionary[inputAction] += callbackEvent;

            else
            {
                inputAction.performed += callbackEvent;

                _PerformedDictionary.Add(inputAction, callbackEvent);
            }
        }  

        public void AddCanceledListener(string actionMapName, string actionName, Action<InputAction.CallbackContext> callbackEvent)
        {
            InputAction inputAction = GetInputAction(actionMapName, actionName);

            if(_CanceledDictionary.ContainsKey(inputAction))
                _CanceledDictionary[inputAction] += callbackEvent;

            else
            {
                inputAction.canceled += callbackEvent;

                _CanceledDictionary.Add(inputAction, callbackEvent);
            }
        }  

        public void RemoveStartedListener(string actionMapName, string actionName, Action<InputAction.CallbackContext> callbackEvent)
        {
            InputAction inputAction = GetInputAction(actionMapName, actionName);

            if(inputAction != null && _StartedDictionary.ContainsKey(inputAction))
            {
                Debug.Log("Remove");
                
                _StartedDictionary[inputAction] -= callbackEvent;
            }
        }
        
        public void RemovePerformedListener(string actionMapName, string actionName, Action<InputAction.CallbackContext> callbackEvent)
        {
            InputAction inputAction = GetInputAction(actionMapName, actionName);

            if(inputAction != null &&_PerformedDictionary.ContainsKey(inputAction))
                _PerformedDictionary[inputAction] -= callbackEvent;
        }
        
        public void RemoveCanceledListener(string actionMapName, string actionName, Action<InputAction.CallbackContext> callbackEvent)
        {
            InputAction inputAction = GetInputAction(actionMapName, actionName);

            if(inputAction != null &&_CanceledDictionary.ContainsKey(inputAction))
                _CanceledDictionary[inputAction] -= callbackEvent;
        }
    }
}