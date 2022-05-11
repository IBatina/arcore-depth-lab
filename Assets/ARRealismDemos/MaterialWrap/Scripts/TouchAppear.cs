//-----------------------------------------------------------------------
// <copyright file="TouchAppear.cs" company="Google LLC">
//
// Copyright 2020 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// </copyright>
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Script to animate the appearance of the Material Wrap Touch effect.
/// </summary>

public class TouchAppear : MonoBehaviour
{
    /// <summary>
    /// Time in seconds for Material Wrap Touch material to appear.
    /// </summary>

    public float AppearSpeed = 1;

    private void Start()
    {
        GetComponent<MeshRenderer>().material.SetFloat("_ClipRadius", 0);
    }

    private void Update()
    {
        float currentRadius = GetComponent<MeshRenderer>().material.GetFloat("_ClipRadius");
        if (currentRadius < 1)
        {
            currentRadius = Mathf.Lerp(currentRadius, 1, Time.deltaTime / AppearSpeed * 2);
            GetComponent<MeshRenderer>().material.SetFloat("_ClipRadius", currentRadius);
        }
    }
}