﻿using System;

namespace dotmore.Extensions {
	public static class TypeExtensions {
		public static bool IsStructure(this Type theType) {
			return (theType.IsValueType && theType.IsEnum == false && theType.IsPrimitive == false);
		}

		public static bool IsNullableType(this Type theType) {
			if (theType == null) return true;
			return (theType.IsGenericType && theType.GetGenericTypeDefinition().Equals(typeof(Nullable<>)));
		}
	}
}
