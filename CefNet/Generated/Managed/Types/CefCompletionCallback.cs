﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Native/Types/cef_completion_callback_t.cs
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
	/// Generic callback structure used for asynchronous completion.
	/// </summary>
	/// <remarks>
	/// Role: Handler
	/// </remarks>
	public unsafe partial class CefCompletionCallback : CefBaseRefCounted<cef_completion_callback_t>, ICefCompletionCallbackPrivate
	{
		private static readonly OnCompleteDelegate fnOnComplete = OnCompleteImpl;

		internal static unsafe CefCompletionCallback Create(IntPtr instance)
		{
			return new CefCompletionCallback((cef_completion_callback_t*)instance);
		}

		public CefCompletionCallback()
		{
			cef_completion_callback_t* self = this.NativeInstance;
			self->on_complete = (void*)Marshal.GetFunctionPointerForDelegate(fnOnComplete);
		}

		public CefCompletionCallback(cef_completion_callback_t* instance)
			: base((cef_base_ref_counted_t*)instance)
		{
		}

		/// <summary>
		/// Method that will be called once the task is complete.
		/// </summary>
		protected internal unsafe virtual void OnComplete()
		{
		}

		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void OnCompleteDelegate(cef_completion_callback_t* self);

		// void (*)(_cef_completion_callback_t* self)*
		private static unsafe void OnCompleteImpl(cef_completion_callback_t* self)
		{
			var instance = GetInstance((IntPtr)self) as CefCompletionCallback;
			if (instance == null)
			{
				return;
			}
			instance.OnComplete();
		}
	}
}
