﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Native/Types/cef_run_file_dialog_callback_t.cs
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
	/// Callback structure for cef_browser_host_t::RunFileDialog. The functions of
	/// this structure will be called on the browser process UI thread.
	/// </summary>
	/// <remarks>
	/// Role: Handler
	/// </remarks>
	public unsafe partial class CefRunFileDialogCallback : CefBaseRefCounted<cef_run_file_dialog_callback_t>, ICefRunFileDialogCallbackPrivate
	{
		private static readonly OnFileDialogDismissedDelegate fnOnFileDialogDismissed = OnFileDialogDismissedImpl;

		internal static unsafe CefRunFileDialogCallback Create(IntPtr instance)
		{
			return new CefRunFileDialogCallback((cef_run_file_dialog_callback_t*)instance);
		}

		public CefRunFileDialogCallback()
		{
			cef_run_file_dialog_callback_t* self = this.NativeInstance;
			self->on_file_dialog_dismissed = (void*)Marshal.GetFunctionPointerForDelegate(fnOnFileDialogDismissed);
		}

		public CefRunFileDialogCallback(cef_run_file_dialog_callback_t* instance)
			: base((cef_base_ref_counted_t*)instance)
		{
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefRunFileDialogCallbackPrivate.AvoidOnFileDialogDismissed();

		/// <summary>
		/// Called asynchronously after the file dialog is dismissed.
		/// |selected_accept_filter| is the 0-based index of the value selected from
		/// the accept filters array passed to cef_browser_host_t::RunFileDialog.
		/// |file_paths| will be a single value or a list of values depending on the
		/// dialog mode. If the selection was cancelled |file_paths| will be NULL.
		/// </summary>
		protected internal unsafe virtual void OnFileDialogDismissed(bool selectedAcceptFilter, CefStringList filePaths)
		{
		}

		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void OnFileDialogDismissedDelegate(cef_run_file_dialog_callback_t* self, int selected_accept_filter, cef_string_list_t file_paths);

		// void (*)(_cef_run_file_dialog_callback_t* self, int selected_accept_filter, cef_string_list_t file_paths)*
		private static unsafe void OnFileDialogDismissedImpl(cef_run_file_dialog_callback_t* self, int selected_accept_filter, cef_string_list_t file_paths)
		{
			var instance = GetInstance((IntPtr)self) as CefRunFileDialogCallback;
			if (instance == null || ((ICefRunFileDialogCallbackPrivate)instance).AvoidOnFileDialogDismissed())
			{
				return;
			}
			instance.OnFileDialogDismissed(selected_accept_filter != 0, CefStringList.Wrap(file_paths));
		}
	}
}