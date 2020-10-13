﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: include/capi/cef_scheme_capi.h
// --------------------------------------------------------------------------------------------﻿
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
// --------------------------------------------------------------------------------------------

#pragma warning disable 0169, 1591, 1573

using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using CefNet.WinApi;

namespace CefNet.CApi
{
	/// <summary>
	/// Structure that manages custom scheme registrations.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct cef_scheme_registrar_t
	{
		/// <summary>
		/// Base structure.
		/// </summary>
		public cef_base_scoped_t @base;

		/// <summary>
		/// int (*)(_cef_scheme_registrar_t* self, const cef_string_t* scheme_name, int options)*
		/// </summary>
		public void* add_custom_scheme;

		/// <summary>
		/// Register a custom scheme. This function should not be called for the built-
		/// in HTTP, HTTPS, FILE, FTP, ABOUT and DATA schemes.
		/// See cef_scheme_options_t for possible values for |options|.
		/// This function may be called on any thread. It should only be called once
		/// per unique |scheme_name| value. If |scheme_name| is already registered or
		/// if an error occurs this function will return false (0).
		/// </summary>
		[NativeName("add_custom_scheme")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int AddCustomScheme([Immutable]cef_string_t* scheme_name, int options);
	}
}

