﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: include/capi/cef_v8_capi.h
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
	/// Structure representing a V8 value handle. V8 handles can only be accessed
	/// from the thread on which they are created. Valid threads for creating a V8
	/// handle include the render process main thread (TID_RENDERER) and WebWorker
	/// threads. A task runner for posting tasks on the associated thread can be
	/// retrieved via the cef_v8context_t::get_task_runner() function.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct cef_v8value_t
	{
		/// <summary>
		/// Base structure.
		/// </summary>
		public cef_base_ref_counted_t @base;

		/// <summary>
		/// int (*)(_cef_v8value_t* self)*
		/// </summary>
		public void* is_valid;

		/// <summary>
		/// Returns true (1) if the underlying handle is valid and it can be accessed
		/// on the current thread. Do not call any other functions if this function
		/// returns false (0).
		/// </summary>
		[NativeName("is_valid")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int IsValid();

		/// <summary>
		/// int (*)(_cef_v8value_t* self)*
		/// </summary>
		public void* is_undefined;

		/// <summary>
		/// True if the value type is undefined.
		/// </summary>
		[NativeName("is_undefined")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int IsUndefined();

		/// <summary>
		/// int (*)(_cef_v8value_t* self)*
		/// </summary>
		public void* is_null;

		/// <summary>
		/// True if the value type is null.
		/// </summary>
		[NativeName("is_null")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int IsNull();

		/// <summary>
		/// int (*)(_cef_v8value_t* self)*
		/// </summary>
		public void* is_bool;

		/// <summary>
		/// True if the value type is bool.
		/// </summary>
		[NativeName("is_bool")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int IsBool();

		/// <summary>
		/// int (*)(_cef_v8value_t* self)*
		/// </summary>
		public void* is_int;

		/// <summary>
		/// True if the value type is int.
		/// </summary>
		[NativeName("is_int")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int IsInt();

		/// <summary>
		/// int (*)(_cef_v8value_t* self)*
		/// </summary>
		public void* is_uint;

		/// <summary>
		/// True if the value type is unsigned int.
		/// </summary>
		[NativeName("is_uint")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int IsUInt();

		/// <summary>
		/// int (*)(_cef_v8value_t* self)*
		/// </summary>
		public void* is_double;

		/// <summary>
		/// True if the value type is double.
		/// </summary>
		[NativeName("is_double")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int IsDouble();

		/// <summary>
		/// int (*)(_cef_v8value_t* self)*
		/// </summary>
		public void* is_date;

		/// <summary>
		/// True if the value type is Date.
		/// </summary>
		[NativeName("is_date")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int IsDate();

		/// <summary>
		/// int (*)(_cef_v8value_t* self)*
		/// </summary>
		public void* is_string;

		/// <summary>
		/// True if the value type is string.
		/// </summary>
		[NativeName("is_string")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int IsString();

		/// <summary>
		/// int (*)(_cef_v8value_t* self)*
		/// </summary>
		public void* is_object;

		/// <summary>
		/// True if the value type is object.
		/// </summary>
		[NativeName("is_object")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int IsObject();

		/// <summary>
		/// int (*)(_cef_v8value_t* self)*
		/// </summary>
		public void* is_array;

		/// <summary>
		/// True if the value type is array.
		/// </summary>
		[NativeName("is_array")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int IsArray();

		/// <summary>
		/// int (*)(_cef_v8value_t* self)*
		/// </summary>
		public void* is_array_buffer;

		/// <summary>
		/// True if the value type is an ArrayBuffer.
		/// </summary>
		[NativeName("is_array_buffer")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int IsArrayBuffer();

		/// <summary>
		/// int (*)(_cef_v8value_t* self)*
		/// </summary>
		public void* is_function;

		/// <summary>
		/// True if the value type is function.
		/// </summary>
		[NativeName("is_function")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int IsFunction();

		/// <summary>
		/// int (*)(_cef_v8value_t* self, _cef_v8value_t* that)*
		/// </summary>
		public void* is_same;

		/// <summary>
		/// Returns true (1) if this object is pointing to the same handle as |that|
		/// object.
		/// </summary>
		[NativeName("is_same")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int IsSame(cef_v8value_t* that);

		/// <summary>
		/// int (*)(_cef_v8value_t* self)*
		/// </summary>
		public void* get_bool_value;

		/// <summary>
		/// Return a bool value.
		/// </summary>
		[NativeName("get_bool_value")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int GetBoolValue();

		/// <summary>
		/// int32 (*)(_cef_v8value_t* self)*
		/// </summary>
		public void* get_int_value;

		/// <summary>
		/// Return an int value.
		/// </summary>
		[NativeName("get_int_value")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int GetIntValue();

		/// <summary>
		/// uint32 (*)(_cef_v8value_t* self)*
		/// </summary>
		public void* get_uint_value;

		/// <summary>
		/// Return an unsigned int value.
		/// </summary>
		[NativeName("get_uint_value")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern uint GetUIntValue();

		/// <summary>
		/// double (*)(_cef_v8value_t* self)*
		/// </summary>
		public void* get_double_value;

		/// <summary>
		/// Return a double value.
		/// </summary>
		[NativeName("get_double_value")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern double GetDoubleValue();

		/// <summary>
		/// cef_time_t (*)(_cef_v8value_t* self)*
		/// </summary>
		public void* get_date_value;

		/// <summary>
		/// Return a Date value.
		/// </summary>
		[NativeName("get_date_value")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern cef_time_t GetDateValue();

		/// <summary>
		/// cef_string_userfree_t (*)(_cef_v8value_t* self)*
		/// </summary>
		public void* get_string_value;

		/// <summary>
		/// Return a string value.
		/// The resulting string must be freed by calling cef_string_userfree_free().
		/// </summary>
		[NativeName("get_string_value")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern cef_string_userfree_t GetStringValue();

		/// <summary>
		/// int (*)(_cef_v8value_t* self)*
		/// </summary>
		public void* is_user_created;

		/// <summary>
		/// Returns true (1) if this is a user created object.
		/// </summary>
		[NativeName("is_user_created")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int IsUserCreated();

		/// <summary>
		/// int (*)(_cef_v8value_t* self)*
		/// </summary>
		public void* has_exception;

		/// <summary>
		/// Returns true (1) if the last function call resulted in an exception. This
		/// attribute exists only in the scope of the current CEF value object.
		/// </summary>
		[NativeName("has_exception")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int HasException();

		/// <summary>
		/// _cef_v8exception_t* (*)(_cef_v8value_t* self)*
		/// </summary>
		public void* get_exception;

		/// <summary>
		/// Returns the exception resulting from the last function call. This attribute
		/// exists only in the scope of the current CEF value object.
		/// </summary>
		[NativeName("get_exception")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern cef_v8exception_t* GetException();

		/// <summary>
		/// int (*)(_cef_v8value_t* self)*
		/// </summary>
		public void* clear_exception;

		/// <summary>
		/// Clears the last exception and returns true (1) on success.
		/// </summary>
		[NativeName("clear_exception")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int ClearException();

		/// <summary>
		/// int (*)(_cef_v8value_t* self)*
		/// </summary>
		public void* will_rethrow_exceptions;

		/// <summary>
		/// Returns true (1) if this object will re-throw future exceptions. This
		/// attribute exists only in the scope of the current CEF value object.
		/// </summary>
		[NativeName("will_rethrow_exceptions")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int WillRethrowExceptions();

		/// <summary>
		/// int (*)(_cef_v8value_t* self, int rethrow)*
		/// </summary>
		public void* set_rethrow_exceptions;

		/// <summary>
		/// Set whether this object will re-throw future exceptions. By default
		/// exceptions are not re-thrown. If a exception is re-thrown the current
		/// context should not be accessed again until after the exception has been
		/// caught and not re-thrown. Returns true (1) on success. This attribute
		/// exists only in the scope of the current CEF value object.
		/// </summary>
		[NativeName("set_rethrow_exceptions")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int SetRethrowExceptions(int rethrow);

		/// <summary>
		/// int (*)(_cef_v8value_t* self, const cef_string_t* key)*
		/// </summary>
		public void* has_value_bykey;

		/// <summary>
		/// Returns true (1) if the object has a value with the specified identifier.
		/// </summary>
		[NativeName("has_value_bykey")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int HasValueByKey([Immutable]cef_string_t* key);

		/// <summary>
		/// int (*)(_cef_v8value_t* self, int index)*
		/// </summary>
		public void* has_value_byindex;

		/// <summary>
		/// Returns true (1) if the object has a value with the specified identifier.
		/// </summary>
		[NativeName("has_value_byindex")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int HasValueByIndex(int index);

		/// <summary>
		/// int (*)(_cef_v8value_t* self, const cef_string_t* key)*
		/// </summary>
		public void* delete_value_bykey;

		/// <summary>
		/// Deletes the value with the specified identifier and returns true (1) on
		/// success. Returns false (0) if this function is called incorrectly or an
		/// exception is thrown. For read-only and don&apos;t-delete values this function
		/// will return true (1) even though deletion failed.
		/// </summary>
		[NativeName("delete_value_bykey")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int DeleteValueByKey([Immutable]cef_string_t* key);

		/// <summary>
		/// int (*)(_cef_v8value_t* self, int index)*
		/// </summary>
		public void* delete_value_byindex;

		/// <summary>
		/// Deletes the value with the specified identifier and returns true (1) on
		/// success. Returns false (0) if this function is called incorrectly, deletion
		/// fails or an exception is thrown. For read-only and don&apos;t-delete values this
		/// function will return true (1) even though deletion failed.
		/// </summary>
		[NativeName("delete_value_byindex")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int DeleteValueByIndex(int index);

		/// <summary>
		/// _cef_v8value_t* (*)(_cef_v8value_t* self, const cef_string_t* key)*
		/// </summary>
		public void* get_value_bykey;

		/// <summary>
		/// Returns the value with the specified identifier on success. Returns NULL if
		/// this function is called incorrectly or an exception is thrown.
		/// </summary>
		[NativeName("get_value_bykey")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern cef_v8value_t* GetValueByKey([Immutable]cef_string_t* key);

		/// <summary>
		/// _cef_v8value_t* (*)(_cef_v8value_t* self, int index)*
		/// </summary>
		public void* get_value_byindex;

		/// <summary>
		/// Returns the value with the specified identifier on success. Returns NULL if
		/// this function is called incorrectly or an exception is thrown.
		/// </summary>
		[NativeName("get_value_byindex")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern cef_v8value_t* GetValueByIndex(int index);

		/// <summary>
		/// int (*)(_cef_v8value_t* self, const cef_string_t* key, _cef_v8value_t* value, cef_v8_propertyattribute_t attribute)*
		/// </summary>
		public void* set_value_bykey;

		/// <summary>
		/// Associates a value with the specified identifier and returns true (1) on
		/// success. Returns false (0) if this function is called incorrectly or an
		/// exception is thrown. For read-only values this function will return true
		/// (1) even though assignment failed.
		/// </summary>
		[NativeName("set_value_bykey")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int SetValueByKey([Immutable]cef_string_t* key, cef_v8value_t* value, CefV8PropertyAttribute attribute);

		/// <summary>
		/// int (*)(_cef_v8value_t* self, int index, _cef_v8value_t* value)*
		/// </summary>
		public void* set_value_byindex;

		/// <summary>
		/// Associates a value with the specified identifier and returns true (1) on
		/// success. Returns false (0) if this function is called incorrectly or an
		/// exception is thrown. For read-only values this function will return true
		/// (1) even though assignment failed.
		/// </summary>
		[NativeName("set_value_byindex")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int SetValueByIndex(int index, cef_v8value_t* value);

		/// <summary>
		/// int (*)(_cef_v8value_t* self, const cef_string_t* key, cef_v8_accesscontrol_t settings, cef_v8_propertyattribute_t attribute)*
		/// </summary>
		public void* set_value_byaccessor;

		/// <summary>
		/// Registers an identifier and returns true (1) on success. Access to the
		/// identifier will be forwarded to the cef_v8accessor_t instance passed to
		/// cef_v8value_t::cef_v8value_create_object(). Returns false (0) if this
		/// function is called incorrectly or an exception is thrown. For read-only
		/// values this function will return true (1) even though assignment failed.
		/// </summary>
		[NativeName("set_value_byaccessor")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int SetValueByAccessor([Immutable]cef_string_t* key, CefV8AccessControl settings, CefV8PropertyAttribute attribute);

		/// <summary>
		/// int (*)(_cef_v8value_t* self, cef_string_list_t keys)*
		/// </summary>
		public void* get_keys;

		/// <summary>
		/// Read the keys for the object&apos;s values into the specified vector. Integer-
		/// based keys will also be returned as strings.
		/// </summary>
		[NativeName("get_keys")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int GetKeys(cef_string_list_t keys);

		/// <summary>
		/// int (*)(_cef_v8value_t* self, _cef_base_ref_counted_t* user_data)*
		/// </summary>
		public void* set_user_data;

		/// <summary>
		/// Sets the user data for this object and returns true (1) on success. Returns
		/// false (0) if this function is called incorrectly. This function can only be
		/// called on user created objects.
		/// </summary>
		[NativeName("set_user_data")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int SetUserData(cef_base_ref_counted_t* user_data);

		/// <summary>
		/// _cef_base_ref_counted_t* (*)(_cef_v8value_t* self)*
		/// </summary>
		public void* get_user_data;

		/// <summary>
		/// Returns the user data, if any, assigned to this object.
		/// </summary>
		[NativeName("get_user_data")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern cef_base_ref_counted_t* GetUserData();

		/// <summary>
		/// int (*)(_cef_v8value_t* self)*
		/// </summary>
		public void* get_externally_allocated_memory;

		/// <summary>
		/// Returns the amount of externally allocated memory registered for the
		/// object.
		/// </summary>
		[MethodImpl(MethodImplOptions.ForwardRef)]
		[NativeName("get_externally_allocated_memory")]
		public unsafe extern int GetExternallyAllocatedMemory();

		/// <summary>
		/// int (*)(_cef_v8value_t* self, int change_in_bytes)*
		/// </summary>
		public void* adjust_externally_allocated_memory;

		/// <summary>
		/// Adjusts the amount of registered external memory for the object. Used to
		/// give V8 an indication of the amount of externally allocated memory that is
		/// kept alive by JavaScript objects. V8 uses this information to decide when
		/// to perform global garbage collection. Each cef_v8value_t tracks the amount
		/// of external memory associated with it and automatically decreases the
		/// global total by the appropriate amount on its destruction.
		/// |change_in_bytes| specifies the number of bytes to adjust by. This function
		/// returns the number of bytes associated with the object after the
		/// adjustment. This function can only be called on user created objects.
		/// </summary>
		[MethodImpl(MethodImplOptions.ForwardRef)]
		[NativeName("adjust_externally_allocated_memory")]
		public unsafe extern int AdjustExternallyAllocatedMemory(int change_in_bytes);

		/// <summary>
		/// int (*)(_cef_v8value_t* self)*
		/// </summary>
		public void* get_array_length;

		/// <summary>
		/// Returns the number of elements in the array.
		/// </summary>
		[NativeName("get_array_length")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int GetArrayLength();

		/// <summary>
		/// _cef_v8array_buffer_release_callback_t* (*)(_cef_v8value_t* self)*
		/// </summary>
		public void* get_array_buffer_release_callback;

		/// <summary>
		/// Returns the ReleaseCallback object associated with the ArrayBuffer or NULL
		/// if the ArrayBuffer was not created with CreateArrayBuffer.
		/// </summary>
		[MethodImpl(MethodImplOptions.ForwardRef)]
		[NativeName("get_array_buffer_release_callback")]
		public unsafe extern cef_v8array_buffer_release_callback_t* GetArrayBufferReleaseCallback();

		/// <summary>
		/// int (*)(_cef_v8value_t* self)*
		/// </summary>
		public void* neuter_array_buffer;

		/// <summary>
		/// Prevent the ArrayBuffer from using it&apos;s memory block by setting the length
		/// to zero. This operation cannot be undone. If the ArrayBuffer was created
		/// with CreateArrayBuffer then
		/// cef_v8array_buffer_release_callback_t::ReleaseBuffer will be called to
		/// release the underlying buffer.
		/// </summary>
		[NativeName("neuter_array_buffer")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern int NeuterArrayBuffer();

		/// <summary>
		/// cef_string_userfree_t (*)(_cef_v8value_t* self)*
		/// </summary>
		public void* get_function_name;

		/// <summary>
		/// Returns the function name.
		/// The resulting string must be freed by calling cef_string_userfree_free().
		/// </summary>
		[NativeName("get_function_name")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern cef_string_userfree_t GetFunctionName();

		/// <summary>
		/// _cef_v8handler_t* (*)(_cef_v8value_t* self)*
		/// </summary>
		public void* get_function_handler;

		/// <summary>
		/// Returns the function handler or NULL if not a CEF-created function.
		/// </summary>
		[NativeName("get_function_handler")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern cef_v8handler_t* GetFunctionHandler();

		/// <summary>
		/// _cef_v8value_t* (*)(_cef_v8value_t* self, _cef_v8value_t* object, size_t argumentsCount, const _cef_v8value_t** arguments)*
		/// </summary>
		public void* execute_function;

		/// <summary>
		/// Execute the function using the current V8 context. This function should
		/// only be called from within the scope of a cef_v8handler_t or
		/// cef_v8accessor_t callback, or in combination with calling enter() and
		/// exit() on a stored cef_v8context_t reference. |object| is the receiver
		/// (&apos;this&apos; object) of the function. If |object| is NULL the current context&apos;s
		/// global object will be used. |arguments| is the list of arguments that will
		/// be passed to the function. Returns the function return value on success.
		/// Returns NULL if this function is called incorrectly or an exception is
		/// thrown.
		/// </summary>
		[NativeName("execute_function")]
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public unsafe extern cef_v8value_t* ExecuteFunction(cef_v8value_t* @object, UIntPtr argumentsCount, [Immutable]cef_v8value_t** arguments);

		/// <summary>
		/// _cef_v8value_t* (*)(_cef_v8value_t* self, _cef_v8context_t* context, _cef_v8value_t* object, size_t argumentsCount, const _cef_v8value_t** arguments)*
		/// </summary>
		public void* execute_function_with_context;

		/// <summary>
		/// Execute the function using the specified V8 context. |object| is the
		/// receiver (&apos;this&apos; object) of the function. If |object| is NULL the specified
		/// context&apos;s global object will be used. |arguments| is the list of arguments
		/// that will be passed to the function. Returns the function return value on
		/// success. Returns NULL if this function is called incorrectly or an
		/// exception is thrown.
		/// </summary>
		[MethodImpl(MethodImplOptions.ForwardRef)]
		[NativeName("execute_function_with_context")]
		public unsafe extern cef_v8value_t* ExecuteFunctionWithContext(cef_v8context_t* context, cef_v8value_t* @object, UIntPtr argumentsCount, [Immutable]cef_v8value_t** arguments);
	}
}
