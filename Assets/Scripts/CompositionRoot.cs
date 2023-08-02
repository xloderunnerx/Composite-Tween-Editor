using App.Features.TweenEditor;
using Composite.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace App
{
    public class CompositionRoot : AbstractCompositionRoot
    {
        private void Awake()
        {
            BindConfigurations();
            BindSignalBus();
            BindFeatures();
        }

        private void Start()
        {
            DeclareSignals();
            SubscribeToSignals();
            InitializeControllers();
        }

        private void Update()
        {
            UpdateControllers();
        }

        public void BindFeatures()
        {
            BindFeature<TweenEditorFeature>();
        }
    }
}