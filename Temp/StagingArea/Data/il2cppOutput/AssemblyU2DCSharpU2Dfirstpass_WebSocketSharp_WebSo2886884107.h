﻿#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// System.Func`3<WebSocketSharp.Opcode,System.IO.Stream,System.Boolean>
struct Func_3_t3699793028;
// System.Action`1<System.Boolean>
struct Action_1_t3627374100;
// WebSocketSharp.WebSocket
struct WebSocket_t3268376029;

#include "mscorlib_System_Object2689449295.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// WebSocketSharp.WebSocket/<sendAsync>c__AnonStorey3
struct  U3CsendAsyncU3Ec__AnonStorey3_t2886884107  : public Il2CppObject
{
public:
	// System.Func`3<WebSocketSharp.Opcode,System.IO.Stream,System.Boolean> WebSocketSharp.WebSocket/<sendAsync>c__AnonStorey3::sender
	Func_3_t3699793028 * ___sender_0;
	// System.Action`1<System.Boolean> WebSocketSharp.WebSocket/<sendAsync>c__AnonStorey3::completed
	Action_1_t3627374100 * ___completed_1;
	// WebSocketSharp.WebSocket WebSocketSharp.WebSocket/<sendAsync>c__AnonStorey3::$this
	WebSocket_t3268376029 * ___U24this_2;

public:
	inline static int32_t get_offset_of_sender_0() { return static_cast<int32_t>(offsetof(U3CsendAsyncU3Ec__AnonStorey3_t2886884107, ___sender_0)); }
	inline Func_3_t3699793028 * get_sender_0() const { return ___sender_0; }
	inline Func_3_t3699793028 ** get_address_of_sender_0() { return &___sender_0; }
	inline void set_sender_0(Func_3_t3699793028 * value)
	{
		___sender_0 = value;
		Il2CppCodeGenWriteBarrier(&___sender_0, value);
	}

	inline static int32_t get_offset_of_completed_1() { return static_cast<int32_t>(offsetof(U3CsendAsyncU3Ec__AnonStorey3_t2886884107, ___completed_1)); }
	inline Action_1_t3627374100 * get_completed_1() const { return ___completed_1; }
	inline Action_1_t3627374100 ** get_address_of_completed_1() { return &___completed_1; }
	inline void set_completed_1(Action_1_t3627374100 * value)
	{
		___completed_1 = value;
		Il2CppCodeGenWriteBarrier(&___completed_1, value);
	}

	inline static int32_t get_offset_of_U24this_2() { return static_cast<int32_t>(offsetof(U3CsendAsyncU3Ec__AnonStorey3_t2886884107, ___U24this_2)); }
	inline WebSocket_t3268376029 * get_U24this_2() const { return ___U24this_2; }
	inline WebSocket_t3268376029 ** get_address_of_U24this_2() { return &___U24this_2; }
	inline void set_U24this_2(WebSocket_t3268376029 * value)
	{
		___U24this_2 = value;
		Il2CppCodeGenWriteBarrier(&___U24this_2, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
