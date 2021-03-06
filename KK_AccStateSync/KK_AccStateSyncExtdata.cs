﻿using MessagePack;
using System;
using System.Collections.Generic;

namespace AccStateSync
{
	public partial class AccStateSync
	{
		[Serializable]
		[MessagePackObject]
		public class AccTriggerInfo
		{
			[Key("Slot")]
			public int Slot { get; set; }
			[Key("Kind")]
			public int Kind { get; set; } = -1;
			[Key("Group")]
			public string Group { get; set; } = "";
			[Key("State")]
			public List<bool> State { get; set; } = new List<bool>() {true, false, false, false};

			public AccTriggerInfo(int slot) { Slot = slot; }
		}

		[Serializable]
		[MessagePackObject]
		public class OutfitTriggerInfo
		{
			[Key("Index")]
			public int Index { get; set; }
			[Key("Parts")]
			public List<AccTriggerInfo> Parts { get; set; }

			public OutfitTriggerInfo(int index) { Index = index; Parts = new List<AccTriggerInfo>(); }
		}
	}
}
