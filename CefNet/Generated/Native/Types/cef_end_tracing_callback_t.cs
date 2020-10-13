﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: include/capi/cef_trace_capi.h
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
	/// Implement this structure to receive notification when tracing has completed.
	/// The functions of this structure will be called on the browser process UI
	/// thread.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct cef_end_tracing_callback_t
	{
		/// <summary>
		/// Base structure.
		/// </summary>
		public cef_base_ref_counted_t @base;

		/// <summary>
		/// void (*)(_cef_end_tracing_callback_t* self, const cef_string_t* tracing_file)*
		/// </summary>
		public void* on_end_tracing_complete;

		/// <summary>
		/// Called after all processes have sent their trace data. |tracing_file| is
		/// the path at which tracing data was written. The client is responsible for
		/// deleting |tracing_file|.
		/// </summary>
		[NativeName("on_end_tracing_complete")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void OnEndTracingComplete([Immutable]cef_string_t* tracing_file);
	}
}
