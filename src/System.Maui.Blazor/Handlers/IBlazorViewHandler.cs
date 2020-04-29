﻿using System;

namespace System.Maui.Blazor.Handlers
{
	public interface IBlazorViewHandler : IViewHandler
	{
		Type VirtualType { get; }

		Type ComponentType { get; }

		void OnComponentLoad(object nativeView);
	}
}