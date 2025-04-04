﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CopilotClientQuotaQueryExecutorSchema

	/// <exclude/>
	public class CopilotClientQuotaQueryExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CopilotClientQuotaQueryExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CopilotClientQuotaQueryExecutorSchema(CopilotClientQuotaQueryExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a14bbf97-71c5-4c23-bd93-9c6424ae9109");
			Name = "CopilotClientQuotaQueryExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("800f00c8-04db-4ed1-bc94-0c44b7e5e4f0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,86,223,111,211,48,16,126,46,18,255,131,41,18,74,164,226,138,215,109,93,213,149,22,85,226,199,160,131,23,132,144,151,92,91,11,199,201,108,103,44,154,248,223,57,219,73,155,180,73,182,199,156,239,62,127,119,247,249,46,146,37,160,51,22,1,153,43,96,134,167,116,158,102,92,164,230,229,139,199,151,47,6,185,230,114,75,214,133,54,144,208,143,92,222,157,239,141,55,160,20,211,233,198,208,89,150,45,49,54,87,160,219,142,231,169,220,240,109,174,44,186,164,31,64,206,86,237,110,10,186,236,116,33,13,55,188,11,31,29,150,44,50,169,234,240,88,72,197,163,93,2,210,208,149,52,160,54,152,175,166,243,29,51,243,52,201,4,56,98,223,176,14,169,212,14,1,49,94,43,216,162,153,204,5,211,250,172,44,202,92,112,4,249,154,167,134,125,205,65,21,139,7,136,114,188,215,69,252,124,15,27,150,11,115,197,101,140,247,7,166,200,32,221,4,43,199,189,104,248,135,35,242,25,11,79,38,100,248,4,242,48,252,133,208,89,126,43,120,68,34,203,133,60,17,65,206,200,21,211,208,176,141,72,27,11,4,126,116,204,247,201,46,57,136,88,159,145,107,197,239,153,1,127,152,249,15,130,250,136,83,41,10,162,141,178,245,253,13,14,114,29,237,32,97,221,233,12,207,91,65,86,78,8,135,250,175,65,221,243,8,174,85,250,80,144,223,209,177,253,188,36,10,50,246,92,155,196,81,99,200,42,183,26,176,244,93,185,74,246,190,116,79,20,45,248,174,65,33,136,132,200,94,74,242,198,231,200,2,13,6,189,148,79,24,135,216,136,91,108,68,112,132,213,90,163,144,60,186,59,78,19,199,162,182,21,99,48,248,215,95,17,100,149,129,178,111,166,163,157,139,90,247,90,202,211,56,158,92,58,118,205,34,209,186,203,39,38,217,22,20,62,111,179,194,86,48,25,193,85,97,69,17,156,200,36,124,162,151,159,192,236,210,78,21,250,75,253,180,130,46,218,65,205,82,189,107,18,51,195,70,141,180,157,4,8,232,187,170,252,145,149,81,165,111,147,254,1,169,103,247,140,11,118,43,240,46,145,39,178,210,249,77,243,208,139,124,32,82,185,157,182,7,254,96,34,183,145,150,5,189,65,94,194,67,56,142,83,156,173,9,55,100,50,33,111,223,121,177,77,123,61,189,207,89,63,218,219,174,227,117,126,171,35,197,51,219,197,239,26,251,230,217,151,165,245,253,66,170,253,162,160,190,5,101,193,155,210,8,61,160,71,162,107,48,181,26,4,101,237,28,199,225,168,55,133,231,224,184,4,186,113,78,114,237,197,236,236,249,168,167,171,97,189,124,53,101,121,23,194,182,91,84,182,219,126,165,101,98,53,71,253,135,166,75,174,180,249,162,202,237,17,68,213,107,27,68,116,165,103,101,48,196,228,205,27,18,68,212,221,184,120,200,112,217,106,68,156,210,101,46,253,204,98,186,33,238,217,225,90,199,166,242,11,167,180,30,126,205,204,206,234,174,51,243,50,59,190,33,193,105,38,175,38,68,230,66,84,239,199,121,85,149,45,85,178,207,82,198,87,69,173,106,110,56,156,32,82,119,165,37,212,192,29,52,65,103,113,236,221,131,161,93,232,56,120,80,0,29,88,158,190,29,151,53,156,101,170,34,56,234,125,123,252,168,124,15,118,178,61,75,41,97,121,163,191,80,1,254,23,201,18,227,57,115,251,48,253,106,75,108,60,30,147,11,157,39,9,83,197,101,101,248,230,160,53,254,21,216,247,73,238,172,222,9,151,155,84,37,254,87,107,31,57,62,14,189,200,152,98,9,145,72,119,50,68,45,14,47,151,92,224,143,145,166,23,99,119,116,240,244,9,232,75,247,156,220,35,195,125,36,68,185,2,46,198,213,121,109,215,122,21,206,247,94,4,75,119,108,11,122,231,112,215,248,198,151,115,186,33,93,103,14,1,40,50,247,177,138,131,176,99,174,245,239,14,191,39,44,27,31,126,207,84,45,101,140,151,240,247,36,199,163,1,216,220,51,123,25,123,10,94,30,231,117,125,28,240,123,52,226,173,77,35,218,254,3,233,149,62,69,195,11,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a14bbf97-71c5-4c23-bd93-9c6424ae9109"));
		}

		#endregion

	}

	#endregion

}

