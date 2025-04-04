﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IApprovalDataProviderSchema

	/// <exclude/>
	public class IApprovalDataProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IApprovalDataProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IApprovalDataProviderSchema(IApprovalDataProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2f3d6806-0794-4c7d-b577-3fb200d12452");
			Name = "IApprovalDataProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0accf80-e908-4a7c-b6cb-73d391885497");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,229,150,81,111,218,48,16,199,159,169,212,239,112,98,47,173,84,133,247,66,145,38,214,118,60,80,109,176,183,106,15,198,185,100,150,18,59,186,179,145,24,226,187,207,118,8,132,12,186,78,234,27,47,200,196,247,255,219,247,179,47,23,45,74,228,74,72,132,31,72,36,216,100,54,153,24,157,169,220,145,176,202,232,235,171,205,245,85,207,177,210,57,44,214,108,177,28,118,254,39,115,167,173,42,49,89,32,41,81,168,223,81,119,136,58,24,191,56,21,130,86,74,226,204,164,88,36,95,132,21,126,53,75,66,90,47,240,146,79,132,185,87,195,84,91,164,204,239,235,30,166,159,171,138,204,74,20,33,250,155,31,169,20,41,6,87,110,89,40,9,170,137,61,23,218,219,196,240,222,96,48,128,17,187,178,20,180,30,55,15,158,209,50,136,162,0,177,211,50,72,83,20,40,67,22,144,25,2,174,80,170,76,97,10,132,210,80,10,66,167,192,242,23,150,34,217,219,14,186,190,163,74,144,40,65,123,192,15,125,63,70,109,23,81,243,226,159,244,199,143,158,153,93,239,108,98,212,104,16,21,111,25,204,227,250,211,116,47,223,109,72,165,201,95,106,66,235,72,243,120,52,104,70,97,106,129,33,179,239,14,105,61,247,7,111,52,99,32,208,112,251,170,216,26,90,223,176,165,112,116,221,109,223,193,179,83,41,28,111,230,118,248,79,186,158,229,10,207,3,150,142,130,33,56,70,170,225,94,0,241,200,164,225,206,31,76,60,83,196,182,203,253,98,89,63,5,26,199,192,63,152,247,74,177,128,80,58,34,199,118,214,157,247,71,107,230,189,108,185,69,117,241,6,206,211,64,154,116,107,101,253,98,111,215,251,33,241,6,200,97,189,119,212,117,171,160,125,15,128,156,140,171,124,154,75,127,242,86,88,127,197,248,98,239,220,190,178,103,232,193,74,126,50,84,175,240,223,55,175,183,173,59,35,234,180,110,142,71,141,114,82,8,230,123,56,117,208,49,238,181,221,99,239,96,223,163,151,5,254,60,180,80,25,92,206,152,52,221,51,58,205,176,92,34,221,132,13,195,3,244,49,166,20,249,223,6,187,198,111,151,227,227,126,26,54,144,163,29,2,135,159,237,121,195,82,248,79,10,154,152,194,149,250,172,237,172,19,212,53,63,73,108,251,7,144,153,224,18,235,8,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2f3d6806-0794-4c7d-b577-3fb200d12452"));
		}

		#endregion

	}

	#endregion

}

