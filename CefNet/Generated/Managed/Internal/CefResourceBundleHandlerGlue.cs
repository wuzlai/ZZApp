﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Native/Types/cef_resource_bundle_handler_t.cs
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

namespace CefNet.Internal
{
	sealed partial class CefResourceBundleHandlerGlue: CefResourceBundleHandler, ICefResourceBundleHandlerPrivate
	{
		private CefAppGlue _implementation;

		public CefResourceBundleHandlerGlue(CefAppGlue impl)
		{
			_implementation = impl;
		}

		bool ICefResourceBundleHandlerPrivate.AvoidGetLocalizedString()
		{
			return _implementation.AvoidGetLocalizedString();
		}

		protected internal unsafe override bool GetLocalizedString(int stringId, ref string @string)
		{
			return _implementation.GetLocalizedString(stringId, ref @string);
		}

		bool ICefResourceBundleHandlerPrivate.AvoidGetDataResource()
		{
			return _implementation.AvoidGetDataResource();
		}

		protected internal unsafe override bool GetDataResource(int resourceId, ref IntPtr data, ref long dataSize)
		{
			return _implementation.GetDataResource(resourceId, ref data, ref dataSize);
		}

		bool ICefResourceBundleHandlerPrivate.AvoidGetDataResourceForScale()
		{
			return _implementation.AvoidGetDataResourceForScale();
		}

		protected internal unsafe override bool GetDataResourceForScale(int resourceId, CefScaleFactor scaleFactor, ref IntPtr data, ref long dataSize)
		{
			return _implementation.GetDataResourceForScale(resourceId, scaleFactor, ref data, ref dataSize);
		}

	}
}
