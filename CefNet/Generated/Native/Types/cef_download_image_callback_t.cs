﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: include/capi/cef_browser_capi.h
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
	/// Callback structure for cef_browser_host_t::DownloadImage. The functions of
	/// this structure will be called on the browser process UI thread.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct cef_download_image_callback_t
	{
		/// <summary>
		/// Base structure.
		/// </summary>
		public cef_base_ref_counted_t @base;

		/// <summary>
		/// void (*)(_cef_download_image_callback_t* self, const cef_string_t* image_url, int http_status_code, _cef_image_t* image)*
		/// </summary>
		public void* on_download_image_finished;

		/// <summary>
		/// Method that will be executed when the image download has completed.
		/// |image_url| is the URL that was downloaded and |http_status_code| is the
		/// resulting HTTP status code. |image| is the resulting image, possibly at
		/// multiple scale factors, or NULL if the download failed.
		/// </summary>
		[MethodImpl(MethodImplOptions.ForwardRef)]
		[NativeName("on_download_image_finished")]
		public unsafe extern void OnDownloadImageFinished([Immutable]cef_string_t* image_url, int http_status_code, cef_image_t* image);
	}
}
