﻿using System;
using BizHawk.Client.Common;

namespace BizHawk.Client.EmuHawk
{
	public sealed class UserDataApi : IUserDataApi
	{
		/// <exception cref="InvalidOperationException">type of <paramref name="value"/> cannot be used in userdata</exception>
		public void Set(string name, object value)
		{
			if (value != null)
			{
				var t = value.GetType();
				if (!t.IsPrimitive && t != typeof(string)) throw new InvalidOperationException("Invalid type for userdata");
			}
			GlobalWin.UserBag[name] = value;
		}

		public object Get(string key) => GlobalWin.UserBag.TryGetValue(key, out var value) ? value : null;

		public void Clear() => GlobalWin.UserBag.Clear();

		public bool Remove(string key) => GlobalWin.UserBag.Remove(key);

		public bool ContainsKey(string key) => GlobalWin.UserBag.ContainsKey(key);
	}
}
