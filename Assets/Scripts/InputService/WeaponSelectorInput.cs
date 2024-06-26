using System;
using UnityEngine;
using UnityEngine.InputSystem;
using Zenject;

namespace UI
{
    class WeaponSelectorInput : IWeaponSelectorInput, IInitializable, IDisposable
    {
        private readonly MainInput.UIActions _uiActions;
        
        public event Action ShouldTogleWeaponSelector;

        public WeaponSelectorInput(MainInput.UIActions uiActions)
        {
            _uiActions = uiActions;
            _uiActions.Enable();
        }

        public void Initialize()
        {
            _uiActions.OpenWeaponSelector.performed += OpenWeaponSelector;
        }

        public void Dispose()
        {
            Debug.Log($"{GetType().Name}");

            _uiActions.OpenWeaponSelector.performed -= OpenWeaponSelector;
        }

        private void OpenWeaponSelector(InputAction.CallbackContext obj) => ShouldTogleWeaponSelector?.Invoke();
    }
}