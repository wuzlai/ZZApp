﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: include/capi/cef_context_menu_handler_capi.h
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
	/// Callback structure used for continuation of custom context menu display.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct cef_run_context_menu_callback_t
	{
		/// <summary>
		/// Base structure.
		/// </summary>
		public cef_base_ref_counted_t @base;

		/// <summary>
		/// void (*)(_cef_run_context_menu_callback_t* self, int command_id, cef_event_flags_t event_flags)*
		/// </summary>
		public void* cont;

		/// <summary>
		/// Complete context menu display by selecting the specified |command_id| and
		/// |event_flags|.
		/// </summary>
		[NativeName("cont")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void Continue(int command_id, CefEventFlags event_flags);

		/// <summary>
		/// void (*)(_cef_run_context_menu_callback_t* self)*
		/// </summary>
		public void* cancel;

		/// <summary>
		/// Cancel context menu display.
		/// </summary>
		[NativeName("cancel")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void Cancel();
	}
}

