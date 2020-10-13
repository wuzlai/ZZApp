﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: include/capi/cef_media_router_capi.h
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
	/// Represents the route between a media source and sink. Instances of this
	/// object are created via cef_media_router_t::CreateRoute and retrieved via
	/// cef_media_observer_t::OnRoutes. Contains the status and metadata of a routing
	/// operation. The functions of this structure may be called on any browser
	/// process thread unless otherwise indicated.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct cef_media_route_t
	{
		/// <summary>
		/// Base structure.
		/// </summary>
		public cef_base_ref_counted_t @base;

		/// <summary>
		/// cef_string_userfree_t (*)(_cef_media_route_t* self)*
		/// </summary>
		public void* get_id;

		/// <summary>
		/// Returns the ID for this route.
		/// The resulting string must be freed by calling cef_string_userfree_free().
		/// </summary>
		[NativeName("get_id")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern cef_string_userfree_t GetId();

		/// <summary>
		/// _cef_media_source_t* (*)(_cef_media_route_t* self)*
		/// </summary>
		public void* get_source;

		/// <summary>
		/// Returns the source associated with this route.
		/// </summary>
		[NativeName("get_source")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern cef_media_source_t* GetSource();

		/// <summary>
		/// _cef_media_sink_t* (*)(_cef_media_route_t* self)*
		/// </summary>
		public void* get_sink;

		/// <summary>
		/// Returns the sink associated with this route.
		/// </summary>
		[NativeName("get_sink")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern cef_media_sink_t* GetSink();

		/// <summary>
		/// void (*)(_cef_media_route_t* self, const void* message, size_t message_size)*
		/// </summary>
		public void* send_route_message;

		/// <summary>
		/// Send a message over this route. |message| will be copied if necessary.
		/// </summary>
		[NativeName("send_route_message")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void SendRouteMessage([Immutable]void* message, UIntPtr message_size);

		/// <summary>
		/// void (*)(_cef_media_route_t* self)*
		/// </summary>
		public void* terminate;

		/// <summary>
		/// Terminate this route. Will result in an asynchronous call to
		/// cef_media_observer_t::OnRoutes on all registered observers.
		/// </summary>
		[NativeName("terminate")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void Terminate();
	}
}

