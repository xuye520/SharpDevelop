//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.2032
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

using System;
using System.Reflection;
using SharpReportCore;
	
	/// <summary>
	/// This class is a Factory for all Renderer
	/// <see cref="RenderFormSheetReport"></see>
	/// <see cref="RenderDataReport"></see>
	/// </summary>
	/// <remarks>
	/// 	created by - Forstmeier Peter
	/// 	created on - 21.09.2005 14:02:01
	/// </remarks>
	
namespace SharpReportCore {	
	public class RendererFactory : SharpReportCore.GenericFactory {
		
		/// <summary>
		/// Default constructor - initializes all fields to default values
		/// </summary>
		public RendererFactory():base(Assembly.GetExecutingAssembly(),
		                                     typeof (AbstractRenderer)){
		}
		public  AbstractRenderer Create(ReportModel model,DataManager container) {
			if (model != null) {
				switch (model.ReportSettings.ReportType) {
						case GlobalEnums.enmReportType.FormSheet :{
							return new RenderFormSheetReport(model);
						}
						case GlobalEnums.enmReportType.DataReport:{
							return new RenderDataReport(model,container);
						}
				}
			}
			throw  new MissingModelException();
		}
	}
}
