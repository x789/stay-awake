// Copyright 2021 by TillW
// Licensed to you under the MIT License
using System;

namespace StayAwake
{
	[Flags]
	internal enum ExecutionState : uint
	{
		SystemRequired = 0x1u,
		DisplayRequired = 0x2u,
		Continuous = 0x80000000u
	}
}
