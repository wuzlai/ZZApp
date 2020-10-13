﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Native/Types/cef_draggable_region_t.cs
// --------------------------------------------------------------------------------------------﻿
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
// --------------------------------------------------------------------------------------------

#pragma warning disable 0169, 1591, 1573

using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using CefNet.WinApi;
using CefNet.CApi;
using CefNet.Internal;

namespace CefNet
{
	/// <summary>
	/// Structure representing a draggable region.
	/// </summary>
	/// <remarks>
	/// Role: Proxy
	/// </remarks>
	public unsafe partial struct CefDraggableRegion
	{
		private cef_draggable_region_t _instance;

		/// <summary>
		/// Bounds of the region.
		/// </summary>
		public CefRect Bounds
		{
			get
			{
				return _instance.bounds;
			}
			set
			{
				_instance.bounds = value;
			}
		}

		/// <summary>
		/// True (1) this this region is draggable and false (0) otherwise.
		/// </summary>
		public bool Draggable
		{
			get
			{
				return _instance.draggable != 0;
			}
			set
			{
				_instance.draggable = value ? 1 : 0;
			}
		}

		public static implicit operator CefDraggableRegion(cef_draggable_region_t instance)
		{
			return new CefDraggableRegion { _instance = instance };
		}

		public static implicit operator cef_draggable_region_t(CefDraggableRegion instance)
		{
			return instance._instance;
		}
	}
}
