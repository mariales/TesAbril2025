﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseConstsSchema

	/// <exclude/>
	public class BaseConstsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseConstsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseConstsSchema(BaseConstsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4df8bd7f-2981-4bed-9c2c-8844d6bb7389");
			Name = "BaseConsts";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("241c12b1-6ed7-4197-86c3-2351cca1bc30");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,148,93,111,155,48,20,134,175,27,41,255,193,202,77,219,11,55,224,15,176,181,15,201,54,246,180,155,173,82,210,221,76,187,160,137,211,88,34,144,97,104,21,77,253,239,51,36,221,218,168,105,178,33,33,196,193,246,243,158,115,222,67,235,93,121,7,38,27,223,216,213,187,225,96,56,40,243,149,245,235,124,102,193,212,214,117,238,171,69,115,165,170,114,225,238,218,58,111,92,85,14,7,191,134,131,179,117,123,91,184,25,240,77,136,205,192,172,200,189,7,50,247,54,44,245,141,15,11,186,69,103,223,191,222,250,170,176,141,253,209,189,189,220,83,219,124,94,149,197,6,124,106,221,28,76,39,114,189,154,84,69,219,33,110,62,207,193,7,80,218,135,254,219,197,40,166,146,147,88,51,104,112,34,97,76,226,8,114,196,52,140,162,56,75,34,148,8,169,229,232,178,151,127,144,226,155,186,203,84,182,33,97,235,253,117,93,205,194,99,154,223,5,210,232,41,10,118,225,209,219,103,245,138,101,93,61,120,91,171,194,217,178,153,110,214,118,95,52,167,41,163,146,64,67,169,128,68,167,8,10,165,49,76,8,139,36,37,138,25,65,143,137,238,65,215,203,170,180,7,49,82,51,33,185,214,16,19,162,33,17,52,129,76,241,20,146,88,49,98,16,146,25,99,39,97,68,81,232,213,186,168,54,182,246,193,15,98,190,114,229,77,233,154,253,102,8,196,5,150,130,66,34,163,12,102,58,142,33,23,52,14,205,160,17,77,84,20,174,211,128,215,85,221,228,197,141,63,194,75,81,36,211,52,86,80,167,34,164,101,112,224,41,35,33,69,42,67,177,194,41,230,230,36,222,214,228,61,199,5,55,228,77,245,18,220,113,187,51,206,254,178,25,22,4,107,169,158,25,15,113,150,117,198,211,76,49,36,149,200,78,98,119,89,62,103,189,210,72,146,34,205,83,149,194,68,102,41,204,76,87,87,137,196,206,228,154,99,166,146,158,117,100,144,236,108,89,186,217,182,176,71,144,145,226,136,243,80,90,193,16,134,36,193,28,50,157,24,152,18,21,153,132,202,152,27,188,67,118,247,120,60,6,239,125,187,90,229,245,230,227,83,224,188,227,156,131,188,195,128,54,112,64,19,64,224,62,47,90,123,245,103,215,248,249,182,3,242,93,217,188,90,167,111,221,81,65,55,217,213,249,85,25,95,170,198,62,4,67,45,55,192,222,135,73,217,170,128,224,214,133,216,60,223,252,155,148,237,128,239,182,238,207,117,138,51,154,100,8,154,76,137,183,250,116,80,107,72,236,103,200,200,205,131,78,183,112,182,6,213,2,52,75,11,124,239,80,208,134,34,128,139,73,187,182,245,189,243,85,125,249,31,226,183,102,239,202,185,63,78,6,75,150,112,19,254,23,38,244,220,160,8,10,73,178,208,115,22,9,106,50,147,144,116,219,243,199,225,224,241,55,182,152,130,212,31,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4df8bd7f-2981-4bed-9c2c-8844d6bb7389"));
		}

		#endregion

	}

	#endregion

}

