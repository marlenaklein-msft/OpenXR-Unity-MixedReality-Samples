﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using UnityEngine;

namespace Microsoft.MixedReality.OpenXR.Sample
{
    public class AnchorSampleInstructions : MonoBehaviour, ITextProvider
    {
        private string m_text;

        private void Start()
        {
            m_text = @"Sample: ARAnchor and XRAnchorStore

- Air tap anywhere to create an ARAnchor, represented as blue cube.

- Air tap at an anchor's cube to toggle anchor persistence.
  A green cube represents that the anchor is being persisted in the XRAnchorStore.

- Use the 'Clear Anchor Store' button to remove all persisted anchors from the XRAnchorStore.
  All green cubes will turn blue.

- Use the 'Clear all anchors in scene' button to delete all anchors in the scene.
  All cubes will disappear, but their persistence in XRAnchorStore is preserved.

- Use the 'Set App Exclusive Maps' button to toggle between the default shared and app exclusive map.

- Use the 'Place and Reload' button to place an anchor via Windows.Perception.Spatial APIs and reload the anchor store.";
        }

        string ITextProvider.UpdateText()
        {
            return m_text;
        }
    }
}
