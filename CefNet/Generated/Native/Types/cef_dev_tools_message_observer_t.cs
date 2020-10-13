﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: include/capi/cef_devtools_message_observer_capi.h
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
	/// Callback structure for cef_browser_host_t::AddDevToolsMessageObserver. The
	/// functions of this structure will be called on the browser process UI thread.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct cef_dev_tools_message_observer_t
	{
		/// <summary>
		/// Base structure.
		/// </summary>
		public cef_base_ref_counted_t @base;

		/// <summary>
		/// int (*)(_cef_dev_tools_message_observer_t* self, _cef_browser_t* browser, const void* message, size_t message_size)*
		/// </summary>
		public void* on_dev_tools_message;

		/// <summary>
		/// Method that will be called on receipt of a DevTools protocol message.
		/// |browser| is the originating browser instance. |message| is a UTF8-encoded
		/// JSON dictionary representing either a function result or an event.
		/// |message| is only valid for the scope of this callback and should be copied
		/// if necessary. Return true (1) if the message was handled or false (0) if
		/// the message should be further processed and passed to the
		/// OnDevToolsMethodResult or OnDevToolsEvent functions as appropriate.
		/// Method result dictionaries include an &quot;id&quot; (int) value that identifies the
		/// orginating function call sent from cef_browser_host_t::SendDevToolsMessage,
		/// and optionally either a &quot;result&quot; (dictionary) or &quot;error&quot; (dictionary)
		/// value. The &quot;error&quot; dictionary will contain &quot;code&quot; (int) and &quot;message&quot;
		/// (string) values. Event dictionaries include a &quot;function&quot; (string) value and
		/// optionally a &quot;params&quot; (dictionary) value. See the DevTools protocol
		/// documentation at https://chromedevtools.github.io/devtools-protocol/ for
		/// details of supported function calls and the expected &quot;result&quot; or &quot;params&quot;
		/// dictionary contents. JSON dictionaries can be parsed using the CefParseJSON
		/// function if desired, however be aware of performance considerations when
		/// parsing large messages (some of which may exceed 1MB in size).
		/// </summary>
		[NativeName("on_dev_tools_message")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int OnDevToolsMessage(cef_browser_t* browser, [Immutable]void* message, UIntPtr message_size);

		/// <summary>
		/// void (*)(_cef_dev_tools_message_observer_t* self, _cef_browser_t* browser, int message_id, int success, const void* result, size_t result_size)*
		/// </summary>
		public void* on_dev_tools_method_result;

		/// <summary>
		/// Method that will be called after attempted execution of a DevTools protocol
		/// function. |browser| is the originating browser instance. |message_id| is
		/// the &quot;id&quot; value that identifies the originating function call message. If
		/// the function succeeded |success| will be true (1) and |result| will be the
		/// UTF8-encoded JSON &quot;result&quot; dictionary value (which may be NULL). If the
		/// function failed |success| will be false (0) and |result| will be the
		/// UTF8-encoded JSON &quot;error&quot; dictionary value. |result| is only valid for the
		/// scope of this callback and should be copied if necessary. See the
		/// OnDevToolsMessage documentation for additional details on |result|
		/// contents.
		/// </summary>
		[MethodImpl(MethodImplOptions.ForwardRef)]
		[NativeName("on_dev_tools_method_result")]
		public unsafe extern void OnDevToolsMethodResult(cef_browser_t* browser, int message_id, int success, [Immutable]void* result, UIntPtr result_size);

		/// <summary>
		/// void (*)(_cef_dev_tools_message_observer_t* self, _cef_browser_t* browser, const cef_string_t* method, const void* params, size_t params_size)*
		/// </summary>
		public void* on_dev_tools_event;

		/// <summary>
		/// Method that will be called on receipt of a DevTools protocol event.
		/// |browser| is the originating browser instance. |function| is the &quot;function&quot;
		/// value. |params| is the UTF8-encoded JSON &quot;params&quot; dictionary value (which
		/// may be NULL). |params| is only valid for the scope of this callback and
		/// should be copied if necessary. See the OnDevToolsMessage documentation for
		/// additional details on |params| contents.
		/// </summary>
		[NativeName("on_dev_tools_event")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern void OnDevToolsEvent(cef_browser_t* browser, [Immutable]cef_string_t* method, [Immutable]void* @params, UIntPtr params_size);

		/// <summary>
		/// void (*)(_cef_dev_tools_message_observer_t* self, _cef_browser_t* browser)*
		/// </summary>
		public void* on_dev_tools_agent_attached;

		/// <summary>
		/// Method that will be called when the DevTools agent has attached. |browser|
		/// is the originating browser instance. This will generally occur in response
		/// to the first message sent while the agent is detached.
		/// </summary>
		[MethodImpl(MethodImplOptions.ForwardRef)]
		[NativeName("on_dev_tools_agent_attached")]
		public unsafe extern void OnDevToolsAgentAttached(cef_browser_t* browser);

		/// <summary>
		/// void (*)(_cef_dev_tools_message_observer_t* self, _cef_browser_t* browser)*
		/// </summary>
		public void* on_dev_tools_agent_detached;

		/// <summary>
		/// Method that will be called when the DevTools agent has detached. |browser|
		/// is the originating browser instance. Any function results that were pending
		/// before the agent became detached will not be delivered, and any active
		/// event subscriptions will be canceled.
		/// </summary>
		[MethodImpl(MethodImplOptions.ForwardRef)]
		[NativeName("on_dev_tools_agent_detached")]
		public unsafe extern void OnDevToolsAgentDetached(cef_browser_t* browser);
	}
}

