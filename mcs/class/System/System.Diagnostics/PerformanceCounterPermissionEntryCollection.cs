//
// System.Diagnostics.PerformanceCounterPermissionEntryCollection.cs
//
// Authors:
//   Jonathan Pryor (jonpryor@vt.edu)
//
// (C) 2002
//

using System;
using System.Diagnostics;
using System.Collections;
using System.Globalization;

namespace System.Diagnostics {

	[Serializable]
	public class PerformanceCounterPermissionEntryCollection 
		: CollectionBase 
	{
		internal PerformanceCounterPermissionEntryCollection ()
		{
		}

		public PerformanceCounterPermissionEntry this [int index] {
			get {
				return (PerformanceCounterPermissionEntry)
					InnerList[index];
			}
			set {InnerList[index] = value;}
		}

		public int Add (PerformanceCounterPermissionEntry value)
		{
			return InnerList.Add (value);
		}

		public void AddRange (PerformanceCounterPermissionEntry[] value)
		{
			foreach (PerformanceCounterPermissionEntry e in value)
				Add (e);
		}

		public void AddRange (
			PerformanceCounterPermissionEntryCollection value)
		{
			foreach (PerformanceCounterPermissionEntry e in value)
				Add (e);
		}

		public bool Contains (PerformanceCounterPermissionEntry value)
		{
			return InnerList.Contains (value);
		}

		public void CopyTo (PerformanceCounterPermissionEntry[] array,
			int index)
		{
			InnerList.CopyTo (array, index);
		}

		public int IndexOf (PerformanceCounterPermissionEntry value)
		{
			return InnerList.IndexOf (value);
		}

		public void Insert (int index, 
			PerformanceCounterPermissionEntry value)
		{
			InnerList.Insert (index, value);
		}

		protected override void OnClear ()
		{
		}

		protected override void OnInsert (int index, object value)
		{
			if (!(value is PerformanceCounterPermissionEntry))
				throw new NotSupportedException (Locale.GetText(
					"You can only insert " +
					"PerformanceCounterPermissionEntry " +
					"objects into the collection."));
		}

		protected override void OnRemove (int index, object value)
		{
		}

		protected override void OnSet (int index, 
			object oldValue, 
			object newValue)
		{
			if (!(newValue is PerformanceCounterPermissionEntry))
				throw new NotSupportedException (Locale.GetText(
					"You can only insert " +
					"PerformanceCounterPermissionEntry " +
					"objects into the collection."));
		}

		public void Remove (PerformanceCounterPermissionEntry value)
		{
			InnerList.Remove (value);
		}
	}
}

