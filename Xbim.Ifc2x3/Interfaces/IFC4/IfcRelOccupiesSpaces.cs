// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.SharedFacilitiesElements
{
	public partial class @IfcRelOccupiesSpaces : IIfcRelAssignsToActor
	{
		IIfcActor IIfcRelAssignsToActor.RelatingActor 
		{ 
			get
			{
				return RelatingActor as IIfcActor;
			} 
		}
		IIfcActorRole IIfcRelAssignsToActor.ActingRole 
		{ 
			get
			{
				return ActingRole as IIfcActorRole;
			} 
		}
	}
}